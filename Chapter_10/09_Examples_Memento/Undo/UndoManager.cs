using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._09_Examples_Memento.Undo
{
    public class UndoManager
    {
        private readonly Stack<TextSnapshot> history = new();

        public void Save(TextSnapshot snapshot) => history.Push(snapshot);

        public TextSnapshot Undo() => history.Count > 0 ? history.Pop() : null;
    }
}
