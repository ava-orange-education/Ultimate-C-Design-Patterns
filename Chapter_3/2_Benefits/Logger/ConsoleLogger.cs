using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._2_Benefits.Logger
{
    public class ConsoleLogger : Logger
    {
        public override void Log(string message) => Console.WriteLine($"Console Log: {message}");
    }
}
