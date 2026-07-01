using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_01_Pattern_Evolution
{
    public class LoggingPaymentDecorator : IPaymentStrategy
    {
        private readonly IPaymentStrategy _inner;

        public LoggingPaymentDecorator(IPaymentStrategy inner)
        {
            _inner = inner;
        }

        public async Task<bool> ProcessAsync(decimal amount)
        {
            Console.WriteLine($"Starting payment of {amount}");
            var result = await _inner.ProcessAsync(amount);
            Console.WriteLine($"Payment result: {result}");
            return result;
        }
    }
}
