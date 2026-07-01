using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._03_Implementation_Adapter
{
    // The target interface
    public class INotifier
    {
        public virtual void Send(string message)
        {
            // Default behavior (optional)
        }
    }
}
