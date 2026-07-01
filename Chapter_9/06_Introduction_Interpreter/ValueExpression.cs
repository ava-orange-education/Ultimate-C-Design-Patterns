using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._06_Introduction_Interpreter
{
    class ValueExpression : ExpressionUnit
    {
        public override void Interpret(SessionContext context)
        {
            Console.WriteLine("ValueExpression: 5");
        }
    }
}
