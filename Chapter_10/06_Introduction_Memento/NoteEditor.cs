using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._06_Introduction_Memento
{
    public class NoteEditor
    {
        public string Text { get; private set; }

        public void Write(string newText)
        {
            Console.WriteLine($"Writing note: {newText}");
            Text = newText;
        }

        public StateSnapshot Save()
        {
            Console.WriteLine("Saving current note...");
            return new StateSnapshot(Text);
        }

        public void Restore(StateSnapshot snapshot)
        {
            Text = snapshot.Content;
            Console.WriteLine($"Restored note to: {Text}");
        }
    }
}
