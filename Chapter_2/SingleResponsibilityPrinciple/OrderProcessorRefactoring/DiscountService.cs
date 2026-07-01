using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple.OrderProcessorRefactoring
{
    public class DiscountService
    {
        public void ApplyDiscount(Order order, double discountRate)
        {
            order.TotalAmount -= order.TotalAmount * discountRate;
        }
    }
}
