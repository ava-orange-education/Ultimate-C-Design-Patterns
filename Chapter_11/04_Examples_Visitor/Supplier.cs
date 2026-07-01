using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._04_Examples_Visitor
{
    public class Supplier : IEntity
    {
        public string Company;
        public int DeliveryScore;

        public void Accept(IReportVisitor visitor) => visitor.VisitSupplier(this);
    }
}
