namespace AccountOperationAppPractice1
{
    partial class AccountOperationUi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DipositButton = new System.Windows.Forms.Button();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.accountNoTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.ReportButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.amountTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DipositButton);
            this.groupBox2.Controls.Add(this.WithdrawButton);
            this.groupBox2.Location = new System.Drawing.Point(16, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 95);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(131, 34);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(183, 20);
            this.amountTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // DipositButton
            // 
            this.DipositButton.Location = new System.Drawing.Point(131, 60);
            this.DipositButton.Name = "DipositButton";
            this.DipositButton.Size = new System.Drawing.Size(75, 23);
            this.DipositButton.TabIndex = 13;
            this.DipositButton.Text = "Diposit";
            this.DipositButton.UseVisualStyleBackColor = true;
            this.DipositButton.Click += new System.EventHandler(this.DipositButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(239, 60);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(75, 23);
            this.WithdrawButton.TabIndex = 13;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CreateButton);
            this.groupBox1.Controls.Add(this.accountNoTextBox);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 106);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Creation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Name";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(256, 75);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 13;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // accountNoTextBox
            // 
            this.accountNoTextBox.Location = new System.Drawing.Point(131, 20);
            this.accountNoTextBox.Name = "accountNoTextBox";
            this.accountNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.accountNoTextBox.TabIndex = 12;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(131, 49);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerNameTextBox.TabIndex = 11;
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(163, 222);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(151, 23);
            this.ReportButton.TabIndex = 15;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // AccountOperationUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 271);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReportButton);
            this.Name = "AccountOperationUi";
            this.Text = "Account Operation";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DipositButton;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox accountNoTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Button ReportButton;
    }
}

