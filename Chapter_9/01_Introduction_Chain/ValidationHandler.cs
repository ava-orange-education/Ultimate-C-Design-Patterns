using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._01_Introduction_Chain
{
    class ValidationHandler : RequestHandler
    {
        public override void Process(string action)
        {
            if (action == "ValidateUser")
            {
                Console.WriteLine("ValidationHandler: Processing 'ValidateUser'.");
            }
            else if (Next != null)
            {
                Next.Process(action);
            }
        }
    }
}
