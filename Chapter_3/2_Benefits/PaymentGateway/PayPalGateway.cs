using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._2_Benefits.PaymentGateway
{
    public class PayPalGateway : IPaymentGateway
    {
        public void ProcessPayment() => Console.WriteLine("Processing payment via PayPal...");
    }
}
