using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._05_Best_practices_Bridge
{
    class ConsoleLogger : Logger
    {
        public override void Log(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }
    }
}
