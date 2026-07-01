using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Singleton1
    {
        private static Singleton1 _instance;
        private static readonly object _lock = new();

        private Singleton1() { }

        public static Singleton1 Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new Singleton1();
                }
            }
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton instance in action!");
        }
    }

}
