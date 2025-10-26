using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateOnly DueDate { get; set; }
        public string Priority { get; set; }
        public bool IsDone { get; set; }
        public string Note { get; set; }
    }
}