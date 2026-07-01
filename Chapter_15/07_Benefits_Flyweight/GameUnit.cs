using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._07_Benefits_Flyweight
{
    class GameUnit
    {
        private string position;
        private UnitType type;

        public GameUnit(string position, UnitType type)
        {
            this.position = position;
            this.type = type;
        }

        public void Draw()
        {
            type.Render(position);
        }
    }
}
