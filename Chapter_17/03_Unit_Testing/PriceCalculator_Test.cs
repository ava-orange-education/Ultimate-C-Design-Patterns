using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._03_Unit_Testing
{
    internal class PriceCalculator_Test
    {
        [Fact]
        public void Strategy_ShouldCalculatePremiumPrice()
        {
            var strategy = new PremiumPricing();
            var calculator = new PriceCalculator(strategy);

            var result = calculator.GetFinalPrice(100);

            Assert.Equal(120, result);
        }
    }
}
