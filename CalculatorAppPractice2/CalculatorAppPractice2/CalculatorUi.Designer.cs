namespace CalculatorAppPractice2
{
    partial class CalculatorUi
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
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(265, 125);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 23);
            this.DivideButton.TabIndex = 16;
            this.DivideButton.Text = "Divide";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(185, 125);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplyButton.TabIndex = 17;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(107, 125);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(75, 23);
            this.SubtractButton.TabIndex = 18;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(27, 125);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(138, 84);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(183, 20);
            this.resultTextBox.TabIndex = 13;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(138, 59);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(183, 20);
            this.secondNumberTextBox.TabIndex = 14;
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(138, 30);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(183, 20);
            this.firstNumberTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Second Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Number";
            // 
            // CalculatorUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 189);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorUi";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

