using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._10_Best_Practices_Memento.Size
{
    public class DiagramEditor
    {
        public List<Shape> Shapes { get; private set; } = new List<Shape>();
        public string SelectedTool { get; private set; }

        public EditorSnapshot SaveState()
        {
            // Capture just the essentials
            var shapeCopies = Shapes.Select(s => new Shape(s.Type, s.Position)).ToList();
            return new EditorSnapshot(shapeCopies, SelectedTool);
        }

        public void RestoreState(EditorSnapshot snapshot)
        {
            Shapes = snapshot.Shapes.Select(s => new Shape(s.Type, s.Position)).ToList();
            SelectedTool = snapshot.Tool;
        }
    }
}
