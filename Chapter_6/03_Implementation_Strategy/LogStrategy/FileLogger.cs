using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._03_Implementation_Strategy.LogStrategy
{
    public class FileLogger : ILogStrategy
    {
        public void Log(string message)
        {
            Console.WriteLine($"[File]: Writing '{message}' to log.txt");
        }
    }
}
