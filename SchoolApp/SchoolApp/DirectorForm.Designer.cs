namespace SchoolApp
{
    partial class DirectorForm
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
            this.navigateToScheduleButton = new System.Windows.Forms.Button();
            this.navigateToAddStudentButton = new System.Windows.Forms.Button();
            this.navigateToAddEmployeeButton = new System.Windows.Forms.Button();
            this.navigateToMarksButton = new System.Windows.Forms.Button();
            this.navigateToDeactivateUserButton = new System.Windows.Forms.Button();
            this.navigateToChangeUserButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navigateToScheduleButton
            // 
            this.navigateToScheduleButton.Location = new System.Drawing.Point(131, 45);
            this.navigateToScheduleButton.Name = "navigateToScheduleButton";
            this.navigateToScheduleButton.Size = new System.Drawing.Size(161, 42);
            this.navigateToScheduleButton.TabIndex = 0;
            this.navigateToScheduleButton.Text = "Посмотреть расписание";
            this.navigateToScheduleButton.UseVisualStyleBackColor = true;
            this.navigateToScheduleButton.Click += new System.EventHandler(this.navigateToScheduleButton_Click);
            // 
            // navigateToAddStudentButton
            // 
            this.navigateToAddStudentButton.Location = new System.Drawing.Point(131, 114);
            this.navigateToAddStudentButton.Name = "navigateToAddStudentButton";
            this.navigateToAddStudentButton.Size = new System.Drawing.Size(161, 40);
            this.navigateToAddStudentButton.TabIndex = 1;
            this.navigateToAddStudentButton.Text = "Добавить ученика";
            this.navigateToAddStudentButton.UseVisualStyleBackColor = true;
            this.navigateToAddStudentButton.Click += new System.EventHandler(this.navigateToAddStudentButton_Click);
            // 
            // navigateToAddEmployeeButton
            // 
            this.navigateToAddEmployeeButton.Location = new System.Drawing.Point(131, 181);
            this.navigateToAddEmployeeButton.Name = "navigateToAddEmployeeButton";
            this.navigateToAddEmployeeButton.Size = new System.Drawing.Size(161, 34);
            this.navigateToAddEmployeeButton.TabIndex = 2;
            this.navigateToAddEmployeeButton.Text = "Добавить сотрудника";
            this.navigateToAddEmployeeButton.UseVisualStyleBackColor = true;
            this.navigateToAddEmployeeButton.Click += new System.EventHandler(this.navigateToAddEmployeeButton_Click);
            // 
            // navigateToMarksButton
            // 
            this.navigateToMarksButton.Location = new System.Drawing.Point(131, 235);
            this.navigateToMarksButton.Name = "navigateToMarksButton";
            this.navigateToMarksButton.Size = new System.Drawing.Size(161, 39);
            this.navigateToMarksButton.TabIndex = 3;
            this.navigateToMarksButton.Text = "Посмотреть оценки";
            this.navigateToMarksButton.UseVisualStyleBackColor = true;
            this.navigateToMarksButton.Click += new System.EventHandler(this.navigateToMarksButton_Click);
            // 
            // navigateToDeactivateUserButton
            // 
            this.navigateToDeactivateUserButton.Location = new System.Drawing.Point(130, 383);
            this.navigateToDeactivateUserButton.Name = "navigateToDeactivateUserButton";
            this.navigateToDeactivateUserButton.Size = new System.Drawing.Size(158, 44);
            this.navigateToDeactivateUserButton.TabIndex = 4;
            this.navigateToDeactivateUserButton.Text = "Деактивировать пользователя";
            this.navigateToDeactivateUserButton.UseVisualStyleBackColor = true;
            this.navigateToDeactivateUserButton.Click += new System.EventHandler(this.navigateToDeactivateUserButton_Click);
            // 
            // navigateToChangeUserButton
            // 
            this.navigateToChangeUserButton.Location = new System.Drawing.Point(130, 299);
            this.navigateToChangeUserButton.Name = "navigateToChangeUserButton";
            this.navigateToChangeUserButton.Size = new System.Drawing.Size(162, 42);
            this.navigateToChangeUserButton.TabIndex = 5;
            this.navigateToChangeUserButton.Text = "Редактирование пользователя";
            this.navigateToChangeUserButton.UseVisualStyleBackColor = true;
            this.navigateToChangeUserButton.Click += new System.EventHandler(this.navigateToChangeUserButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(15, 459);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(105, 45);
            this.signOutButton.TabIndex = 6;
            this.signOutButton.Text = "Выйти";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 562);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.navigateToChangeUserButton);
            this.Controls.Add(this.navigateToDeactivateUserButton);
            this.Controls.Add(this.navigateToMarksButton);
            this.Controls.Add(this.navigateToAddEmployeeButton);
            this.Controls.Add(this.navigateToAddStudentButton);
            this.Controls.Add(this.navigateToScheduleButton);
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button navigateToScheduleButton;
        private System.Windows.Forms.Button navigateToAddStudentButton;
        private System.Windows.Forms.Button navigateToAddEmployeeButton;
        private System.Windows.Forms.Button navigateToMarksButton;
        private System.Windows.Forms.Button navigateToDeactivateUserButton;
        private System.Windows.Forms.Button navigateToChangeUserButton;
        private System.Windows.Forms.Button signOutButton;
    }
}