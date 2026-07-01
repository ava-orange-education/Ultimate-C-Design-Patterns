using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._03_Implementation_Strategy.PaymentStrategy
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}
