using Chapter_10._01_Introduction_Madiator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Orchestrated_System_Interaction
{
    public interface IDeviceMediator
    {
        void Notify(Device sender, string action);
    }
}
