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
            this.loadDLLButton = new System.Windows.Forms.Button();
            this.mathLibraryButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadDLLButton
            // 
            this.loadDLLButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadDLLButton.Location = new System.Drawing.Point(65, 12);
            this.loadDLLButton.Name = "loadDLLButton";
            this.loadDLLButton.Size = new System.Drawing.Size(194, 45);
            this.loadDLLButton.TabIndex = 0;
            this.loadDLLButton.Text = "Завантажити DLL";
            this.loadDLLButton.UseVisualStyleBackColor = false;
            this.loadDLLButton.Click += new System.EventHandler(this.loadDLLButton_Click);
            // 
            // mathLibraryButton
            // 
            this.mathLibraryButton.BackColor = System.Drawing.Color.LightSalmon;
            this.mathLibraryButton.Location = new System.Drawing.Point(65, 76);
            this.mathLibraryButton.Name = "mathLibraryButton";
            this.mathLibraryButton.Size = new System.Drawing.Size(194, 45);
            this.mathLibraryButton.TabIndex = 1;
            this.mathLibraryButton.Text = "Бібліотека Math";
            this.mathLibraryButton.UseVisualStyleBackColor = false;
            this.mathLibraryButton.Click += new System.EventHandler(this.mathLibraryButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.sortButton.Location = new System.Drawing.Point(65, 136);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(194, 45);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Сортування";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 193);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.mathLibraryButton);
            this.Controls.Add(this.loadDLLButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button loadDLLButton;
        private Button mathLibraryButton;
        private Button sortButton;
    }
}