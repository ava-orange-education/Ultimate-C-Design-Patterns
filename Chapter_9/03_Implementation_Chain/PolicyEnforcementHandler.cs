using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._03_Implementation_Chain
{
    class PolicyEnforcementHandler : BaseHandler
    {
        public override void Handle(string action)
        {
            if (action == "DeleteAccount")
            {
                Console.WriteLine($"PolicyEnforcementHandler: Enforcing policies for '{action}'");
            }
            else
            {
                Console.WriteLine($"PolicyEnforcementHandler: '{action}' outside scope.");
                base.Handle(action);
            }
        }
    }
}
