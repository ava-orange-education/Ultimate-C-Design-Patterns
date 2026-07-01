using Chapter_17._01_Introduction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._02_Best_Practices
{
    public class MockSubscriber : ISubscriber
    {
        public bool WasNotified { get; private set; }

        public void Update(string message)
        {
            WasNotified = true;
        }
    }
}
