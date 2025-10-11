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
            MenuPanel = new Panel();
            Datelabel = new Label();
            HeadingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HeadingPanel
            // 
            HeadingPanel.BackColor = Color.FromArgb(90, 40, 216);
            HeadingPanel.Controls.Add(Datelabel);
            HeadingPanel.Dock = DockStyle.Top;
            HeadingPanel.Location = new Point(0, 0);
            HeadingPanel.Margin = new Padding(3, 2, 3, 2);
            HeadingPanel.Name = "HeadingPanel";
            HeadingPanel.Size = new Size(1133, 78);
            HeadingPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(64, 34, 135);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 78);
            MenuPanel.Margin = new Padding(0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(170, 574);
            MenuPanel.TabIndex = 1;
            // 
            // Datelabel
            // 
            Datelabel.AutoSize = true;
            Datelabel.ForeColor = SystemColors.HighlightText;
            Datelabel.Location = new Point(16, 13);
            Datelabel.Name = "Datelabel";
            Datelabel.Size = new Size(168, 33);
            Datelabel.TabIndex = 0;
            Datelabel.Text = "Datelabel";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 7, 28);
            ClientSize = new Size(1133, 652);
            Controls.Add(MenuPanel);
            Controls.Add(HeadingPanel);
            Font = new Font("DejaVu Sans Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(7, 5, 7, 5);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            HeadingPanel.ResumeLayout(false);
            HeadingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeadingPanel;
        private Panel MenuPanel;
        private Label Datelabel;
    }
}
