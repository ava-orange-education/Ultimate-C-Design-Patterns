using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._01_Introduction_Chain
{
    class LoggingHandler : RequestHandler
    {
        public override void Process(string action)
        {
            if (action == "CheckPermissions")
            {
                Console.WriteLine("LoggingHandler: Logging 'CheckPermissions'.");
            }
            else if (Next != null)
            {
                Next.Process(action);
            }
        }
    }
}
