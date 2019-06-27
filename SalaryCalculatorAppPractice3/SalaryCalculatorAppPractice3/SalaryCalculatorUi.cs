using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        Employee _employee = new Employee();
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            _employee.Name = employeeNameTextBox.Text;
            _employee.BasicSalary = Convert.ToDouble(basicAmountTextBox.Text);
            _employee.HomeRent = Convert.ToDouble(homeRentTextBox.Text);
            _employee.MedicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            MessageBox.Show("Name: " + _employee.Name + "\nSalary is: " + _employee.CalculateSalary());
        }
    }
}
