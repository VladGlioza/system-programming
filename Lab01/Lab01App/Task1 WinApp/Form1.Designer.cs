namespace Task1_WinApp
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
            this.components = new System.ComponentModel.Container();
            this.clear_btn = new System.Windows.Forms.Button();
            this.timer_btn = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear_btn.Location = new System.Drawing.Point(123, 12);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(122, 35);
            this.clear_btn.TabIndex = 0;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // timer_btn
            // 
            this.timer_btn.BackColor = System.Drawing.Color.SandyBrown;
            this.timer_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timer_btn.Location = new System.Drawing.Point(12, 12);
            this.timer_btn.Name = "timer_btn";
            this.timer_btn.Size = new System.Drawing.Size(105, 35);
            this.timer_btn.TabIndex = 1;
            this.timer_btn.Text = "Timer";
            this.timer_btn.UseVisualStyleBackColor = false;
            this.timer_btn.Click += new System.EventHandler(this.timer_btn_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(12, 53);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(776, 385);
            this.OutputTextBox.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.timer_btn);
            this.Controls.Add(this.clear_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button clear_btn;
        private Button timer_btn;
        private TextBox OutputTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}