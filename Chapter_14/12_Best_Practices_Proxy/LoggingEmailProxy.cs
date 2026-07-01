using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._12_Best_Practices_Proxy
{
    class LoggingEmailProxy : IEmailService
    {
        private readonly IEmailService realService;

        public LoggingEmailProxy(IEmailService realService)
        {
            this.realService = realService;
        }

        public void Send(string recipient, string message)
        {
            Console.WriteLine($"[LOG] Sending email to {recipient}");
            realService.Send(recipient, message);
        }
    }
}
