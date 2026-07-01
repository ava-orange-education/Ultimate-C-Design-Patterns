using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._3_Implementation.LoggerFactory
{
    public class ConfigurableLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger(string type)
        {
            switch (type)
            {
                case "Console":
                    return new ConsoleLogger();
                case "File":
                    return new FileLogger();
                default:
                    throw new ArgumentException("Unknown logger type");
            }
        }
    }
}
