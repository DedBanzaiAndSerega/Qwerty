namespace TestProgrammForBD.InsertForms
{
    partial class InsertPropertyForm
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
            this.sysLabel = new System.Windows.Forms.Label();
            this.inputAddrField = new System.Windows.Forms.TextBox();
            this.inputJustField = new System.Windows.Forms.TextBox();
            this.inputLiveField = new System.Windows.Forms.TextBox();
            this.inputConField = new System.Windows.Forms.TextBox();
            this.addrLabel = new System.Windows.Forms.Label();
            this.justLabel = new System.Windows.Forms.Label();
            this.LivLabel = new System.Windows.Forms.Label();
            this.conLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sysLabel
            // 
            this.sysLabel.AutoSize = true;
            this.sysLabel.Location = new System.Drawing.Point(83, 132);
            this.sysLabel.Name = "sysLabel";
            this.sysLabel.Size = new System.Drawing.Size(0, 13);
            this.sysLabel.TabIndex = 38;
            // 
            // inputAddrField
            // 
            this.inputAddrField.Location = new System.Drawing.Point(98, 89);
            this.inputAddrField.Name = "inputAddrField";
            this.inputAddrField.Size = new System.Drawing.Size(100, 20);
            this.inputAddrField.TabIndex = 36;
            // 
            // inputJustField
            // 
            this.inputJustField.Location = new System.Drawing.Point(98, 63);
            this.inputJustField.Name = "inputJustField";
            this.inputJustField.Size = new System.Drawing.Size(100, 20);
            this.inputJustField.TabIndex = 35;
            // 
            // inputLiveField
            // 
            this.inputLiveField.Location = new System.Drawing.Point(98, 37);
            this.inputLiveField.Name = "inputLiveField";
            this.inputLiveField.Size = new System.Drawing.Size(100, 20);
            this.inputLiveField.TabIndex = 34;
            this.inputLiveField.TextChanged += new System.EventHandler(this.inputLiveField_TextChanged);
            // 
            // inputConField
            // 
            this.inputConField.Location = new System.Drawing.Point(98, 11);
            this.inputConField.Name = "inputConField";
            this.inputConField.Size = new System.Drawing.Size(100, 20);
            this.inputConField.TabIndex = 33;
            // 
            // addrLabel
            // 
            this.addrLabel.AutoSize = true;
            this.addrLabel.Location = new System.Drawing.Point(18, 89);
            this.addrLabel.Name = "addrLabel";
            this.addrLabel.Size = new System.Drawing.Size(44, 13);
            this.addrLabel.TabIndex = 31;
            this.addrLabel.Text = "address";
            // 
            // justLabel
            // 
            this.justLabel.AutoSize = true;
            this.justLabel.Location = new System.Drawing.Point(18, 63);
            this.justLabel.Name = "justLabel";
            this.justLabel.Size = new System.Drawing.Size(57, 13);
            this.justLabel.TabIndex = 30;
            this.justLabel.Text = "JustSpace";
            // 
            // LivLabel
            // 
            this.LivLabel.AutoSize = true;
            this.LivLabel.Location = new System.Drawing.Point(17, 37);
            this.LivLabel.Name = "LivLabel";
            this.LivLabel.Size = new System.Drawing.Size(66, 13);
            this.LivLabel.TabIndex = 29;
            this.LivLabel.Text = "LivingSpace";
            // 
            // conLabel
            // 
            this.conLabel.AutoSize = true;
            this.conLabel.Location = new System.Drawing.Point(18, 11);
            this.conLabel.Name = "conLabel";
            this.conLabel.Size = new System.Drawing.Size(51, 13);
            this.conLabel.TabIndex = 28;
            this.conLabel.Text = "Condition";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(114, 164);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 27;
            this.insertButton.Text = "insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 164);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 26;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // InsertPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 204);
            this.Controls.Add(this.sysLabel);
            this.Controls.Add(this.inputAddrField);
            this.Controls.Add(this.inputJustField);
            this.Controls.Add(this.inputLiveField);
            this.Controls.Add(this.inputConField);
            this.Controls.Add(this.addrLabel);
            this.Controls.Add(this.justLabel);
            this.Controls.Add(this.LivLabel);
            this.Controls.Add(this.conLabel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.closeButton);
            this.Name = "InsertPropertyForm";
            this.Text = "InsertPropertyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sysLabel;
        private System.Windows.Forms.TextBox inputAddrField;
        private System.Windows.Forms.TextBox inputJustField;
        private System.Windows.Forms.TextBox inputLiveField;
        private System.Windows.Forms.TextBox inputConField;
        private System.Windows.Forms.Label addrLabel;
        private System.Windows.Forms.Label justLabel;
        private System.Windows.Forms.Label LivLabel;
        private System.Windows.Forms.Label conLabel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button closeButton;
    }
}