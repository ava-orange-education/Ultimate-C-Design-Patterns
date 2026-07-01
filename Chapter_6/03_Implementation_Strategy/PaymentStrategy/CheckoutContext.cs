using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._03_Implementation_Strategy.PaymentStrategy
{
    public class CheckoutContext
    {
        private IPaymentStrategy _paymentStrategy;

        public CheckoutContext(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void SetPaymentMethod(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void Checkout(decimal total)
        {
            _paymentStrategy.ProcessPayment(total);
        }
    }
}
