using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._05_Best_practices_Mediator
{
    public class InventoryMonitor
    {
        private readonly IWorkflowMediator mediator;

        private InventoryMonitor(IWorkflowMediator mediator)
        {
            this.mediator = mediator;
        }

        public void CheckStock()
        {
            mediator.TriggerEvent(this, "StockLow");
        }
    }
}
