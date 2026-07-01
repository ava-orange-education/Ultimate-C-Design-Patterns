using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._03_Implementation_Chain
{
    class LoggingHandler : BaseHandler
    {
        public override void Handle(string action)
        {
            if (action.StartsWith("Delete"))
            {
                Console.WriteLine($"LoggingHandler: Logging critical action '{action}'");
            }
            else
            {
                Console.WriteLine($"LoggingHandler: Non-critical, passing along.");
                base.Handle(action);
            }
        }
    }
}
