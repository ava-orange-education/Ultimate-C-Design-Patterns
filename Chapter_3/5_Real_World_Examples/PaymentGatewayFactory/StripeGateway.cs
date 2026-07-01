using Chapter_1._2_Benefits.PaymentGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._5_Real_World_Examples.PaymentGatewayFactory
{
    public class StripeGateway : IPaymentGateway
    {
        public void ProcessPayment()
        {
            throw new NotImplementedException();
        }
    }
}
