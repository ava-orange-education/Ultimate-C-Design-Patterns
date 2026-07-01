using System;
using System.Collections.Generic;

namespace Chapter_18._01_01_Integrating_Patterns
{
    public class Order
    {
        private Customer customer;
        private List<OrderItem> items;

        public Order(Customer customer, List<OrderItem> items)
        {
            this.customer = customer;
            this.items = items;
        }

        internal void Ship()
        {
            throw new NotImplementedException();
        }
    }
}