using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._04_Examples_Visitor
{
    public class Add : ExprNode
    {
        public ExprNode Left, Right;
        public override void Accept(IExprVisitor visitor) => visitor.VisitAdd(this);
    }
}
