using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._04_Integration_testing
{
    public interface IInvoiceProvider
    {
        Invoice GetInvoice();
    }
}
