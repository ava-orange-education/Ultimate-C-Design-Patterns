using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._06_Introduction_State
{
    class MachineContext
    {
        public IMode Mode { get; set; }

        public MachineContext(IMode initialMode)
        {
            this.Mode = initialMode;
        }

        public void Request()
        {
            Mode.Handle(this);
        }
    }
}
