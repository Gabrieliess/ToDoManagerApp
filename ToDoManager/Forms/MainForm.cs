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
        public MainForm()
        {
            InitializeComponent();
        }

        private string ConstructDate()
        {
            string month = ((Months)DateTime.Now.Month - 1).ToString();
            string date = @"";
            return $@"{DateTime.Now.Day}th of {month}, {DateTime.Now.Year}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Datelabel.Text = ConstructDate();
        }
    }
}