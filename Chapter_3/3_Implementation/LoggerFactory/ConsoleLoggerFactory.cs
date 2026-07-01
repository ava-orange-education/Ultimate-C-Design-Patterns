using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._3_Implementation.LoggerFactory
{
    public class ConsoleLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger(string type = null) => new ConsoleLogger();
    }
}
