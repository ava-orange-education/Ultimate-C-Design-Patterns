using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._03_Thread_Safe_Implementation.Double_Checked_Locking
{
    public class Singleton2
    {
        private static Singleton2 _instance;
        private static readonly object _lock = new object();

        private Singleton2() { }

        public static Singleton2 Instance
        {
            get
            {
                if (_instance == null) // First check outside lock
                {
                    lock (_lock) // Ensures only one thread enters at a time
                    {
                        if (_instance == null) // Second check inside lock
                        {
                            _instance = new Singleton2();
                        }
                    }
                }
                return _instance;
            }
        }
    }

}
