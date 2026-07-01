using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._03_Thread_Safe_Implementation
{
    public class Singleton1
    {
        private static Singleton1 _instance;

        private Singleton1() { } // Private constructor prevents direct instantiation.

        public static Singleton1 Instance
        {
            get
            {
                if (_instance == null) // Object is created only when needed.
                {
                    _instance = new Singleton1();
                }
                return _instance;
            }
        }
    }

}
