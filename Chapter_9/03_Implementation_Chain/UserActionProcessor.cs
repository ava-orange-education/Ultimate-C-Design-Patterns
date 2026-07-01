using Chapter_9._01_Introduction_Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._03_Implementation_Chain
{
    class UserActionProcessor
    {
        public void Execute()
        {
            IRequestHandler authHandler = new AuthenticationHandler();
            IRequestHandler logHandler = new LoggingHandler();
            IRequestHandler policyHandler = new PolicyEnforcementHandler();

            authHandler.SetNext(logHandler);
            logHandler.SetNext(policyHandler);

            authHandler.Handle("DeleteAccount");
        }
    }
}
