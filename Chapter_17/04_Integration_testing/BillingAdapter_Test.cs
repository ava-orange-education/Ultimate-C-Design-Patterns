using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._04_Integration_testing
{
    internal class BillingAdapter_Test
    {
        [Fact]
        public void Adapter_ShouldConvertXmlToInvoice()
        {
            var legacy = new LegacyBillingService();
            var adapter = new BillingAdapter(legacy);

            var invoice = adapter.GetInvoice();

            Assert.Equal(100, invoice.Amount);
        }
    }
}
