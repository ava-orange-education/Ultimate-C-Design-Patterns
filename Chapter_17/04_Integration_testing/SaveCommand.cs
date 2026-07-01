using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._04_Integration_testing
{
    public class SaveCommand : ICommand
    {
        public bool WasExecuted { get; private set; }

        public void Execute()
        {
            WasExecuted = true;
        }
    }
}
