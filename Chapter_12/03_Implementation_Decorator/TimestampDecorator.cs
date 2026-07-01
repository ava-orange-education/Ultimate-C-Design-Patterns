using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._03_Implementation_Decorator
{
    public class TimestampDecorator : MessageDecorator
    {
        public TimestampDecorator(IMessageFormatter innerFormatter)
            : base(innerFormatter) { }

        public override string Format(string message)
        {
            var formatted = base.Format(message);
            return $"{DateTime.Now}: {formatted}";
        }
    }
}
