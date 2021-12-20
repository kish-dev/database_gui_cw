namespace SchoolApp
{
    partial class ScheduleForm
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
            this.chooseClassLabel = new System.Windows.Forms.Label();
            this.chooseClassComboBox = new System.Windows.Forms.ComboBox();
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.chooseEndDateLabel = new System.Windows.Forms.Label();
            this.chooseEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.chooseBeginDateLabel = new System.Windows.Forms.Label();
            this.chooseBeginDatePicker = new System.Windows.Forms.DateTimePicker();
            this.backButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseClassLabel
            // 
            this.chooseClassLabel.AutoSize = true;
            this.chooseClassLabel.Location = new System.Drawing.Point(132, 51);
            this.chooseClassLabel.Name = "chooseClassLabel";
            this.chooseClassLabel.Size = new System.Drawing.Size(84, 13);
            this.chooseClassLabel.TabIndex = 0;
            this.chooseClassLabel.Text = "Выбрать класс";
            // 
            // chooseClassComboBox
            // 
            this.chooseClassComboBox.FormattingEnabled = true;
            this.chooseClassComboBox.Location = new System.Drawing.Point(282, 51);
            this.chooseClassComboBox.Name = "chooseClassComboBox";
            this.chooseClassComboBox.Size = new System.Drawing.Size(149, 21);
            this.chooseClassComboBox.TabIndex = 1;
            this.chooseClassComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseClassComboBox_SelectedIndexChanged);
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.classNumber,
            this.classLetter,
            this.Date,
            this.firstNameTeacher,
            this.secondNameTeacher,
            this.lastNameTeacher});
            this.scheduleDataGridView.Location = new System.Drawing.Point(53, 201);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.Size = new System.Drawing.Size(832, 150);
            this.scheduleDataGridView.TabIndex = 2;
            // 
            // chooseEndDateLabel
            // 
            this.chooseEndDateLabel.AutoSize = true;
            this.chooseEndDateLabel.Location = new System.Drawing.Point(132, 143);
            this.chooseEndDateLabel.Name = "chooseEndDateLabel";
            this.chooseEndDateLabel.Size = new System.Drawing.Size(109, 13);
            this.chooseEndDateLabel.TabIndex = 3;
            this.chooseEndDateLabel.Text = "Выбрать дату конца";
            // 
            // chooseEndDatePicker
            // 
            this.chooseEndDatePicker.Location = new System.Drawing.Point(282, 137);
            this.chooseEndDatePicker.Name = "chooseEndDatePicker";
            this.chooseEndDatePicker.Size = new System.Drawing.Size(149, 20);
            this.chooseEndDatePicker.TabIndex = 4;
            // 
            // chooseBeginDateLabel
            // 
            this.chooseBeginDateLabel.AutoSize = true;
            this.chooseBeginDateLabel.Location = new System.Drawing.Point(132, 99);
            this.chooseBeginDateLabel.Name = "chooseBeginDateLabel";
            this.chooseBeginDateLabel.Size = new System.Drawing.Size(114, 13);
            this.chooseBeginDateLabel.TabIndex = 5;
            this.chooseBeginDateLabel.Text = "Выбрать дату начала";
            // 
            // chooseBeginDatePicker
            // 
            this.chooseBeginDatePicker.Location = new System.Drawing.Point(282, 95);
            this.chooseBeginDatePicker.Name = "chooseBeginDatePicker";
            this.chooseBeginDatePicker.Size = new System.Drawing.Size(148, 20);
            this.chooseBeginDatePicker.TabIndex = 6;
            this.chooseBeginDatePicker.Value = new System.DateTime(2021, 12, 13, 0, 0, 0, 0);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(18, 371);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(102, 56);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // title
            // 
            this.title.HeaderText = "Название предмета";
            this.title.Name = "title";
            // 
            // classNumber
            // 
            this.classNumber.HeaderText = "Номер класса";
            this.classNumber.Name = "classNumber";
            // 
            // classLetter
            // 
            this.classLetter.HeaderText = "Буква класса";
            this.classLetter.Name = "classLetter";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            // 
            // firstNameTeacher
            // 
            this.firstNameTeacher.HeaderText = "Имя учителя";
            this.firstNameTeacher.Name = "firstNameTeacher";
            // 
            // secondNameTeacher
            // 
            this.secondNameTeacher.HeaderText = "Отчество учителя";
            this.secondNameTeacher.Name = "secondNameTeacher";
            // 
            // lastNameTeacher
            // 
            this.lastNameTeacher.HeaderText = "Фамилия учителя";
            this.lastNameTeacher.Name = "lastNameTeacher";
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.chooseBeginDatePicker);
            this.Controls.Add(this.chooseBeginDateLabel);
            this.Controls.Add(this.chooseEndDatePicker);
            this.Controls.Add(this.chooseEndDateLabel);
            this.Controls.Add(this.scheduleDataGridView);
            this.Controls.Add(this.chooseClassComboBox);
            this.Controls.Add(this.chooseClassLabel);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseClassLabel;
        private System.Windows.Forms.ComboBox chooseClassComboBox;
        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.Label chooseEndDateLabel;
        private System.Windows.Forms.DateTimePicker chooseEndDatePicker;
        private System.Windows.Forms.Label chooseBeginDateLabel;
        private System.Windows.Forms.DateTimePicker chooseBeginDatePicker;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn classLetter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameTeacher;
    }
}