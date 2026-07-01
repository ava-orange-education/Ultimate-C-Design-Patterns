using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._03_Unit_Testing
{
    public class PriceCalculator
    {
        private readonly IPricingStrategy _strategy;

        public PriceCalculator(IPricingStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal GetFinalPrice(decimal basePrice)
        {
            return _strategy.CalculatePrice(basePrice);
        }
    }
}
