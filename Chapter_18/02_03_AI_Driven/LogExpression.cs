using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_03_AI_Driven
{
    public class LogExpression : IExpression
    {
        private readonly IExpression _inner;

        public LogExpression(IExpression inner)
        {
            _inner = inner;
        }

        public double Interpret(Dictionary<string, double> context)
        {
            return Math.Log(_inner.Interpret(context));
        }
    }
}
