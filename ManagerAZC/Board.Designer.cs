namespace ManagerAZC
{
    partial class Board
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
            work_Label = new Label();
            lunch_Label = new Label();
            timeout_Label = new Label();
            startW_Button = new Button();
            stopW_Button = new Button();
            startL_Button = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            stopL_Button = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Label for Time to Warking in Real Time
            // 
            work_Label.AutoSize = true;
            work_Label.Location = new Point(3, 0);
            work_Label.Name = "label1";
            work_Label.Size = new Size(100, 15);
            work_Label.TabIndex = 0;
            work_Label.Text = "Working: 00:00:00";
            // 
            // label for Time to Lunch in Real Time. Time to work is paused.
            // 
            lunch_Label.AutoSize = true;
            lunch_Label.Location = new Point(143, 0);
            lunch_Label.Name = "label2";
            lunch_Label.Size = new Size(88, 15);
            lunch_Label.TabIndex = 1;
            lunch_Label.Text = "Lunch: 00:00:00";
            // 
            // label for Time of inactivity in the computer
            // 
            timeout_Label.AutoSize = true;
            timeout_Label.Location = new Point(283, 0);
            timeout_Label.Name = "label3";
            timeout_Label.Size = new Size(101, 15);
            timeout_Label.TabIndex = 2;
            timeout_Label.Text = "TimeOut: 00:00:00";
            // 
            // Start work's Timer
            // 
            startW_Button.Location = new Point(3, 31);
            startW_Button.Name = "button1";
            startW_Button.Size = new Size(88, 22);
            startW_Button.TabIndex = 3;
            startW_Button.Text = "Start Work";
            startW_Button.UseVisualStyleBackColor = true;
            // 
            // Stop work's Timer
            // 
            stopW_Button.Location = new Point(3, 59);
            stopW_Button.Name = "button2";
            stopW_Button.Size = new Size(88, 22);
            stopW_Button.TabIndex = 4;
            stopW_Button.Text = "Stop Work";
            stopW_Button.UseVisualStyleBackColor = true;
            // 
            // Start lunch's Timer
            // 
            startL_Button.Location = new Point(143, 31);
            startL_Button.Name = "button3";
            startL_Button.Size = new Size(101, 22);
            startL_Button.TabIndex = 5;
            startL_Button.Text = "Start Lunch";
            startL_Button.UseVisualStyleBackColor = true;
            // 
            // Grid for de Components
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(work_Label, 0, 0);
            tableLayoutPanel1.Controls.Add(lunch_Label, 1, 0);
            tableLayoutPanel1.Controls.Add(startW_Button, 0, 1);
            tableLayoutPanel1.Controls.Add(stopW_Button, 0, 2);
            tableLayoutPanel1.Controls.Add(startL_Button, 1, 1);
            tableLayoutPanel1.Controls.Add(stopL_Button, 1, 2);
            tableLayoutPanel1.Controls.Add(timeout_Label, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(421, 84);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // button4
            // 
            stopL_Button.Location = new Point(143, 59);
            stopL_Button.Name = "button4";
            stopL_Button.Size = new Size(101, 22);
            stopL_Button.TabIndex = 6;
            stopL_Button.Text = "Stop Lunch";
            stopL_Button.UseVisualStyleBackColor = true;
            // 
            // Board
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 109);
            Controls.Add(tableLayoutPanel1);
            Name = "Board";
            Text = "Board";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label work_Label;
        private Label lunch_Label;
        private Label timeout_Label;
        private Button startW_Button;
        private Button stopW_Button;
        private Button startL_Button;
        private TableLayoutPanel tableLayoutPanel1;
        private Button stopL_Button;
    }
}