using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        Calculator _calculator = new Calculator();

        public CalculatorUi()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _calculator.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            _calculator.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(_calculator.Add());
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            _calculator.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            _calculator.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(_calculator.Subtract());
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            _calculator.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            _calculator.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(_calculator.Multiply());
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            _calculator.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            _calculator.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(_calculator.Divide());
        }
    }
}
