using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_01_Integrating_Patterns
{
    public class OrderFactory
    {
        public Order CreateOrder(Customer customer, List<OrderItem> items)
        {
            if (items == null || items.Count == 0)
                throw new InvalidOperationException("Order must contain at least one item.");

            return new Order(customer, items);
        }
    }
}
