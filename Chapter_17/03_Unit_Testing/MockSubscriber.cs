using Chapter_17._01_Introduction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._03_Unit_Testing
{
    public class MockSubscriber : ISubscriber
    {
        public bool WasUpdated { get; private set; }

        public void Update(string message)
        {
            WasUpdated = true;
        }
    }
}
