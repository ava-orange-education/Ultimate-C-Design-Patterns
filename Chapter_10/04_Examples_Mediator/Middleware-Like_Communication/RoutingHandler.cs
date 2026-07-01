using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Middleware_Like_Communication
{
    public class RoutingHandler : IRequestHandler
    {
        public void Handle(Request request)
        {
            Console.WriteLine($"Routing: {request.Content}");
        }
    }
}
