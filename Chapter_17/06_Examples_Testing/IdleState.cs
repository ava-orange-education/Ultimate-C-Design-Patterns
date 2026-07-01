using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._06_Examples_Testing
{
    public class IdleState : ICharacterState
    {
        public string Act() => "Standing still";
    }
}
