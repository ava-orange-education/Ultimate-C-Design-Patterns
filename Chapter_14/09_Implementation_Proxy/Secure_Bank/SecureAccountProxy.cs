using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._09_Implementation_Proxy.Secure_Bank
{
    class SecureAccountProxy : IAccount
    {
        private BankAccount account;
        private string userRole;

        public SecureAccountProxy(string userRole, decimal initialBalance)
        {
            this.userRole = userRole;
            account = new BankAccount(initialBalance);
        }

        public void ShowBalance()
        {
            if (userRole != "Manager")
            {
                Console.WriteLine("Access denied: insufficient privileges.");
                return;
            }

            account.ShowBalance();
        }
    }
}
