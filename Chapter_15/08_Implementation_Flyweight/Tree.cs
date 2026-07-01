using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._08_Implementation_Flyweight
{
    class Tree
    {
        private int x;
        private int y;
        private TreeType type;

        public Tree(int x, int y, TreeType type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }

        public void Draw()
        {
            type.Render(x, y);
        }
    }
}
