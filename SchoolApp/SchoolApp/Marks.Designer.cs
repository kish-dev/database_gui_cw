namespace SchoolApp
{
    partial class Marks
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
            this.components = new System.ComponentModel.Container();
            this.chooseClassComboBox = new System.Windows.Forms.ComboBox();
            this.chooseClassLabel = new System.Windows.Forms.Label();
            this.isQuarterMark = new System.Windows.Forms.CheckBox();
            this.choosePeriodEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chooseEndPeriodLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.marksDataGridView = new System.Windows.Forms.DataGridView();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дисциплина = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quarterMarksDataGridView = new System.Windows.Forms.DataGridView();
            this.quarterMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleQuarterDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseDisciplineLabel = new System.Windows.Forms.Label();
            this.chooseDisciplineComboBox = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseStudent = new System.Windows.Forms.ComboBox();
            this.chooseStudentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarterMarksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseClassComboBox
            // 
            this.chooseClassComboBox.FormattingEnabled = true;
            this.chooseClassComboBox.Location = new System.Drawing.Point(266, 55);
            this.chooseClassComboBox.Name = "chooseClassComboBox";
            this.chooseClassComboBox.Size = new System.Drawing.Size(173, 21);
            this.chooseClassComboBox.TabIndex = 1;
            this.chooseClassComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseClassComboBox_SelectedIndexChanged);
            // 
            // chooseClassLabel
            // 
            this.chooseClassLabel.AutoSize = true;
            this.chooseClassLabel.Location = new System.Drawing.Point(100, 58);
            this.chooseClassLabel.Name = "chooseClassLabel";
            this.chooseClassLabel.Size = new System.Drawing.Size(90, 13);
            this.chooseClassLabel.TabIndex = 2;
            this.chooseClassLabel.Text = "Выберите класс";
            // 
            // isQuarterMark
            // 
            this.isQuarterMark.AutoSize = true;
            this.isQuarterMark.Location = new System.Drawing.Point(103, 29);
            this.isQuarterMark.Name = "isQuarterMark";
            this.isQuarterMark.Size = new System.Drawing.Size(172, 17);
            this.isQuarterMark.TabIndex = 3;
            this.isQuarterMark.Text = "Выбрать оценки за четверть";
            this.isQuarterMark.UseVisualStyleBackColor = true;
            this.isQuarterMark.CheckedChanged += new System.EventHandler(this.isQuarterMark_CheckedChanged);
            // 
            // choosePeriodEndDateTimePicker
            // 
            this.choosePeriodEndDateTimePicker.Location = new System.Drawing.Point(271, 124);
            this.choosePeriodEndDateTimePicker.Name = "choosePeriodEndDateTimePicker";
            this.choosePeriodEndDateTimePicker.Size = new System.Drawing.Size(168, 20);
            this.choosePeriodEndDateTimePicker.TabIndex = 4;
            this.choosePeriodEndDateTimePicker.ValueChanged += new System.EventHandler(this.choosePeriodEndDateTimePicker_ValueChanged);
            // 
            // chooseEndPeriodLabel
            // 
            this.chooseEndPeriodLabel.AutoSize = true;
            this.chooseEndPeriodLabel.Location = new System.Drawing.Point(100, 130);
            this.chooseEndPeriodLabel.Name = "chooseEndPeriodLabel";
            this.chooseEndPeriodLabel.Size = new System.Drawing.Size(135, 13);
            this.chooseEndPeriodLabel.TabIndex = 5;
            this.chooseEndPeriodLabel.Text = "Выберите конец периода";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(21, 402);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(118, 35);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // marksDataGridView
            // 
            this.marksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mark,
            this.dateOfMark,
            this.Дисциплина});
            this.marksDataGridView.Location = new System.Drawing.Point(103, 177);
            this.marksDataGridView.Name = "marksDataGridView";
            this.marksDataGridView.Size = new System.Drawing.Size(442, 124);
            this.marksDataGridView.TabIndex = 7;
            // 
            // mark
            // 
            this.mark.HeaderText = "Оценка";
            this.mark.Name = "mark";
            // 
            // dateOfMark
            // 
            this.dateOfMark.HeaderText = "Дата оценки";
            this.dateOfMark.Name = "dateOfMark";
            // 
            // Дисциплина
            // 
            this.Дисциплина.HeaderText = "title";
            this.Дисциплина.Name = "Дисциплина";
            // 
            // quarterMarksDataGridView
            // 
            this.quarterMarksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quarterMarksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quarterMark,
            this.titleQuarterDiscipline,
            this.firstName,
            this.secondName,
            this.lastName});
            this.quarterMarksDataGridView.Location = new System.Drawing.Point(103, 177);
            this.quarterMarksDataGridView.Name = "quarterMarksDataGridView";
            this.quarterMarksDataGridView.Size = new System.Drawing.Size(540, 150);
            this.quarterMarksDataGridView.TabIndex = 8;
            // 
            // quarterMark
            // 
            this.quarterMark.HeaderText = "Четвертная оценка";
            this.quarterMark.Name = "quarterMark";
            // 
            // titleQuarterDiscipline
            // 
            this.titleQuarterDiscipline.HeaderText = "Дисциплина";
            this.titleQuarterDiscipline.Name = "titleQuarterDiscipline";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Имя";
            this.firstName.Name = "firstName";
            // 
            // secondName
            // 
            this.secondName.HeaderText = "Отчество";
            this.secondName.Name = "secondName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Фамилия";
            this.lastName.Name = "lastName";
            // 
            // chooseDisciplineLabel
            // 
            this.chooseDisciplineLabel.AutoSize = true;
            this.chooseDisciplineLabel.Location = new System.Drawing.Point(100, 96);
            this.chooseDisciplineLabel.Name = "chooseDisciplineLabel";
            this.chooseDisciplineLabel.Size = new System.Drawing.Size(97, 13);
            this.chooseDisciplineLabel.TabIndex = 9;
            this.chooseDisciplineLabel.Text = "Выбрать предмет";
            // 
            // chooseDisciplineComboBox
            // 
            this.chooseDisciplineComboBox.FormattingEnabled = true;
            this.chooseDisciplineComboBox.Location = new System.Drawing.Point(266, 88);
            this.chooseDisciplineComboBox.Name = "chooseDisciplineComboBox";
            this.chooseDisciplineComboBox.Size = new System.Drawing.Size(171, 21);
            this.chooseDisciplineComboBox.TabIndex = 10;
            this.chooseDisciplineComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseDisciplineComboBox_SelectedIndexChanged);
            // 
            // comboBoxChooseStudent
            // 
            this.comboBoxChooseStudent.FormattingEnabled = true;
            this.comboBoxChooseStudent.Location = new System.Drawing.Point(581, 96);
            this.comboBoxChooseStudent.Name = "comboBoxChooseStudent";
            this.comboBoxChooseStudent.Size = new System.Drawing.Size(151, 21);
            this.comboBoxChooseStudent.TabIndex = 14;
            this.comboBoxChooseStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseStudent_SelectedIndexChanged);
            // 
            // chooseStudentLabel
            // 
            this.chooseStudentLabel.AutoSize = true;
            this.chooseStudentLabel.Location = new System.Drawing.Point(466, 99);
            this.chooseStudentLabel.Name = "chooseStudentLabel";
            this.chooseStudentLabel.Size = new System.Drawing.Size(94, 13);
            this.chooseStudentLabel.TabIndex = 13;
            this.chooseStudentLabel.Text = "Выбрать ученика";
            // 
            // Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxChooseStudent);
            this.Controls.Add(this.chooseStudentLabel);
            this.Controls.Add(this.chooseDisciplineComboBox);
            this.Controls.Add(this.chooseDisciplineLabel);
            this.Controls.Add(this.quarterMarksDataGridView);
            this.Controls.Add(this.marksDataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.chooseEndPeriodLabel);
            this.Controls.Add(this.choosePeriodEndDateTimePicker);
            this.Controls.Add(this.isQuarterMark);
            this.Controls.Add(this.chooseClassLabel);
            this.Controls.Add(this.chooseClassComboBox);
            this.Name = "Marks";
            this.Text = "Marks";
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarterMarksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource marksBindingSource;
        private System.Windows.Forms.ComboBox chooseClassComboBox;
        private System.Windows.Forms.Label chooseClassLabel;
        private System.Windows.Forms.CheckBox isQuarterMark;
        private System.Windows.Forms.DateTimePicker choosePeriodEndDateTimePicker;
        private System.Windows.Forms.Label chooseEndPeriodLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView marksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дисциплина;
        private System.Windows.Forms.DataGridView quarterMarksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn quarterMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleQuarterDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.Label chooseDisciplineLabel;
        private System.Windows.Forms.ComboBox chooseDisciplineComboBox;
        private System.Windows.Forms.ComboBox comboBoxChooseStudent;
        private System.Windows.Forms.Label chooseStudentLabel;
    }
}