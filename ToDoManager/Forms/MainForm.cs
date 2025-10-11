using ToDoManager.Forms;

namespace ToDoManager
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
        private bool dateFormatWord = true; // true = "5th of May 2048", false = "5/5/2048"

        public MainForm()
        {
            InitializeComponent();
        }

        private string ConstructDate()
        {
            if (!dateFormatWord)
            {
                return $@"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
            }
            else
            {
                return $@"{DateTime.Now.Day}th of {((Months)DateTime.Now.Month - 1).ToString()} {DateTime.Now.Year}";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Datelabel.Text = ConstructDate();
        }


        private void DateLabel_Click(object sender, EventArgs e)
        {
            dateFormatWord = !dateFormatWord;
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
            using (TaskForm taskForm = new TaskForm())
            {
                taskForm.ShowDialog();
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