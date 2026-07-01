using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosedPrinciple.InvoiceProcessor
{
    public class PercentageDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount)
        {
            return amount - (amount * 0.1m);
        }
    }
}
