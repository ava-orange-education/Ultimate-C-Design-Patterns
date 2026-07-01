using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._04_Real_World_Examples
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private readonly List<string> _logs = new List<string>();

        private Logger() { }

        public static Logger Instance => _instance;

        public void Log(string message)
        {
            _logs.Add($"{DateTime.Now}: {message}");
        }

        public void PrintLogs()
        {
            foreach (var log in _logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
