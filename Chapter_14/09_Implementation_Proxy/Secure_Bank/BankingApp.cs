using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._09_Implementation_Proxy.Secure_Bank
{
    class BankingApp
    {
        public void Run()
        {
            IAccount account = new SecureAccountProxy("Guest", 1500.00m);
            account.ShowBalance(); // Access denied

            IAccount managerAccount = new SecureAccountProxy("Manager", 1500.00m);
            managerAccount.ShowBalance(); // Shows balance
        }
    }
}
