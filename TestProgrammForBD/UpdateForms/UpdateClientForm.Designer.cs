namespace TestProgrammForBD
{
    partial class UpdateClientForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.patrLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addresLabel = new System.Windows.Forms.Label();
            this.outNameField = new System.Windows.Forms.TextBox();
            this.outSurnameField = new System.Windows.Forms.TextBox();
            this.outPatrField = new System.Windows.Forms.TextBox();
            this.outPhoneField = new System.Windows.Forms.TextBox();
            this.outAddresField = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.sysLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(72, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(72, 38);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 6;
            this.surnameLabel.Text = "Surname";
            // 
            // patrLabel
            // 
            this.patrLabel.AutoSize = true;
            this.patrLabel.Location = new System.Drawing.Point(74, 67);
            this.patrLabel.Name = "patrLabel";
            this.patrLabel.Size = new System.Drawing.Size(59, 13);
            this.patrLabel.TabIndex = 7;
            this.patrLabel.Text = "Patronymic";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(74, 93);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(75, 13);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "PhoneNumber";
            // 
            // addresLabel
            // 
            this.addresLabel.AutoSize = true;
            this.addresLabel.Location = new System.Drawing.Point(74, 119);
            this.addresLabel.Name = "addresLabel";
            this.addresLabel.Size = new System.Drawing.Size(40, 13);
            this.addresLabel.TabIndex = 9;
            this.addresLabel.Text = "Addres";
            // 
            // outNameField
            // 
            this.outNameField.Location = new System.Drawing.Point(156, 12);
            this.outNameField.Name = "outNameField";
            this.outNameField.Size = new System.Drawing.Size(161, 20);
            this.outNameField.TabIndex = 10;
            // 
            // outSurnameField
            // 
            this.outSurnameField.Location = new System.Drawing.Point(156, 38);
            this.outSurnameField.Name = "outSurnameField";
            this.outSurnameField.Size = new System.Drawing.Size(161, 20);
            this.outSurnameField.TabIndex = 11;
            // 
            // outPatrField
            // 
            this.outPatrField.Location = new System.Drawing.Point(156, 64);
            this.outPatrField.Name = "outPatrField";
            this.outPatrField.Size = new System.Drawing.Size(161, 20);
            this.outPatrField.TabIndex = 12;
            // 
            // outPhoneField
            // 
            this.outPhoneField.Location = new System.Drawing.Point(156, 90);
            this.outPhoneField.Name = "outPhoneField";
            this.outPhoneField.Size = new System.Drawing.Size(161, 20);
            this.outPhoneField.TabIndex = 13;
            // 
            // outAddresField
            // 
            this.outAddresField.Location = new System.Drawing.Point(156, 116);
            this.outAddresField.Name = "outAddresField";
            this.outAddresField.Size = new System.Drawing.Size(161, 20);
            this.outAddresField.TabIndex = 14;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(286, 176);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 176);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sysLabel
            // 
            this.sysLabel.AutoSize = true;
            this.sysLabel.Location = new System.Drawing.Point(133, 181);
            this.sysLabel.Name = "sysLabel";
            this.sysLabel.Size = new System.Drawing.Size(0, 13);
            this.sysLabel.TabIndex = 17;
            // 
            // UpdateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 211);
            this.Controls.Add(this.sysLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.outAddresField);
            this.Controls.Add(this.outPhoneField);
            this.Controls.Add(this.outPatrField);
            this.Controls.Add(this.outSurnameField);
            this.Controls.Add(this.outNameField);
            this.Controls.Add(this.addresLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.patrLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "UpdateClientForm";
            this.Text = "UpdateClientForm";
            this.Load += new System.EventHandler(this.UpdateClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label patrLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addresLabel;
        private System.Windows.Forms.TextBox outNameField;
        private System.Windows.Forms.TextBox outSurnameField;
        private System.Windows.Forms.TextBox outPatrField;
        private System.Windows.Forms.TextBox outPhoneField;
        private System.Windows.Forms.TextBox outAddresField;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label sysLabel;
    }
}