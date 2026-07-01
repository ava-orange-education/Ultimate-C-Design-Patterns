using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._04_Examples_Visitor
{
    public class AnnualReportVisitor : IReportVisitor
    {
        public void VisitCustomer(Customer customer)
        {
            Console.WriteLine($"Customer {customer.Name}: Total purchases ${customer.PurchaseTotal}");
        }

        public void VisitSupplier(Supplier supplier)
        {
            Console.WriteLine($"Supplier {supplier.Company}: Delivery score {supplier.DeliveryScore}");
        }
    }
}
