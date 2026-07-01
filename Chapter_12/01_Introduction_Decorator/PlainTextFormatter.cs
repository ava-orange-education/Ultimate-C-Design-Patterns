using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._01_Introduction_Decorator
{
    // Concrete component
    class PlainTextFormatter : MessageFormatter
    {
        public override void Format()
        {
            Console.WriteLine("Formatting plain text message.");
        }
    }
}
