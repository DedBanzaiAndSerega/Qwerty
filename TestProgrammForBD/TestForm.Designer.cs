namespace TestProgrammForBD
{
    partial class TestForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.conButton = new System.Windows.Forms.Button();
            this.sysLabel = new System.Windows.Forms.Label();
            this.baseName = new System.Windows.Forms.TextBox();
            this.chooseBox = new System.Windows.Forms.ComboBox();
            this.upButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.QuartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // conButton
            // 
            this.conButton.Location = new System.Drawing.Point(529, 12);
            this.conButton.Name = "conButton";
            this.conButton.Size = new System.Drawing.Size(75, 23);
            this.conButton.TabIndex = 0;
            this.conButton.Text = "connect";
            this.conButton.UseVisualStyleBackColor = true;
            this.conButton.Click += new System.EventHandler(this.conButton_Click);
            // 
            // sysLabel
            // 
            this.sysLabel.AutoSize = true;
            this.sysLabel.Location = new System.Drawing.Point(37, 272);
            this.sysLabel.Name = "sysLabel";
            this.sysLabel.Size = new System.Drawing.Size(0, 13);
            this.sysLabel.TabIndex = 1;
            // 
            // baseName
            // 
            this.baseName.Location = new System.Drawing.Point(12, 15);
            this.baseName.Name = "baseName";
            this.baseName.Size = new System.Drawing.Size(100, 20);
            this.baseName.TabIndex = 2;
            // 
            // chooseBox
            // 
            this.chooseBox.FormattingEnabled = true;
            this.chooseBox.Items.AddRange(new object[] {
            "Client",
            "Contract",
            "Proced",
            "Realtor",
            "TheProperty"});
            this.chooseBox.Location = new System.Drawing.Point(192, 14);
            this.chooseBox.Name = "chooseBox";
            this.chooseBox.Size = new System.Drawing.Size(121, 21);
            this.chooseBox.TabIndex = 3;
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(385, 14);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 23);
            this.upButton.TabIndex = 5;
            this.upButton.Text = "show";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 369);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(12, 41);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 7;
            this.delButton.Text = "delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 81);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(618, 188);
            this.dataGrid.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(645, 246);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(76, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(645, 196);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(76, 23);
            this.insertButton.TabIndex = 12;
            this.insertButton.Text = "insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // QuartButton
            // 
            this.QuartButton.Location = new System.Drawing.Point(342, 286);
            this.QuartButton.Name = "QuartButton";
            this.QuartButton.Size = new System.Drawing.Size(75, 23);
            this.QuartButton.TabIndex = 13;
            this.QuartButton.Text = "quarters";
            this.QuartButton.UseVisualStyleBackColor = true;
            this.QuartButton.Click += new System.EventHandler(this.QuartButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 404);
            this.Controls.Add(this.QuartButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.chooseBox);
            this.Controls.Add(this.baseName);
            this.Controls.Add(this.sysLabel);
            this.Controls.Add(this.conButton);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conButton;
        private System.Windows.Forms.Label sysLabel;
        private System.Windows.Forms.TextBox baseName;
        private System.Windows.Forms.ComboBox chooseBox;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button QuartButton;
    }
}

