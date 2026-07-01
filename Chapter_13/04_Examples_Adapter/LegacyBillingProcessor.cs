using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._04_Examples_Adapter
{
    public class LegacyBillingProcessor
    {
        public void ProcessInvoice(decimal amount)
        {
            Console.WriteLine($"Processing invoice for amount: {amount} via legacy system.");
        }
    }
}
