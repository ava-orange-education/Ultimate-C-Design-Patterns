using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_03_AI_Driven
{
    public class VariableExpression : IExpression
    {
        private readonly string _name;

        public VariableExpression(string name)
        {
            _name = name;
        }

        public double Interpret(Dictionary<string, double> context)
        {
            return context[_name];
        }
    }
}
