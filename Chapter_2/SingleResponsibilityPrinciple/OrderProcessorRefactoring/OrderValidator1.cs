using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple.OrderProcessorRefactoring
{
    public class OrderValidator1
    {
        public bool Validate(Order order)
        {
            return order.TotalAmount > 0;
        }
    }
}
