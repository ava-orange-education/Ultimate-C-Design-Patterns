using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple.OrderProcessorRefactoring
{
    public class InvoiceGenerator
    {
        public void GenerateInvoice(Order order)
        {
            Console.WriteLine($"Invoice generated for Order: {order.Id}");
        }
    }
}
