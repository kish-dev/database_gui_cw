namespace SchoolApp
{
    partial class ClassroomTeacher
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
            this.navigateToMarkAsClassroomTeacherButton = new System.Windows.Forms.Button();
            this.navigateToScheduleAsClassroomTeacherButton = new System.Windows.Forms.Button();
            this.navigateToAddMarksAsClassroomTeacherButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navigateToMarkAsClassroomTeacherButton
            // 
            this.navigateToMarkAsClassroomTeacherButton.Location = new System.Drawing.Point(335, 176);
            this.navigateToMarkAsClassroomTeacherButton.Name = "navigateToMarkAsClassroomTeacherButton";
            this.navigateToMarkAsClassroomTeacherButton.Size = new System.Drawing.Size(112, 49);
            this.navigateToMarkAsClassroomTeacherButton.TabIndex = 0;
            this.navigateToMarkAsClassroomTeacherButton.Text = "Просмотр оценок";
            this.navigateToMarkAsClassroomTeacherButton.UseVisualStyleBackColor = true;
            this.navigateToMarkAsClassroomTeacherButton.Click += new System.EventHandler(this.navigateToMarkAsClassroomTeacherButton_Click);
            // 
            // navigateToScheduleAsClassroomTeacherButton
            // 
            this.navigateToScheduleAsClassroomTeacherButton.Location = new System.Drawing.Point(332, 81);
            this.navigateToScheduleAsClassroomTeacherButton.Name = "navigateToScheduleAsClassroomTeacherButton";
            this.navigateToScheduleAsClassroomTeacherButton.Size = new System.Drawing.Size(115, 48);
            this.navigateToScheduleAsClassroomTeacherButton.TabIndex = 1;
            this.navigateToScheduleAsClassroomTeacherButton.Text = "Просмотр расписания";
            this.navigateToScheduleAsClassroomTeacherButton.UseVisualStyleBackColor = true;
            this.navigateToScheduleAsClassroomTeacherButton.Click += new System.EventHandler(this.navigateToScheduleAsClassroomTeacherButton_Click);
            // 
            // navigateToAddMarksAsClassroomTeacherButton
            // 
            this.navigateToAddMarksAsClassroomTeacherButton.Location = new System.Drawing.Point(335, 263);
            this.navigateToAddMarksAsClassroomTeacherButton.Name = "navigateToAddMarksAsClassroomTeacherButton";
            this.navigateToAddMarksAsClassroomTeacherButton.Size = new System.Drawing.Size(112, 39);
            this.navigateToAddMarksAsClassroomTeacherButton.TabIndex = 2;
            this.navigateToAddMarksAsClassroomTeacherButton.Text = "Выставление оценок";
            this.navigateToAddMarksAsClassroomTeacherButton.UseVisualStyleBackColor = true;
            this.navigateToAddMarksAsClassroomTeacherButton.Click += new System.EventHandler(this.navigateToAddMarksAsClassroomTeacherButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(27, 352);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 51);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ClassroomTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.navigateToAddMarksAsClassroomTeacherButton);
            this.Controls.Add(this.navigateToScheduleAsClassroomTeacherButton);
            this.Controls.Add(this.navigateToMarkAsClassroomTeacherButton);
            this.Name = "ClassroomTeacher";
            this.Text = "ClassroomTeacher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button navigateToMarkAsClassroomTeacherButton;
        private System.Windows.Forms.Button navigateToScheduleAsClassroomTeacherButton;
        private System.Windows.Forms.Button navigateToAddMarksAsClassroomTeacherButton;
        private System.Windows.Forms.Button exitButton;
    }
}