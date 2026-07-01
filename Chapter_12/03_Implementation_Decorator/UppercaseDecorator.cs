using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._03_Implementation_Decorator
{
    public class UppercaseDecorator : MessageDecorator
    {
        public UppercaseDecorator(IMessageFormatter innerFormatter)
            : base(innerFormatter) { }

        public override string Format(string message)
        {
            var formatted = base.Format(message);
            return formatted.ToUpper();
        }
    }
}
