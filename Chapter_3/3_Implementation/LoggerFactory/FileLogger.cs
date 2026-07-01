using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._3_Implementation.LoggerFactory
{
    public class FileLogger : ILogger
    {
        public void Log(string message) => File.WriteAllText("log.txt", $"File Log: {message}");
    }
}
