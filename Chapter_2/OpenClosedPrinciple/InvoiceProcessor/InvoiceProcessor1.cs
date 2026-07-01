using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosedPrinciple.InvoiceProcessor
{
    public class InvoiceProcessor1
    {
        private readonly IDiscountStrategy _discountStrategy;

        public InvoiceProcessor(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotal(decimal amount)
        {
            return _discountStrategy.ApplyDiscount(amount);
        }
    }
}
