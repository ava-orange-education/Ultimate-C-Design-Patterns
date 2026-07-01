using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_01_Integrating_Patterns
{
    public class LegacyPaymentAdapter : IPaymentProcessor
    {
        private readonly LegacyPaymentService _legacyService;

        public LegacyPaymentAdapter(LegacyPaymentService legacyService)
        {
            _legacyService = legacyService;
        }

        public bool ProcessPayment(decimal amount)
        {
            var result = _legacyService.MakePayment(amount.ToString("F2"));
            return result == "OK";
        }
    }
}
