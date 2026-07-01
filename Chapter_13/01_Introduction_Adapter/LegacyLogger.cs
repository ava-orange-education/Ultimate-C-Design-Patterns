using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._01_Introduction_Adapter
{
    // The adaptee class with a different interface
    class LegacyLogger
    {
        public void WriteLog(string text)
        {
            Console.WriteLine($"Legacy log: {text}");
        }
    }
}
