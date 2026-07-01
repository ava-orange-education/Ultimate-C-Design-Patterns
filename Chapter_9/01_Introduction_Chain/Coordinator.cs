using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._01_Introduction_Chain
{
    class Coordinator
    {
        void Start()
        {
            RequestHandler validator = new ValidationHandler();
            RequestHandler logger = new LoggingHandler();

            validator.Next = logger;
            validator.Process("CheckPermissions");
        }
    }
}
