using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._09_Examples_Memento.Undo
{
    public class TextEditor
    {
        public string Content { get; private set; }

        public void Type(string text)
        {
            Content += text;
            Console.WriteLine($"Typed: {text}");
        }

        public TextSnapshot Save()
        {
            return new TextSnapshot(Content);
        }

        public void Restore(TextSnapshot snapshot)
        {
            Content = snapshot.SavedContent;
            Console.WriteLine($"Restored content to: {Content}");
        }
    }
}
