using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._04_Examples_Adapter
{
    public class IPaymentProcessor
    {
        public virtual void Pay(decimal amount)
        {
            // Default implementation
        }
    }
}
