using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Chapter_18._02_01_Cloud_Native
{
    public abstract class RequestHandler
    {
        protected RequestHandler Next;

        public void SetNext(RequestHandler next) => Next = next;

        public abstract Task HandleAsync(HttpRequest request);
    }
}
