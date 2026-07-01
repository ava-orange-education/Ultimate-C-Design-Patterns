using Chapter_16._03_Practical_examples_Antipatterns;
using Chapter_16._03_Practical_examples_Antipatterns.Web_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._05_Best_Practices_Anti
{
    public class InvoiceProcessor
    {
        private Logger _logger;
        public InvoiceProcessor() { _logger = new Logger()}
        public void Process(Invoice invoice)
        {
            if (invoice.Total > 1000)
                EmailService.SendAlert(invoice);

            Database.Save(invoice);
            _logger.Log($"Invoice processed: {invoice.Id}");
        }
    }
}
