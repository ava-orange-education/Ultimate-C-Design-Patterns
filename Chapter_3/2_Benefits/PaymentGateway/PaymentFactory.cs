using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._2_Benefits.PaymentGateway
{
    public class PaymentFactory
    {
        public static IPaymentGateway CreateGateway(string type)
        {
            switch (type)
            {
                case "PayPal":
                    return new PayPalGateway();
                default:
                    throw new ArgumentException("Invalid payment gateway");
            }
        }
    }
}
