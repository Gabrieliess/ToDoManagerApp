namespace ToDoManager.Forms
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeadingPanel = new Panel();
            DateTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            TitleTextBox = new TextBox();
            LeftPanel = new Panel();
            RightPanel = new Panel();
            AddTaskBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PriorityTrackBar = new TrackBar();
            NoteTextBox = new RichTextBox();
            HeadingPanel.SuspendLayout();
            RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PriorityTrackBar).BeginInit();
            SuspendLayout();
            // 
            // HeadingPanel
            // 
            HeadingPanel.BackColor = Color.FromArgb(90, 40, 216);
            HeadingPanel.Controls.Add(DateTextBox);
            HeadingPanel.Controls.Add(label8);
            HeadingPanel.Controls.Add(label7);
            HeadingPanel.Controls.Add(TitleTextBox);
            HeadingPanel.Dock = DockStyle.Top;
            HeadingPanel.Font = new Font("DejaVu Sans Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            HeadingPanel.Location = new Point(0, 0);
            HeadingPanel.Margin = new Padding(0);
            HeadingPanel.Name = "HeadingPanel";
            HeadingPanel.Size = new Size(782, 60);
            HeadingPanel.TabIndex = 0;
            // 
            // DateTextBox
            // 
            DateTextBox.BackColor = Color.FromArgb(90, 40, 216);
            DateTextBox.Location = new Point(616, 18);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.PlaceholderText = "DD/MM/YYYY";
            DateTextBox.Size = new Size(144, 31);
            DateTextBox.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.MenuBar;
            label8.Location = new Point(552, 21);
            label8.Name = "label8";
            label8.Size = new Size(58, 24);
            label8.TabIndex = 2;
            label8.Text = "Due:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("DejaVu Sans Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(12, 12);
            label7.Name = "label7";
            label7.Size = new Size(117, 33);
            label7.TabIndex = 1;
            label7.Text = "Title:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.BackColor = Color.FromArgb(90, 40, 216);
            TitleTextBox.BorderStyle = BorderStyle.None;
            TitleTextBox.Font = new Font("DejaVu Sans Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            TitleTextBox.ForeColor = SystemColors.Window;
            TitleTextBox.Location = new Point(126, 12);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.PlaceholderText = "Enter task title...";
            TitleTextBox.Size = new Size(365, 32);
            TitleTextBox.TabIndex = 0;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.Indigo;
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 60);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(120, 313);
            LeftPanel.TabIndex = 1;
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.Indigo;
            RightPanel.Controls.Add(AddTaskBtn);
            RightPanel.Controls.Add(label6);
            RightPanel.Controls.Add(label5);
            RightPanel.Controls.Add(label4);
            RightPanel.Controls.Add(label3);
            RightPanel.Controls.Add(label2);
            RightPanel.Controls.Add(label1);
            RightPanel.Controls.Add(PriorityTrackBar);
            RightPanel.Dock = DockStyle.Right;
            RightPanel.Location = new Point(564, 60);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(218, 313);
            RightPanel.TabIndex = 2;
            // 
            // AddTaskBtn
            // 
            AddTaskBtn.BackColor = Color.SlateBlue;
            AddTaskBtn.FlatAppearance.BorderSize = 0;
            AddTaskBtn.FlatStyle = FlatStyle.Flat;
            AddTaskBtn.Font = new Font("DejaVu Sans Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AddTaskBtn.ForeColor = SystemColors.HighlightText;
            AddTaskBtn.Location = new Point(26, 264);
            AddTaskBtn.Margin = new Padding(0);
            AddTaskBtn.Name = "AddTaskBtn";
            AddTaskBtn.Size = new Size(170, 37);
            AddTaskBtn.TabIndex = 8;
            AddTaskBtn.Text = "Add Task";
            AddTaskBtn.UseVisualStyleBackColor = false;
            AddTaskBtn.Click += AddTaskBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(79, 210);
            label6.Name = "label6";
            label6.Size = new Size(46, 28);
            label6.TabIndex = 7;
            label6.Text = "Low";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(79, 171);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 6;
            label5.Text = "Medium";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(79, 131);
            label4.Name = "label4";
            label4.Size = new Size(57, 28);
            label4.TabIndex = 5;
            label4.Text = "High";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(79, 91);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 4;
            label3.Text = "Urgent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(79, 47);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 3;
            label2.Text = "Armageddon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(64, 16);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 2;
            label1.Text = "Priority";
            // 
            // PriorityTrackBar
            // 
            PriorityTrackBar.Location = new Point(17, 47);
            PriorityTrackBar.Maximum = 4;
            PriorityTrackBar.Name = "PriorityTrackBar";
            PriorityTrackBar.Orientation = Orientation.Vertical;
            PriorityTrackBar.Size = new Size(56, 196);
            PriorityTrackBar.TabIndex = 1;
            // 
            // NoteTextBox
            // 
            NoteTextBox.BackColor = Color.FromArgb(20, 7, 28);
            NoteTextBox.BorderStyle = BorderStyle.None;
            NoteTextBox.Cursor = Cursors.IBeam;
            NoteTextBox.Font = new Font("DejaVu Sans Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NoteTextBox.ForeColor = SystemColors.InactiveBorder;
            NoteTextBox.Location = new Point(126, 63);
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(432, 310);
            NoteTextBox.TabIndex = 3;
            NoteTextBox.Text = "Write some notes...";
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 7, 28);
            ClientSize = new Size(782, 373);
            Controls.Add(NoteTextBox);
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            Controls.Add(HeadingPanel);
            MaximumSize = new Size(800, 800);
            MinimumSize = new Size(800, 420);
            Name = "TaskForm";
            Text = "TaskForm";
            Load += TaskForm_Load;
            HeadingPanel.ResumeLayout(false);
            HeadingPanel.PerformLayout();
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PriorityTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeadingPanel;
        private Panel LeftPanel;
        private Panel RightPanel;
        private RichTextBox NoteTextBox;
        private TextBox TitleTextBox;
        private TrackBar PriorityTrackBar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Button AddTaskBtn;
        private Label label8;
        private TextBox DateTextBox;
    }
}