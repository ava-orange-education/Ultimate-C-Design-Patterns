using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_02_Serverles
{
    public class Document
    {
        public string Content { get; set; }
        public string Status { get; set; }

        public DocumentMemento SaveState() => new DocumentMemento(Content, Status);

        public void RestoreState(DocumentMemento memento)
        {
            Content = memento.Content;
            Status = memento.Status;
        }
    }
}
