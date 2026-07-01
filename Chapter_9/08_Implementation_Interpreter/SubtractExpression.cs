using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._08_Implementation_Interpreter
{
    class SubtractExpression : IExpression
    {
        private IExpression left;
        private IExpression right;

        public SubtractExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Evaluate()
        {
            return left.Evaluate() - right.Evaluate();
        }
    }
}
