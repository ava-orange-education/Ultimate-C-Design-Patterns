using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12._01_Introduction_Decorator
{
    // Concrete decorator B
    class MarkdownDecorator : FormatterDecorator
    {
        public override void Format()
        {
            base.Format();
            Console.WriteLine("Applying Markdown syntax.");
        }
    }
}
