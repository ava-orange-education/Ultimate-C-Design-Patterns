using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosedPrinciple.InvoiceProcessor
{
    public class InvoiceProcessor
    {
        public decimal CalculateTotal(decimal amount, string discountType)
        {
            if (discountType == "Percentage")
            {
                return amount - (amount * 0.1m);
            }
            else if (discountType == "FixedAmount")
            {
                return amount - 20m;
            }
            else
            {
                return amount;
            }
        }
    }
}
