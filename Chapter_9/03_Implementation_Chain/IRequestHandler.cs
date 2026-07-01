using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._03_Implementation_Chain
{
    interface IRequestHandler
    {
        IRequestHandler SetNext(IRequestHandler handler);
        void Handle(string action);
    }
}
