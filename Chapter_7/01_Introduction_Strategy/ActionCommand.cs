using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._01_Introduction_Strategy
{
    // Abstract command
    abstract class ActionCommand
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
