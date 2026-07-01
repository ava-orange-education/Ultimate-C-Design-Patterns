using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._08_Implementation_Interpreter
{
    class NumberExpression : IExpression
    {
        private int value;

        public NumberExpression(int value)
        {
            this.value = value;
        }

        public int Evaluate()
        {
            return value;
        }
    }
}
