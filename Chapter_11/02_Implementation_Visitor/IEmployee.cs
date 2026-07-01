using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._02_Implementation_Visitor
{
    public interface IEmployee
    {
        void Accept(IVisitor visitor);
    }
}
