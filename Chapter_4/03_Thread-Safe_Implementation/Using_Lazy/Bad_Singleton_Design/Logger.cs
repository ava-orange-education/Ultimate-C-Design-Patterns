using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._03_Thread_Safe_Implementation.Using_Lazy.Bad_Singleton_Design
{
    public class Logger
    {
        private static Logger _instance;
        public string CurrentLog { get; set; }

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            CurrentLog += message + "\n"; // Shared mutable state
        }
    }
}
