using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._01_Introduction_Chain
{
    abstract class RequestHandler
    {
        public RequestHandler Next { get; set; }
        public abstract void Process(string action);
    }
}
