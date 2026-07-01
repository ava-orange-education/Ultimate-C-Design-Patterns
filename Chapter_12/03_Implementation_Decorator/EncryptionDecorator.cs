using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._03_Implementation_Decorator
{
    public class EncryptionDecorator : MessageDecorator
    {
        public EncryptionDecorator(IMessageFormatter innerFormatter)
            : base(innerFormatter) { }

        public override string Format(string message)
        {
            var formatted = base.Format(message);
            char[] chars = formatted.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
