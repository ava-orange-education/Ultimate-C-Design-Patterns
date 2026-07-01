using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._08_Implementation_Interpreter
{
    class InterpreterClient
    {
        public void Run()
        {
            IExpression five = new NumberExpression(5);
            IExpression three = new NumberExpression(3);
            IExpression two = new NumberExpression(2);

            IExpression subtraction = new SubtractExpression(three, two);
            IExpression addition = new AddExpression(five, subtraction);

            int result = addition.Evaluate();
            Console.WriteLine($"Result: {result}");
        }
    }
}
