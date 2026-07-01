using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._04_Examples_Visitor
{
    public class Customer : IEntity
    {
        public string Name;
        public double PurchaseTotal;

        public void Accept(IReportVisitor visitor) => visitor.VisitCustomer(this);
    }
}
