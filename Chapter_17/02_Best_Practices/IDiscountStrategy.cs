using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._02_Best_Practices
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal total);
    }
}
