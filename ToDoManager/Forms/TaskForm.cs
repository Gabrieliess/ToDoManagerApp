using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ToDoManager.Models;

namespace ToDoManager.Forms
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var VARIABLE in DateTextBox.Text.Split('.'))
                {
                     int.Parse(VARIABLE);
                }
                if (int.Parse(DateTextBox.Text.Split('.')[0]) <= 10)
                {
                    if
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            TaskItem newTask = new TaskItem
            {
                Title = TitleTextBox.Text,
                DueDate = DateOnly.Parse(DateTextBox.Text.Replace('.', '/')),
                Priority = PriorityTrackBar.Value switch
                {
                    0 => "Low",
                    1 => "Medium",
                    2 => "High",
                    3 => "Urgent",
                    4 => "Armageddon",
                    _ => "Undefined",
                },
                IsDone = false,
                Note = NoteTextBox.Text
            };
            Console.WriteLine(newTask.DueDate);
            this.Close();
        }
    }
}