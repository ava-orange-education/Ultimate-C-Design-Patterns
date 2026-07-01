using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._03_Implementation_Strategy
{
    // Command interface
    public interface IAction
    {
        void Execute();
        void Undo();
    }
}
