namespace ToDoManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeadingPanel = new Panel();
            Datelabel = new Label();
            MenuPanel = new Panel();
            RemoveTaskBtn = new Button();
            NewTaskBtn = new Button();
            TasklistView = new ListView();
            TitleColumn = new ColumnHeader();
            DueDateColumn = new ColumnHeader();
            NoteColumn = new ColumnHeader();
            PriorityColumn = new ColumnHeader();
            HeadingPanel.SuspendLayout();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HeadingPanel
            // 
            HeadingPanel.BackColor = Color.FromArgb(90, 40, 216);
            HeadingPanel.Controls.Add(Datelabel);
            HeadingPanel.Dock = DockStyle.Top;
            HeadingPanel.Location = new Point(0, 0);
            HeadingPanel.Margin = new Padding(0);
            HeadingPanel.Name = "HeadingPanel";
            HeadingPanel.Size = new Size(1062, 78);
            HeadingPanel.TabIndex = 0;
            // 
            // Datelabel
            // 
            Datelabel.AutoSize = true;
            Datelabel.ForeColor = SystemColors.HighlightText;
            Datelabel.Location = new Point(12, 24);
            Datelabel.Name = "Datelabel";
            Datelabel.Size = new Size(389, 33);
            Datelabel.TabIndex = 0;
            Datelabel.Text = "11th of September 2001";
            Datelabel.Click += DateLabel_Click;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.Indigo;
            MenuPanel.Controls.Add(RemoveTaskBtn);
            MenuPanel.Controls.Add(NewTaskBtn);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 78);
            MenuPanel.Margin = new Padding(0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(170, 595);
            MenuPanel.TabIndex = 1;
            // 
            // RemoveTaskBtn
            // 
            RemoveTaskBtn.FlatAppearance.BorderSize = 0;
            RemoveTaskBtn.FlatStyle = FlatStyle.Flat;
            RemoveTaskBtn.Font = new Font("DejaVu Sans Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RemoveTaskBtn.ForeColor = SystemColors.HighlightText;
            RemoveTaskBtn.Location = new Point(0, 60);
            RemoveTaskBtn.Margin = new Padding(0);
            RemoveTaskBtn.Name = "RemoveTaskBtn";
            RemoveTaskBtn.Size = new Size(170, 60);
            RemoveTaskBtn.TabIndex = 1;
            RemoveTaskBtn.Text = "Remove Task";
            RemoveTaskBtn.UseVisualStyleBackColor = true;
            RemoveTaskBtn.MouseEnter += MenuButton_MouseEnter;
            RemoveTaskBtn.MouseLeave += MenuButton_MouseLeave;
            // 
            // NewTaskBtn
            // 
            NewTaskBtn.FlatAppearance.BorderSize = 0;
            NewTaskBtn.FlatStyle = FlatStyle.Flat;
            NewTaskBtn.Font = new Font("DejaVu Sans Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NewTaskBtn.ForeColor = SystemColors.HighlightText;
            NewTaskBtn.Location = new Point(0, 0);
            NewTaskBtn.Margin = new Padding(0);
            NewTaskBtn.Name = "NewTaskBtn";
            NewTaskBtn.Size = new Size(170, 60);
            NewTaskBtn.TabIndex = 0;
            NewTaskBtn.Text = "New Task";
            NewTaskBtn.UseVisualStyleBackColor = true;
            NewTaskBtn.Click += NewTaskBtn_Click;
            NewTaskBtn.MouseEnter += MenuButton_MouseEnter;
            NewTaskBtn.MouseLeave += MenuButton_MouseLeave;
            // 
            // TasklistView
            // 
            TasklistView.Columns.AddRange(new ColumnHeader[] { TitleColumn, DueDateColumn, NoteColumn, PriorityColumn });
            TasklistView.Dock = DockStyle.Bottom;
            TasklistView.Font = new Font("DejaVu Sans Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TasklistView.ForeColor = SystemColors.Window;
            TasklistView.FullRowSelect = true;
            TasklistView.GridLines = true;
            TasklistView.Location = new Point(170, 78);
            TasklistView.Margin = new Padding(0);
            TasklistView.Name = "TasklistView";
            TasklistView.Size = new Size(892, 595);
            TasklistView.TabIndex = 2;
            TasklistView.UseCompatibleStateImageBehavior = false;
            TasklistView.View = View.Details;
            // 
            // TitleColumn
            // 
            TitleColumn.Text = "Title";
            TitleColumn.Width = 180;
            // 
            // DueDateColumn
            // 
            DueDateColumn.Text = "Due Date";
            DueDateColumn.Width = 120;
            // 
            // NoteColumn
            // 
            NoteColumn.Text = "Note";
            NoteColumn.Width = 500;
            // 
            // PriorityColumn
            // 
            PriorityColumn.Text = "Priority";
            PriorityColumn.Width = 92;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 7, 28);
            ClientSize = new Size(1062, 673);
            Controls.Add(TasklistView);
            Controls.Add(MenuPanel);
            Controls.Add(HeadingPanel);
            Font = new Font("DejaVu Sans Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(7, 5, 7, 5);
            MinimumSize = new Size(1080, 720);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            HeadingPanel.ResumeLayout(false);
            HeadingPanel.PerformLayout();
            MenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel HeadingPanel;
        private Panel MenuPanel;
        private Label Datelabel;
        private Button NewTaskBtn;
        private Button RemoveTaskBtn;
        private ListView TasklistView;
        private ColumnHeader TitleColumn;
        private ColumnHeader DueDateColumn;
        private ColumnHeader NoteColumn;
        private ColumnHeader PriorityColumn;
    }
}
