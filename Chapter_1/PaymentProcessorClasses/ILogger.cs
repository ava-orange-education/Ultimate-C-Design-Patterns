using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.PaymentProcessorClasses
{
    // Interface defining logging behavior
    public interface ILogger
    {
        void Log(string message);
    }
}
