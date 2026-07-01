using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._02_Common_Antipatterns
{
    internal class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            if (order != null)
            {
                if (order.Items.Count > 0)
                {
                    foreach (var item in order.Items)
                    {
                        if (item.IsAvailable)
                        {
                            if (item.Price > 0)
                            {
                                // Deeply nested logic continues...
                            }
                        }
                    }
                }
            }
        }
    }
}
