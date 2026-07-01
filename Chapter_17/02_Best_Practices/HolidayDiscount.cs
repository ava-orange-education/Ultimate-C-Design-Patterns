using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._02_Best_Practices
{
    public class HolidayDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total) => total * 0.9m;
    }
}
