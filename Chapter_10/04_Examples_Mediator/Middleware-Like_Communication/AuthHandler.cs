using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Middleware_Like_Communication
{
    public class AuthHandler : IRequestHandler
    {
        public void Handle(Request request)
        {
            Console.WriteLine($"Authenticating: {request.Content}");
        }
    }
}
