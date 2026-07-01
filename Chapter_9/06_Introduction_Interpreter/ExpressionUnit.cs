using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._06_Introduction_Interpreter
{
    abstract class ExpressionUnit
    {
        public abstract void Interpret(SessionContext context);
    }
}
