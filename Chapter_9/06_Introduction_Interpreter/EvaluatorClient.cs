using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._06_Introduction_Interpreter
{
    class EvaluatorClient
    {
        void Execute()
        {
            SessionContext context = new SessionContext();

            ExpressionUnit expr = new CompoundExpression(
                new ValueExpression(5),
                new ValueExpression(3)
            );

            expr.Interpret(context);
        }
    }
}
