using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._2_Benefits.Logger
{
    public class LoggerFactory
    {
        public static Logger CreateLogger(string type)
        {
            switch (type)
            {
                case "Console":
                    return new ConsoleLogger();
                default:
                    throw new ArgumentException("Invalid logger type");
            }
        }
    }
}
