using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._04_Examples_Visitor
{
    public interface IExprVisitor
    {
        void VisitLiteral(Literal lit);
        void VisitAdd(Add add);
    }
}
