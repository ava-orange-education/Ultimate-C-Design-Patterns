using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._10_Best_Practices_Memento.Size
{
    public class EditorSnapshot
    {
        public List<Shape> Shapes { get; }
        public string Tool { get; }

        public EditorSnapshot(List<Shape> shapes, string tool)
        {
            Shapes = shapes;
            Tool = tool;
        }
    }
}
