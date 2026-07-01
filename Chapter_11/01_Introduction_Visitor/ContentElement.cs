using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._01_Introduction_Visitor
{
    abstract class ContentElement
    {
        public abstract void Accept(ContentVisitor visitor);
        public string Metadata { get; set; }
    }
}
