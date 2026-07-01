using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._09_Examples_Memento.Undo
{
    public class TextSnapshot
    {
        public string SavedContent { get; }

        public TextSnapshot(string content)
        {
            SavedContent = content;
        }
    }
}
