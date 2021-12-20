namespace SchoolApp
{
    partial class TeacherForm
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
            this.navigateToScheduleAsTeacherButton = new System.Windows.Forms.Button();
            this.navigateToMarksAsTeacherButton = new System.Windows.Forms.Button();
            this.navigateToAddMarksAsTeacherButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navigateToScheduleAsTeacherButton
            // 
            this.navigateToScheduleAsTeacherButton.Location = new System.Drawing.Point(235, 41);
            this.navigateToScheduleAsTeacherButton.Name = "navigateToScheduleAsTeacherButton";
            this.navigateToScheduleAsTeacherButton.Size = new System.Drawing.Size(146, 50);
            this.navigateToScheduleAsTeacherButton.TabIndex = 0;
            this.navigateToScheduleAsTeacherButton.Text = "Просмотр расписания";
            this.navigateToScheduleAsTeacherButton.UseVisualStyleBackColor = true;
            this.navigateToScheduleAsTeacherButton.Click += new System.EventHandler(this.navigateToScheduleAsTeacherButton_Click);
            // 
            // navigateToMarksAsTeacherButton
            // 
            this.navigateToMarksAsTeacherButton.Location = new System.Drawing.Point(233, 137);
            this.navigateToMarksAsTeacherButton.Name = "navigateToMarksAsTeacherButton";
            this.navigateToMarksAsTeacherButton.Size = new System.Drawing.Size(147, 45);
            this.navigateToMarksAsTeacherButton.TabIndex = 1;
            this.navigateToMarksAsTeacherButton.Text = "Просмотр оценок";
            this.navigateToMarksAsTeacherButton.UseVisualStyleBackColor = true;
            this.navigateToMarksAsTeacherButton.Click += new System.EventHandler(this.navigateToMarksAsTeacherButton_Click);
            // 
            // navigateToAddMarksAsTeacherButton
            // 
            this.navigateToAddMarksAsTeacherButton.Location = new System.Drawing.Point(232, 231);
            this.navigateToAddMarksAsTeacherButton.Name = "navigateToAddMarksAsTeacherButton";
            this.navigateToAddMarksAsTeacherButton.Size = new System.Drawing.Size(147, 42);
            this.navigateToAddMarksAsTeacherButton.TabIndex = 2;
            this.navigateToAddMarksAsTeacherButton.Text = "Выставление оценок";
            this.navigateToAddMarksAsTeacherButton.UseVisualStyleBackColor = true;
            this.navigateToAddMarksAsTeacherButton.Click += new System.EventHandler(this.navigateToAddMarksAsTeacherButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(33, 356);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(147, 56);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.navigateToAddMarksAsTeacherButton);
            this.Controls.Add(this.navigateToMarksAsTeacherButton);
            this.Controls.Add(this.navigateToScheduleAsTeacherButton);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button navigateToScheduleAsTeacherButton;
        private System.Windows.Forms.Button navigateToMarksAsTeacherButton;
        private System.Windows.Forms.Button navigateToAddMarksAsTeacherButton;
        private System.Windows.Forms.Button exitButton;
    }
}