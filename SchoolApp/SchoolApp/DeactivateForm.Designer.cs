namespace SchoolApp
{
    partial class DeactivateForm
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
            this.deactivateButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deactivateButton
            // 
            this.deactivateButton.Location = new System.Drawing.Point(283, 247);
            this.deactivateButton.Name = "deactivateButton";
            this.deactivateButton.Size = new System.Drawing.Size(175, 72);
            this.deactivateButton.TabIndex = 0;
            this.deactivateButton.Text = "Деативировать";
            this.deactivateButton.UseVisualStyleBackColor = true;
            this.deactivateButton.Click += new System.EventHandler(this.deactivateButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(63, 241);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 78);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(135, 121);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(283, 118);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(167, 20);
            this.loginTextBox.TabIndex = 3;
            // 
            // DeactivateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deactivateButton);
            this.Name = "DeactivateForm";
            this.Text = "DeactivateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deactivateButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
    }
}