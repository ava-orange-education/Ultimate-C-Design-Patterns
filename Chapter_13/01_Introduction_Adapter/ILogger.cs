using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._01_Introduction_Adapter
{
    // Target interface
    class ILogger
    {
        public virtual void Log(string message)
        {
            // Default implementation (optional)
        }
    }
}
