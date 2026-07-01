using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._03_Unit_Testing
{
    public class PremiumPricing : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice) => basePrice * 1.2m;
    }
}
