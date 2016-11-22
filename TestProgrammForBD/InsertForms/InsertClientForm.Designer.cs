namespace TestProgrammForBD.InsertForms
{
    partial class InsertClientForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.patrLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.inputAdressFiels = new System.Windows.Forms.TextBox();
            this.inputPhoneField = new System.Windows.Forms.TextBox();
            this.inputPatrField = new System.Windows.Forms.TextBox();
            this.inputSurnameField = new System.Windows.Forms.TextBox();
            this.inputNameField = new System.Windows.Forms.TextBox();
            this.sysLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 191);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(118, 191);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 51);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Surname";
            this.surnameLabel.Click += new System.EventHandler(this.surnameLabel_Click);
            // 
            // patrLabel
            // 
            this.patrLabel.AutoSize = true;
            this.patrLabel.Location = new System.Drawing.Point(13, 77);
            this.patrLabel.Name = "patrLabel";
            this.patrLabel.Size = new System.Drawing.Size(59, 13);
            this.patrLabel.TabIndex = 4;
            this.patrLabel.Text = "Patronymic";
            this.patrLabel.Click += new System.EventHandler(this.patrLabel_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(13, 103);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(75, 13);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "PhoneNumber";
            this.phoneLabel.Click += new System.EventHandler(this.phoneLabel_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 129);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(44, 13);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "address";
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // inputAdressFiels
            // 
            this.inputAdressFiels.Location = new System.Drawing.Point(93, 129);
            this.inputAdressFiels.Name = "inputAdressFiels";
            this.inputAdressFiels.Size = new System.Drawing.Size(100, 20);
            this.inputAdressFiels.TabIndex = 11;
            this.inputAdressFiels.TextChanged += new System.EventHandler(this.inputAdressFiels_TextChanged);
            // 
            // inputPhoneField
            // 
            this.inputPhoneField.Location = new System.Drawing.Point(93, 103);
            this.inputPhoneField.Name = "inputPhoneField";
            this.inputPhoneField.Size = new System.Drawing.Size(100, 20);
            this.inputPhoneField.TabIndex = 10;
            this.inputPhoneField.TextChanged += new System.EventHandler(this.inputPhoneField_TextChanged);
            // 
            // inputPatrField
            // 
            this.inputPatrField.Location = new System.Drawing.Point(93, 77);
            this.inputPatrField.Name = "inputPatrField";
            this.inputPatrField.Size = new System.Drawing.Size(100, 20);
            this.inputPatrField.TabIndex = 9;
            this.inputPatrField.TextChanged += new System.EventHandler(this.inputPatrField_TextChanged);
            // 
            // inputSurnameField
            // 
            this.inputSurnameField.Location = new System.Drawing.Point(93, 51);
            this.inputSurnameField.Name = "inputSurnameField";
            this.inputSurnameField.Size = new System.Drawing.Size(100, 20);
            this.inputSurnameField.TabIndex = 8;
            this.inputSurnameField.TextChanged += new System.EventHandler(this.inputSurnameField_TextChanged);
            // 
            // inputNameField
            // 
            this.inputNameField.Location = new System.Drawing.Point(93, 25);
            this.inputNameField.Name = "inputNameField";
            this.inputNameField.Size = new System.Drawing.Size(100, 20);
            this.inputNameField.TabIndex = 7;
            this.inputNameField.TextChanged += new System.EventHandler(this.inputNameField_TextChanged);
            // 
            // sysLabel
            // 
            this.sysLabel.AutoSize = true;
            this.sysLabel.Location = new System.Drawing.Point(74, 162);
            this.sysLabel.Name = "sysLabel";
            this.sysLabel.Size = new System.Drawing.Size(0, 13);
            this.sysLabel.TabIndex = 12;
            this.sysLabel.Click += new System.EventHandler(this.sysLabel_Click);
            // 
            // InsertClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 236);
            this.Controls.Add(this.sysLabel);
            this.Controls.Add(this.inputAdressFiels);
            this.Controls.Add(this.inputPhoneField);
            this.Controls.Add(this.inputPatrField);
            this.Controls.Add(this.inputSurnameField);
            this.Controls.Add(this.inputNameField);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.patrLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.closeButton);
            this.Name = "InsertClientForm";
            this.Text = "InsertClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label patrLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox inputAdressFiels;
        private System.Windows.Forms.TextBox inputPhoneField;
        private System.Windows.Forms.TextBox inputPatrField;
        private System.Windows.Forms.TextBox inputSurnameField;
        private System.Windows.Forms.TextBox inputNameField;
        private System.Windows.Forms.Label sysLabel;
    }
}