using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._04_Examples_Visitor
{
    public class EvalVisitor : IExprVisitor
    {
        public int Result;

        public void VisitLiteral(Literal lit) => Result = lit.Value;

        public void VisitAdd(Add add)
        {
            add.Left.Accept(this);
            int left = Result;
            add.Right.Accept(this);
            Result += left;
        }
    }
}
