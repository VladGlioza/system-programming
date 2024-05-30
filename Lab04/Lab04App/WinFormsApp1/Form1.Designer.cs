namespace WinFormsApp1
{
    partial class Form1
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
            this.GetAutoServisesButton = new System.Windows.Forms.Button();
            this.GetAutoServisesAllUsersButton = new System.Windows.Forms.Button();
            this.GetScheduleTasksButton = new System.Windows.Forms.Button();
            this.NewTaskTextBox = new System.Windows.Forms.TextBox();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.CopySectionButton = new System.Windows.Forms.Button();
            this.CopyTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetAutoServisesButton
            // 
            this.GetAutoServisesButton.BackColor = System.Drawing.Color.Orange;
            this.GetAutoServisesButton.Location = new System.Drawing.Point(15, 19);
            this.GetAutoServisesButton.Name = "GetAutoServisesButton";
            this.GetAutoServisesButton.Size = new System.Drawing.Size(290, 23);
            this.GetAutoServisesButton.TabIndex = 0;
            this.GetAutoServisesButton.Text = "Служби автозавантаження користувача";
            this.GetAutoServisesButton.UseVisualStyleBackColor = false;
            this.GetAutoServisesButton.Click += new System.EventHandler(this.GetAutoServisesButton_Click);
            // 
            // GetAutoServisesAllUsersButton
            // 
            this.GetAutoServisesAllUsersButton.BackColor = System.Drawing.Color.Orange;
            this.GetAutoServisesAllUsersButton.Location = new System.Drawing.Point(15, 48);
            this.GetAutoServisesAllUsersButton.Name = "GetAutoServisesAllUsersButton";
            this.GetAutoServisesAllUsersButton.Size = new System.Drawing.Size(290, 23);
            this.GetAutoServisesAllUsersButton.TabIndex = 1;
            this.GetAutoServisesAllUsersButton.Text = "Служби автозавантаження всіх користувачів";
            this.GetAutoServisesAllUsersButton.UseVisualStyleBackColor = false;
            this.GetAutoServisesAllUsersButton.Click += new System.EventHandler(this.GetAutoServisesAllUsersButton_Click);
            // 
            // GetScheduleTasksButton
            // 
            this.GetScheduleTasksButton.BackColor = System.Drawing.Color.Orange;
            this.GetScheduleTasksButton.Location = new System.Drawing.Point(15, 77);
            this.GetScheduleTasksButton.Name = "GetScheduleTasksButton";
            this.GetScheduleTasksButton.Size = new System.Drawing.Size(290, 23);
            this.GetScheduleTasksButton.TabIndex = 2;
            this.GetScheduleTasksButton.Text = "Таски Планувальника задач";
            this.GetScheduleTasksButton.UseVisualStyleBackColor = false;
            this.GetScheduleTasksButton.Click += new System.EventHandler(this.GetScheduleTasksButton_Click);
            // 
            // NewTaskTextBox
            // 
            this.NewTaskTextBox.Location = new System.Drawing.Point(15, 106);
            this.NewTaskTextBox.Name = "NewTaskTextBox";
            this.NewTaskTextBox.Size = new System.Drawing.Size(147, 23);
            this.NewTaskTextBox.TabIndex = 3;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddTaskButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddTaskButton.Location = new System.Drawing.Point(168, 106);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(137, 23);
            this.AddTaskButton.TabIndex = 4;
            this.AddTaskButton.Text = "Створити задачу";
            this.AddTaskButton.UseVisualStyleBackColor = false;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // CopySectionButton
            // 
            this.CopySectionButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CopySectionButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CopySectionButton.Location = new System.Drawing.Point(168, 135);
            this.CopySectionButton.Name = "CopySectionButton";
            this.CopySectionButton.Size = new System.Drawing.Size(137, 23);
            this.CopySectionButton.TabIndex = 6;
            this.CopySectionButton.Text = "Копіювати розділ";
            this.CopySectionButton.UseVisualStyleBackColor = false;
            this.CopySectionButton.Click += new System.EventHandler(this.CopySectionButton_Click);
            // 
            // CopyTextBox
            // 
            this.CopyTextBox.Location = new System.Drawing.Point(15, 135);
            this.CopyTextBox.Name = "CopyTextBox";
            this.CopyTextBox.Size = new System.Drawing.Size(147, 23);
            this.CopyTextBox.TabIndex = 5;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(331, 20);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(457, 418);
            this.OutputTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.CopySectionButton);
            this.Controls.Add(this.CopyTextBox);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.NewTaskTextBox);
            this.Controls.Add(this.GetScheduleTasksButton);
            this.Controls.Add(this.GetAutoServisesAllUsersButton);
            this.Controls.Add(this.GetAutoServisesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GetAutoServisesButton;
        private Button GetAutoServisesAllUsersButton;
        private Button GetScheduleTasksButton;
        private TextBox NewTaskTextBox;
        private Button AddTaskButton;
        private Button CopySectionButton;
        private TextBox CopyTextBox;
        private TextBox OutputTextBox;
    }
}