using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._02_Best_Practices
{
    public class CheckoutService
    {
        private readonly IDiscountStrategy _strategy;

        public CheckoutService(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal FinalizeTotal(decimal subtotal)
        {
            return _strategy.ApplyDiscount(subtotal);
        }
    }
}
