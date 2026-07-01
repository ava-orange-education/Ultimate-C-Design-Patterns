using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_01_Pattern_Evolution
{
    public class CreditCardStrategy : IPaymentStrategy
    {
        public async Task<bool> ProcessAsync(decimal amount)
        {
            Console.WriteLine("Processing credit card...");
            return true;
        }
    }
}
