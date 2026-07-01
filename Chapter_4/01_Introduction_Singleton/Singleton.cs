using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._01_Introduction_Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (_lock) // Ensures thread-safety
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello from Singleton!");
        }
    }
}
