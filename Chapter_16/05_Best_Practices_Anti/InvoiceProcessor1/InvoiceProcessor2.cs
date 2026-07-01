using Chapter_16._03_Practical_examples_Antipatterns.Web_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._05_Best_Practices_Anti.InvoiceProcessor1
{
    public class InvoiceProcessor2
    {
        private readonly IEmailSender _emailSender;
        private readonly IInvoiceRepository _repository;
        private readonly ILogger _logger;

        public InvoiceProcessor2(IEmailSender emailSender, IInvoiceRepository repository, ILogger logger)
        {
            _emailSender = emailSender;
            _repository = repository;
            _logger = logger;
        }

        public void Process(Invoice invoice)
        {
            if (invoice.Total > 1000)
                _emailSender.SendAlert(invoice);

            _repository.Save(invoice);
            _logger.LogInfo($"Invoice processed: {invoice.Id}");
        }
    }

}
