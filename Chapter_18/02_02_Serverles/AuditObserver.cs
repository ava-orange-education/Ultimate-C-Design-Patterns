using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_02_Serverles
{
    public class AuditObserver : IProcessingObserver
    {
        public async Task NotifyAsync(string imageId)
        {
            Console.WriteLine($"Audit log created for {imageId}");
        }
    }
}
