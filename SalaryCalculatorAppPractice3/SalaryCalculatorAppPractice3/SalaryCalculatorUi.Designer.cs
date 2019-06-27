namespace SalaryCalculatorAppPractice3
{
    partial class SalaryCalculatorUi
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
            this.ShowMeSalaryButton = new System.Windows.Forms.Button();
            this.medicalAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.homeRentTextBox = new System.Windows.Forms.TextBox();
            this.basicAmountTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowMeSalaryButton
            // 
            this.ShowMeSalaryButton.Location = new System.Drawing.Point(153, 142);
            this.ShowMeSalaryButton.Name = "ShowMeSalaryButton";
            this.ShowMeSalaryButton.Size = new System.Drawing.Size(147, 23);
            this.ShowMeSalaryButton.TabIndex = 30;
            this.ShowMeSalaryButton.Text = "Show Me Salary";
            this.ShowMeSalaryButton.UseVisualStyleBackColor = true;
            this.ShowMeSalaryButton.Click += new System.EventHandler(this.ShowMeSalaryButton_Click);
            // 
            // medicalAllowanceTextBox
            // 
            this.medicalAllowanceTextBox.Location = new System.Drawing.Point(127, 105);
            this.medicalAllowanceTextBox.Name = "medicalAllowanceTextBox";
            this.medicalAllowanceTextBox.Size = new System.Drawing.Size(183, 20);
            this.medicalAllowanceTextBox.TabIndex = 26;
            // 
            // homeRentTextBox
            // 
            this.homeRentTextBox.Location = new System.Drawing.Point(127, 80);
            this.homeRentTextBox.Name = "homeRentTextBox";
            this.homeRentTextBox.Size = new System.Drawing.Size(183, 20);
            this.homeRentTextBox.TabIndex = 27;
            // 
            // basicAmountTextBox
            // 
            this.basicAmountTextBox.Location = new System.Drawing.Point(127, 55);
            this.basicAmountTextBox.Name = "basicAmountTextBox";
            this.basicAmountTextBox.Size = new System.Drawing.Size(183, 20);
            this.basicAmountTextBox.TabIndex = 28;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(127, 26);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(259, 20);
            this.employeeNameTextBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Medical Allowance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "0% of Basic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "0% of Basic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Home Rent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Basic Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Employee Name";
            // 
            // SalaryCalculatorUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 195);
            this.Controls.Add(this.ShowMeSalaryButton);
            this.Controls.Add(this.medicalAllowanceTextBox);
            this.Controls.Add(this.homeRentTextBox);
            this.Controls.Add(this.basicAmountTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryCalculatorUi";
            this.Text = "Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowMeSalaryButton;
        private System.Windows.Forms.TextBox medicalAllowanceTextBox;
        private System.Windows.Forms.TextBox homeRentTextBox;
        private System.Windows.Forms.TextBox basicAmountTextBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

