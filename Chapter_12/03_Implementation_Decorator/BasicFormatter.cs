using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._03_Implementation_Decorator
{
    public class BasicFormatter : IMessageFormatter
    {
        public string Format(string message)
        {
            return message;
        }
    }
}
