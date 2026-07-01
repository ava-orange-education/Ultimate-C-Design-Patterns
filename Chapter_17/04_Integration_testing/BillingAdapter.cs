using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter_17._04_Integration_testing
{
    public class BillingAdapter : IInvoiceProvider
    {
        private readonly LegacyBillingService _legacy;

        public BillingAdapter(LegacyBillingService legacy)
        {
            _legacy = legacy;
        }

        public Invoice GetInvoice()
        {
            var xml = _legacy.GetInvoiceXml();
            var doc = XDocument.Parse(xml);
            var amount = decimal.Parse(doc.Root.Element("amount").Value);
            return new Invoice { Amount = amount };
        }
    }
}
