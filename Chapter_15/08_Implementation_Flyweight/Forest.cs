using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._08_Implementation_Flyweight
{
    class Forest
    {
        private List<Tree> trees = new List<Tree>();
        private TreeFactory factory = new TreeFactory();

        public void PlantTree(int x, int y, string texture, string mesh)
        {
            TreeType type = factory.GetTreeType(texture, mesh);
            Tree tree = new Tree(x, y, type);
            trees.Add(tree);
        }

        public void Draw()
        {
            foreach (var tree in trees)
            {
                tree.Draw();
            }
        }
    }
}
