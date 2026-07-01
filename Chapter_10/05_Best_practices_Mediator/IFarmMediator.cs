using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._05_Best_practices_Mediator
{
    public interface IFarmMediator
    {
        void TriggerEvent(object sender, string eventName);
    }
}
