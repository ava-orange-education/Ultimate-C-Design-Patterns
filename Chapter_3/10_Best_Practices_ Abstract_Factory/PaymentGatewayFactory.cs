using Chapter_1._2_Benefits.PaymentGateway;
using Chapter_1._5_Real_World_Examples.PaymentGatewayFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._10_Best_Practices__Abstract_Factory
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
