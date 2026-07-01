using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._08_Implementation_Dependency
{
    public interface IMessageSender
    {
        void Send(string message);
    }
}
