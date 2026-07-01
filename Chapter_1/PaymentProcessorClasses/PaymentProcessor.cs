using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.PaymentProcessorClasses
{
    // Service class using composition (dependency injection)
    public class PaymentProcessor
    {
        private readonly ILogger _logger;

        public PaymentProcessor(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessPayment()
        {
            _logger.Log("Processing payment...");
            Console.WriteLine("Payment processed successfully.");
        }
    }
}
