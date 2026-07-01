using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_02_Serverles
{
    public class DocumentMemento
    {
        public string Content { get; }
        public string Status { get; }

        public DocumentMemento(string content, string status)
        {
            Content = content;
            Status = status;
        }
    }
}
