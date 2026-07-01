using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._09_Examples_ASP_NET_Core
{
    public class WelcomeEmailSender : IWelcomeEmailSender
    {
        public void Send(string email)
        {
            Console.WriteLine($"Welcome email sent to {email}");
        }
    }
}
