using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._01_Introduction_Decorator
{
    // Decorator base
    abstract class FormatterDecorator : MessageFormatter
    {
        protected MessageFormatter _formatter;

        public void SetFormatter(MessageFormatter formatter)
        {
            _formatter = formatter;
        }

        public override void Format()
        {
            if (_formatter != null)
                _formatter.Format();
        }
    }
}
