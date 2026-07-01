using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_03_AI_Driven
{
    public interface IExpression
    {
        double Interpret(Dictionary<string, double> context);
    }
}
