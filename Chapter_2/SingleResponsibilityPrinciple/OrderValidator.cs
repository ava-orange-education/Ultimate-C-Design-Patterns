using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    public class OrderValidator
    {
        public bool Validate(Order order)
        {
            return !string.IsNullOrEmpty(order.CustomerName);
        }
    }
}
