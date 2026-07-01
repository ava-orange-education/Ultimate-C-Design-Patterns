using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._12_Best_Practices_Proxy
{
    class RateLimitedServiceProxy : IEmailService
    {
        private readonly IEmailService realService;
        private DateTime lastSent = DateTime.MinValue;

        public RateLimitedServiceProxy(IEmailService realService)
        {
            this.realService = realService;
        }

        public void Send(string recipient, string message)
        {
            if ((DateTime.Now - lastSent).TotalSeconds < 5)
            {
                Console.WriteLine("Rate limit exceeded. Try again later.");
                return;
            }

            realService.Send(recipient, message);
            lastSent = DateTime.Now;
        }
    }
}
