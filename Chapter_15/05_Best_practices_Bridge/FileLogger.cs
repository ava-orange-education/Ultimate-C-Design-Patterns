using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._05_Best_practices_Bridge
{
    class FileLogger : Logger
    {
        public override void Log(string message)
        {
            File.AppendAllText("log.txt", message + Environment.NewLine);
        }
    }
}
