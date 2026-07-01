using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._09_Examples_Game
{
    interface IKaiState
    {
        void Handle(KaiContext context);
    }
}
