using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosedPrinciple.InvoiceProcessor
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal amount);
    }
}
