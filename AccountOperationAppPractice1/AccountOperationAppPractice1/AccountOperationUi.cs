using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account _accountObj = new Account();
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _accountObj.customerName = customerNameTextBox.Text;
            _accountObj.accountNumber = Convert.ToInt32(accountNoTextBox.Text);

            customerNameTextBox.Text = "";
            accountNoTextBox.Text = "";
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {

            _accountObj.CanDeposit(Convert.ToInt32(amountTextBox.Text));
            amountTextBox.Text = "";
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            _accountObj.CanWithdraw(Convert.ToInt32(amountTextBox.Text));
            amountTextBox.Text = "";
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_accountObj.GetReport());
        }
    }
}
