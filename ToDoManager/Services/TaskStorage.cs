using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager.Services;

using System.Text.Json;
using ToDoManager.Models;

public static class TaskStorage
{
    private const string FilePath = "Datafiles\\tasks.json";

    public static void Save(List<TaskItem> tasks)
    {
        var json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }

    public static List<TaskItem> Load()
    {
        if (!File.Exists(FilePath)) return new List<TaskItem>();
        var json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
    }
}