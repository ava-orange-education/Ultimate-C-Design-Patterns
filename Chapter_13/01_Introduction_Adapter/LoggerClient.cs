using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._01_Introduction_Adapter
{
    // The client expects this interface
    class LoggerClient
    {
        public void LogMessage(ILogger logger)
        {
            logger.Log("Adapter pattern in action!");
        }
    }
}
