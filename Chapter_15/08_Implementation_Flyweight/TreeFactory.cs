using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._08_Implementation_Flyweight
{
    class TreeFactory
    {
        private Dictionary<string, TreeType> treeTypes = new();

        public TreeType GetTreeType(string texture, string mesh)
        {
            string key = texture + mesh;
            if (!treeTypes.ContainsKey(key))
            {
                treeTypes[key] = new TreeType(texture, mesh);
                Console.WriteLine($"Created new TreeType: {key}");
            }
            return treeTypes[key];
        }
    }
}
