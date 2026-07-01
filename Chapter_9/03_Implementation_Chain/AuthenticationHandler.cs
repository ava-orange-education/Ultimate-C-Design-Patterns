using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._03_Implementation_Chain
{
    class AuthenticationHandler : BaseHandler
    {
        public override void Handle(string action)
        {
            if (action == "Login" || action == "Logout")
            {
                Console.WriteLine($"AuthenticationHandler: Handling '{action}'");
            }
            else
            {
                Console.WriteLine($"AuthenticationHandler: Can't handle '{action}', passing to next.");
                base.Handle(action);
            }
        }
    }
}
