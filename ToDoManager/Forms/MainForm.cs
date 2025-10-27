using System.Threading.Tasks;
using ToDoManager.Services;

namespace ToDoManager.Forms
{
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }


    public partial class MainForm : Form
    {
        private bool _dateFormatWord = true; // true = "5th of May 2048", false = "5/5/2048"
        private int _selectedTaskId = 0; // used to track selected task for deleting, value 0 > none selected

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            Datelabel.Text = ConstructDate();

            TasklistView.Items.Clear();

            foreach (var task in TaskStorage.LoadTasks())
            {
                ListViewItem item = new ListViewItem(task.Id.ToString());
                item.SubItems.Add(task.Title);
                item.SubItems.Add(editDate(task.DueDate.ToString()));
                item.SubItems.Add(task.Note);
                item.SubItems.Add(task.Priority);
                TasklistView.Items.Add(item);
            }
        }

        private string ConstructDate()
        {
            return !_dateFormatWord
                ? $@"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}"
                : $@"{DateTime.Now.Day}th of {((Months)DateTime.Now.Month - 1).ToString()} {DateTime.Now.Year}";
        }

        private string editDate(string date)
        {
            string dateString = "";
            foreach (var value in date.Split('.'))
            {
                value.Trim();

                if (value.Length < 2)
                {
                    dateString += "0" + value + ".";
                }

                else if (value.Length < 4)
                {
                    dateString += value + ".";
                }
                else
                {
                    dateString += value;
                }
            }

            return dateString;
        }

        private void DateLabel_Click(object sender, EventArgs e)
        {
            _dateFormatWord = !_dateFormatWord;
            Datelabel.Text = ConstructDate();
        }

        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = AppColors.MenuButtonHover;
            }
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = AppColors.MenuButton;
            }
        }

        private void NewTaskBtn_Click(object sender, EventArgs e)
        {
            using var taskForm = new TaskForm();
            var result = taskForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MainForm_Load(null, null);
            }
        }

        private void TasklistView_Click(object sender, EventArgs e)
        {
            _selectedTaskId = int.Parse(TasklistView.SelectedItems[0].SubItems[0].Text);
        }

        private void RemoveTaskBtn_Click(object sender, EventArgs e)
        {
            if (_selectedTaskId != 0)
            {
                var result = MessageBox.Show(
                    @$"Do you really want to nuke the selected task (ID: {_selectedTaskId})?",
                    @"Final decision",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show(@"alah akbar");
                        TaskStorage.DeleteTask(_selectedTaskId);
                        MainForm_Load(null, null);
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                MessageBox.Show(@"Select task you want to delete first.");
            }
        }
    }

    public static class AppColors
    {
        public static readonly Color Heading = Color.FromArgb(90, 40, 216);
        public static readonly Color MenuBar = Color.FromArgb(75, 0, 130);
        public static readonly Color Background = Color.FromArgb(26, 13, 51);
        public static readonly Color MenuButton = Color.FromArgb(75, 0, 130);
        public static readonly Color MenuButtonHover = Color.FromArgb(80, 5, 135);
        public static readonly Color Text = Color.FromArgb(220, 220, 220);
    }
}