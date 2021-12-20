namespace SchoolApp
{
    partial class AddUser
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
            this.registerButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.chooseRoleLabel = new System.Windows.Forms.Label();
            this.chooseClassTeacherLabel = new System.Windows.Forms.Label();
            this.chooseClassForStudentLabel = new System.Windows.Forms.Label();
            this.firsNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.chooseRoleComboBox = new System.Windows.Forms.ComboBox();
            this.chooseClassStComboBox = new System.Windows.Forms.ComboBox();
            this.chooseClassTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(515, 237);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(169, 70);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Зарегистрировать";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(44, 117);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(44, 154);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(44, 194);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(52, 13);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Телефон";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(44, 228);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(34, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "e-mail";
            // 
            // chooseRoleLabel
            // 
            this.chooseRoleLabel.AutoSize = true;
            this.chooseRoleLabel.Location = new System.Drawing.Point(44, 271);
            this.chooseRoleLabel.Name = "chooseRoleLabel";
            this.chooseRoleLabel.Size = new System.Drawing.Size(78, 13);
            this.chooseRoleLabel.TabIndex = 5;
            this.chooseRoleLabel.Text = "Выбрать роль";
            // 
            // chooseClassTeacherLabel
            // 
            this.chooseClassTeacherLabel.AutoSize = true;
            this.chooseClassTeacherLabel.Location = new System.Drawing.Point(44, 341);
            this.chooseClassTeacherLabel.Name = "chooseClassTeacherLabel";
            this.chooseClassTeacherLabel.Size = new System.Drawing.Size(167, 13);
            this.chooseClassTeacherLabel.TabIndex = 6;
            this.chooseClassTeacherLabel.Text = "Выбрать класс для управления";
            // 
            // chooseClassForStudentLabel
            // 
            this.chooseClassForStudentLabel.AutoSize = true;
            this.chooseClassForStudentLabel.Location = new System.Drawing.Point(44, 307);
            this.chooseClassForStudentLabel.Name = "chooseClassForStudentLabel";
            this.chooseClassForStudentLabel.Size = new System.Drawing.Size(148, 13);
            this.chooseClassForStudentLabel.TabIndex = 7;
            this.chooseClassForStudentLabel.Text = "Выбрать класс для ученика";
            // 
            // firsNameLabel
            // 
            this.firsNameLabel.AutoSize = true;
            this.firsNameLabel.Location = new System.Drawing.Point(44, 376);
            this.firsNameLabel.Name = "firsNameLabel";
            this.firsNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firsNameLabel.TabIndex = 8;
            this.firsNameLabel.Text = "Имя";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(44, 417);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(44, 457);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(54, 13);
            this.secondNameLabel.TabIndex = 10;
            this.secondNameLabel.Text = "Отчество";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(272, 110);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(130, 20);
            this.loginTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(272, 147);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(130, 20);
            this.passwordTextBox.TabIndex = 12;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(272, 187);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(130, 20);
            this.phoneTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(272, 221);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(130, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // chooseRoleComboBox
            // 
            this.chooseRoleComboBox.FormattingEnabled = true;
            this.chooseRoleComboBox.Location = new System.Drawing.Point(272, 268);
            this.chooseRoleComboBox.Name = "chooseRoleComboBox";
            this.chooseRoleComboBox.Size = new System.Drawing.Size(130, 21);
            this.chooseRoleComboBox.TabIndex = 15;
            this.chooseRoleComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseRoleComboBox_SelectedIndexChanged);
            // 
            // chooseClassStComboBox
            // 
            this.chooseClassStComboBox.FormattingEnabled = true;
            this.chooseClassStComboBox.Location = new System.Drawing.Point(272, 299);
            this.chooseClassStComboBox.Name = "chooseClassStComboBox";
            this.chooseClassStComboBox.Size = new System.Drawing.Size(130, 21);
            this.chooseClassStComboBox.TabIndex = 16;
            this.chooseClassStComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseClassStComboBox_SelectedIndexChanged);
            // 
            // chooseClassTeacherComboBox
            // 
            this.chooseClassTeacherComboBox.FormattingEnabled = true;
            this.chooseClassTeacherComboBox.Location = new System.Drawing.Point(272, 333);
            this.chooseClassTeacherComboBox.Name = "chooseClassTeacherComboBox";
            this.chooseClassTeacherComboBox.Size = new System.Drawing.Size(130, 21);
            this.chooseClassTeacherComboBox.TabIndex = 17;
            this.chooseClassTeacherComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseClassTeacherComboBox_SelectedIndexChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(272, 369);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.firstNameTextBox.TabIndex = 18;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(272, 410);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.lastNameTextBox.TabIndex = 19;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(272, 450);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.secondNameTextBox.TabIndex = 20;
            // 
            // changeUserButton
            // 
            this.changeUserButton.Location = new System.Drawing.Point(515, 237);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(169, 70);
            this.changeUserButton.TabIndex = 21;
            this.changeUserButton.Text = "Изменить";
            this.changeUserButton.UseVisualStyleBackColor = true;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorLabel.Location = new System.Drawing.Point(134, 47);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(448, 20);
            this.errorLabel.TabIndex = 22;
            this.errorLabel.Text = "Проверьте корректность введенных необходимых полей!";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(516, 369);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(167, 72);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 498);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.chooseClassTeacherComboBox);
            this.Controls.Add(this.chooseClassStComboBox);
            this.Controls.Add(this.chooseRoleComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firsNameLabel);
            this.Controls.Add(this.chooseClassForStudentLabel);
            this.Controls.Add(this.chooseClassTeacherLabel);
            this.Controls.Add(this.chooseRoleLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.registerButton);
            this.Name = "AddUser";
            this.Text = "Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label chooseRoleLabel;
        private System.Windows.Forms.Label chooseClassTeacherLabel;
        private System.Windows.Forms.Label chooseClassForStudentLabel;
        private System.Windows.Forms.Label firsNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox chooseRoleComboBox;
        private System.Windows.Forms.ComboBox chooseClassStComboBox;
        private System.Windows.Forms.ComboBox chooseClassTeacherComboBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.Button changeUserButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button backButton;
    }
}