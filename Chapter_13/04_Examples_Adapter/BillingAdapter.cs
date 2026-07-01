using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._04_Examples_Adapter
{
    public class BillingAdapter : IPaymentProcessor
    {
        private LegacyBillingProcessor legacyProcessor = new LegacyBillingProcessor();

        public override void Pay(decimal amount)
        {
            legacyProcessor.ProcessInvoice(amount);
        }
    }
}
