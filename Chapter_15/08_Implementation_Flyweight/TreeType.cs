using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._08_Implementation_Flyweight
{
    class TreeType : ITreeType
    {
        private string texture;
        private string mesh;

        public TreeType(string texture, string mesh)
        {
            this.texture = texture;
            this.mesh = mesh;
        }

        public void Render(int x, int y)
        {
            Console.WriteLine($"Rendering tree at ({x},{y}) with texture '{texture}' and mesh '{mesh}'");
        }
    }
}
