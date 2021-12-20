namespace SchoolApp
{
    partial class AddMarksForm
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
            this.chooseClCB = new System.Windows.Forms.ComboBox();
            this.chooseStComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseClassComboBox = new System.Windows.Forms.Label();
            this.chooseStudentComboBox = new System.Windows.Forms.Label();
            this.chooseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chooseDateTimeLabel = new System.Windows.Forms.Label();
            this.chooseMark = new System.Windows.Forms.Label();
            this.chooseMarkComboBox = new System.Windows.Forms.ComboBox();
            this.chooseDisciplineLabel = new System.Windows.Forms.Label();
            this.chooseDisciplineComboBox = new System.Windows.Forms.ComboBox();
            this.AddMarkButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseClCB
            // 
            this.chooseClCB.FormattingEnabled = true;
            this.chooseClCB.Location = new System.Drawing.Point(374, 85);
            this.chooseClCB.Name = "chooseClCB";
            this.chooseClCB.Size = new System.Drawing.Size(215, 21);
            this.chooseClCB.TabIndex = 0;
            this.chooseClCB.SelectedIndexChanged += new System.EventHandler(this.chooseClCB_SelectedIndexChanged);
            // 
            // chooseStComboBox
            // 
            this.chooseStComboBox.FormattingEnabled = true;
            this.chooseStComboBox.Location = new System.Drawing.Point(374, 146);
            this.chooseStComboBox.Name = "chooseStComboBox";
            this.chooseStComboBox.Size = new System.Drawing.Size(215, 21);
            this.chooseStComboBox.TabIndex = 1;
            this.chooseStComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseStComboBox_SelectedIndexChanged);
            // 
            // ChooseClassComboBox
            // 
            this.ChooseClassComboBox.AutoSize = true;
            this.ChooseClassComboBox.Location = new System.Drawing.Point(116, 88);
            this.ChooseClassComboBox.Name = "ChooseClassComboBox";
            this.ChooseClassComboBox.Size = new System.Drawing.Size(90, 13);
            this.ChooseClassComboBox.TabIndex = 2;
            this.ChooseClassComboBox.Text = "Выберите класс";
            // 
            // chooseStudentComboBox
            // 
            this.chooseStudentComboBox.AutoSize = true;
            this.chooseStudentComboBox.Location = new System.Drawing.Point(116, 146);
            this.chooseStudentComboBox.Name = "chooseStudentComboBox";
            this.chooseStudentComboBox.Size = new System.Drawing.Size(100, 13);
            this.chooseStudentComboBox.TabIndex = 3;
            this.chooseStudentComboBox.Text = "Выберите ученика";
            // 
            // chooseDateTimePicker
            // 
            this.chooseDateTimePicker.Location = new System.Drawing.Point(374, 204);
            this.chooseDateTimePicker.Name = "chooseDateTimePicker";
            this.chooseDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.chooseDateTimePicker.TabIndex = 4;
            // 
            // chooseDateTimeLabel
            // 
            this.chooseDateTimeLabel.AutoSize = true;
            this.chooseDateTimeLabel.Location = new System.Drawing.Point(116, 204);
            this.chooseDateTimeLabel.Name = "chooseDateTimeLabel";
            this.chooseDateTimeLabel.Size = new System.Drawing.Size(121, 13);
            this.chooseDateTimeLabel.TabIndex = 5;
            this.chooseDateTimeLabel.Text = "Выберите дату оценки";
            // 
            // chooseMark
            // 
            this.chooseMark.AutoSize = true;
            this.chooseMark.Location = new System.Drawing.Point(116, 253);
            this.chooseMark.Name = "chooseMark";
            this.chooseMark.Size = new System.Drawing.Size(95, 13);
            this.chooseMark.TabIndex = 6;
            this.chooseMark.Text = "Выберите оценку";
            // 
            // chooseMarkComboBox
            // 
            this.chooseMarkComboBox.FormattingEnabled = true;
            this.chooseMarkComboBox.Location = new System.Drawing.Point(376, 253);
            this.chooseMarkComboBox.Name = "chooseMarkComboBox";
            this.chooseMarkComboBox.Size = new System.Drawing.Size(134, 21);
            this.chooseMarkComboBox.TabIndex = 7;
            this.chooseMarkComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseMarkComboBox_SelectedIndexChanged);
            // 
            // chooseDisciplineLabel
            // 
            this.chooseDisciplineLabel.AutoSize = true;
            this.chooseDisciplineLabel.Location = new System.Drawing.Point(116, 308);
            this.chooseDisciplineLabel.Name = "chooseDisciplineLabel";
            this.chooseDisciplineLabel.Size = new System.Drawing.Size(103, 13);
            this.chooseDisciplineLabel.TabIndex = 8;
            this.chooseDisciplineLabel.Text = "Выберите предмет";
            // 
            // chooseDisciplineComboBox
            // 
            this.chooseDisciplineComboBox.FormattingEnabled = true;
            this.chooseDisciplineComboBox.Location = new System.Drawing.Point(374, 305);
            this.chooseDisciplineComboBox.Name = "chooseDisciplineComboBox";
            this.chooseDisciplineComboBox.Size = new System.Drawing.Size(136, 21);
            this.chooseDisciplineComboBox.TabIndex = 9;
            this.chooseDisciplineComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseDisciplineComboBox_SelectedIndexChanged);
            // 
            // AddMarkButton
            // 
            this.AddMarkButton.Location = new System.Drawing.Point(235, 368);
            this.AddMarkButton.Name = "AddMarkButton";
            this.AddMarkButton.Size = new System.Drawing.Size(229, 55);
            this.AddMarkButton.TabIndex = 10;
            this.AddMarkButton.Text = "Поставить оценку";
            this.AddMarkButton.UseVisualStyleBackColor = true;
            this.AddMarkButton.Click += new System.EventHandler(this.AddMarkButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorLabel.Location = new System.Drawing.Point(189, 40);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(369, 20);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "Ошибка! Проверьте, все ли поля вы заполнили";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(41, 453);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(169, 61);
            this.Back.TabIndex = 12;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddMarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.AddMarkButton);
            this.Controls.Add(this.chooseDisciplineComboBox);
            this.Controls.Add(this.chooseDisciplineLabel);
            this.Controls.Add(this.chooseMarkComboBox);
            this.Controls.Add(this.chooseMark);
            this.Controls.Add(this.chooseDateTimeLabel);
            this.Controls.Add(this.chooseDateTimePicker);
            this.Controls.Add(this.chooseStudentComboBox);
            this.Controls.Add(this.ChooseClassComboBox);
            this.Controls.Add(this.chooseStComboBox);
            this.Controls.Add(this.chooseClCB);
            this.Name = "AddMarksForm";
            this.Text = "AddMarksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseClCB;
        private System.Windows.Forms.ComboBox chooseStComboBox;
        private System.Windows.Forms.Label ChooseClassComboBox;
        private System.Windows.Forms.Label chooseStudentComboBox;
        private System.Windows.Forms.DateTimePicker chooseDateTimePicker;
        private System.Windows.Forms.Label chooseDateTimeLabel;
        private System.Windows.Forms.Label chooseMark;
        private System.Windows.Forms.ComboBox chooseMarkComboBox;
        private System.Windows.Forms.Label chooseDisciplineLabel;
        private System.Windows.Forms.ComboBox chooseDisciplineComboBox;
        private System.Windows.Forms.Button AddMarkButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button Back;
    }
}