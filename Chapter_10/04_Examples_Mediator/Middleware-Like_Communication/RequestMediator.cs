using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Middleware_Like_Communication
{
    public class RequestMediator
    {
        private readonly List<IRequestHandler> handlers = new List<IRequestHandler>();

        public void RegisterHandler(IRequestHandler handler)
        {
            handlers.Add(handler);
        }

        public void Process(Request request)
        {
            foreach (var handler in handlers)
            {
                handler.Handle(request);
            }
        }
    }
}
