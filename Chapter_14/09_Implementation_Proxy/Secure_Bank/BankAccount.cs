using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._09_Implementation_Proxy.Secure_Bank
{
    class BankAccount : IAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Current balance: ${balance}");
        }
    }
}
