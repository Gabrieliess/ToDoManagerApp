using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using ToDoManager.Models;

namespace ToDoManager.Services
{
    public static class TaskStorage
    {
        private static readonly string FilePath = Path.Combine(
            Application.StartupPath,
            "Data",
            "tasks.json"
        );

        public static void SaveTask(TaskItem newTask)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath));

                var tasks = LoadTasks();
                tasks.Add(newTask);

                string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pri ukladaní: {ex.Message}");
            }
        }

        public static List<TaskItem> LoadTasks()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
                    File.WriteAllText(FilePath, "[]");
                    return new List<TaskItem>();
                }

                var json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@$"Err while loading tasks: {ex.Message}");
                return new List<TaskItem>();
            }
        }

        public static void DeleteTask(int taskId)
        {
            try
            {
                var tasks = LoadTasks();
                tasks.RemoveAll(t => t.Id == taskId);
                string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@$"Could not delete selected task ({taskId}): {ex.Message}");
            }
        }
    }
}