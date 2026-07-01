using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._06_Introduction_Memento
{
    public class StateSnapshot
    {
        public string Content { get; }

        public StateSnapshot(string content)
        {
            Content = content;
        }
    }
}
