using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    class Account
    {
        public int accountNumber;
        public string customerName;
        private int balance;

        public bool CanDeposit(int amounth)
        {
            balance = balance + amounth;
            return true;
        }

        public bool CanWithdraw(int amounth)
        {
            balance = balance - amounth;
            return true;
        }

        public string GetReport()
        {
            return customerName + ", your account number: " + accountNumber + " and it's balance: " + balance + "taka";
        }
    }
}
