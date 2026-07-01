using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._03_Implementation_Adapter
{
    public class NotificationClient
    {
        public void Notify(INotifier notifier)
        {
            notifier.Send("Adapter pattern implemented successfully!");
        }
    }
}
