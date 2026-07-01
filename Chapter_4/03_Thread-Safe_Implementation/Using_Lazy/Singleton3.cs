using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._03_Thread_Safe_Implementation.Using_Lazy
{
    public class Singleton3
    {
        private static readonly Lazy<Singleton3> _instance = new Lazy<Singleton3>(() => new Singleton3());

        private Singleton3() { }

        public static Singleton3 Instance => _instance.Value;
    }

}
