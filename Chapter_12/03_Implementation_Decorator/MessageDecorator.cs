using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._03_Implementation_Decorator
{
    public abstract class MessageDecorator : IMessageFormatter
    {
        protected IMessageFormatter _innerFormatter;

        public MessageDecorator(IMessageFormatter innerFormatter)
        {
            _innerFormatter = innerFormatter;
        }

        public virtual string Format(string message)
        {
            return _innerFormatter.Format(message);
        }
    }
}
