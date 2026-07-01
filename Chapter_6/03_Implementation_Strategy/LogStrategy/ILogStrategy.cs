using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._03_Implementation_Strategy.LogStrategy
{
    public interface ILogStrategy
    {
        void Log(string message);
    }
}
