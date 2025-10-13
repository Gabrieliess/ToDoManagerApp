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

        // Uloží jednu úlohu, ale zachová ostatné
        public static void SaveTask(TaskItem newTask)
        {
            try
            {
                // 1️⃣ Zabezpeč, že priečinok existuje
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath));

                // 2️⃣ Načítaj existujúce úlohy
                var tasks = LoadTasks();
                tasks.Add(newTask);

                // 3️⃣ Serializuj a zapíš
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

        // Načíta všetky úlohy
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
                MessageBox.Show($"Chyba pri načítaní: {ex.Message}");
                return new List<TaskItem>();
            }
        }
    }
}
