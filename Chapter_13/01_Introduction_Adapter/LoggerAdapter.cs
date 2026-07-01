using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._01_Introduction_Adapter
{
    // The adapter that bridges the gap
    class LoggerAdapter : ILogger
    {
        private LegacyLogger legacyLogger = new LegacyLogger();

        public override void Log(string message)
        {
            legacyLogger.WriteLog(message);
        }
    }
}
