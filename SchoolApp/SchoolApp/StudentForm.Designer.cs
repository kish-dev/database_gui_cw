namespace SchoolApp
{
    partial class StudentForm
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
            this.navigateToMarksAsStudentButton = new System.Windows.Forms.Button();
            this.navigateToScheduleAsStudentButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navigateToMarksAsStudentButton
            // 
            this.navigateToMarksAsStudentButton.Location = new System.Drawing.Point(317, 122);
            this.navigateToMarksAsStudentButton.Name = "navigateToMarksAsStudentButton";
            this.navigateToMarksAsStudentButton.Size = new System.Drawing.Size(146, 47);
            this.navigateToMarksAsStudentButton.TabIndex = 0;
            this.navigateToMarksAsStudentButton.Text = "Просмотр оценок";
            this.navigateToMarksAsStudentButton.UseVisualStyleBackColor = true;
            this.navigateToMarksAsStudentButton.Click += new System.EventHandler(this.navigateToMarksAsStudentButton_Click);
            // 
            // navigateToScheduleAsStudentButton
            // 
            this.navigateToScheduleAsStudentButton.Location = new System.Drawing.Point(317, 242);
            this.navigateToScheduleAsStudentButton.Name = "navigateToScheduleAsStudentButton";
            this.navigateToScheduleAsStudentButton.Size = new System.Drawing.Size(146, 45);
            this.navigateToScheduleAsStudentButton.TabIndex = 1;
            this.navigateToScheduleAsStudentButton.Text = "Просмотр расписания";
            this.navigateToScheduleAsStudentButton.UseVisualStyleBackColor = true;
            this.navigateToScheduleAsStudentButton.Click += new System.EventHandler(this.navigateToScheduleAsStudentButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(54, 339);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 58);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.navigateToScheduleAsStudentButton);
            this.Controls.Add(this.navigateToMarksAsStudentButton);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button navigateToMarksAsStudentButton;
        private System.Windows.Forms.Button navigateToScheduleAsStudentButton;
        private System.Windows.Forms.Button exitButton;
    }
}