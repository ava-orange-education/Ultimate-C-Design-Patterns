using Chapter_1._2_Benefits.PaymentGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._5_Real_World_Examples.PaymentGatewayFactory
{
    public class PaymentGatewayFactory
    {
        public static IPaymentGateway CreateGateway(string type)
        {
            switch (type)
            {
                case "Stripe":
                    return new StripeGateway();
                case "PayPal":
                    return new PayPalGateway();
                default:
                    throw new ArgumentException("Invalid gateway type");
            }
        }
    }
}
