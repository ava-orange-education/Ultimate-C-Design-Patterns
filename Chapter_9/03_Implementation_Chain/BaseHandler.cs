using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._03_Implementation_Chain
{
    abstract class BaseHandler : IRequestHandler
    {
        private IRequestHandler next;

        public IRequestHandler SetNext(IRequestHandler handler)
        {
            next = handler;
            return handler;
        }

        public virtual void Handle(string action)
        {
            if (next != null)
            {
                next.Handle(action);
            }
            else
            {
                Console.WriteLine($"No handler found for action: {action}");
            }
        }
    }
}
