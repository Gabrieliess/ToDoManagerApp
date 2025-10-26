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
using ToDoManager.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            Console.WriteLine(@"TaskForm loaded.");
        }


        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            //
            // data validation
            //

            if (string.IsNullOrWhiteSpace(TitleTextBox.Text) || string.IsNullOrWhiteSpace(DateTextBox.Text))
            {
                MessageBox.Show(@"Title and Date are required.");
                return;
            }

            if (DateTextBox.Text.Split('/').Length != 3)
            {
                MessageBox.Show(@"Invalid Date");
                return;
            }

            int counter = 0;

            foreach (string variable in DateTextBox.Text.Split('/'))
            {
                if (Int32.TryParse(variable, out _) == false)
                {
                    MessageBox.Show(@"Invalid Date");
                    return;
                }

                if (counter == 0)
                {
                    if (Int32.Parse(variable) < 1 || Int32.Parse(variable) > 31)
                    {
                        MessageBox.Show(@"Invalid Day");
                        return;
                    }
                }
                else if (counter == 1)
                {
                    if (Int32.Parse(variable) < 1 || Int32.Parse(variable) > 12)
                    {
                        MessageBox.Show(@"Invalid Month");
                        return;
                    }
                }
                else if (counter == 2)
                {
                    if (Int32.Parse(variable) < 2000 || Int32.Parse(variable) > 9999)
                    {
                        MessageBox.Show(@"Invalid Year");
                        return;
                    }
                }

                counter++;
            }

            TaskItem taskItem = new TaskItem
            {
                Title = TitleTextBox.Text,
                DueDate = DateOnly.Parse(DateTextBox.Text.Replace('.', '/')), // 12/4/2015
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
                Note = NoteTextBox.Text,
                Id = new Random().Next(10000, 99999)
            };

            TaskStorage.SaveTask(taskItem);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}