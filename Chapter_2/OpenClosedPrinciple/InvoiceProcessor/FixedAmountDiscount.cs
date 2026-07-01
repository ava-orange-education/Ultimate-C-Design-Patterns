using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosedPrinciple.InvoiceProcessor
{
    public class FixedAmountDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount)
        {
            return amount - 20m;
        }
    }
}
