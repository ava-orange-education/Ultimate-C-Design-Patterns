using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._01_Introduction_Visitor
{
    class ContentCollection
    {
        private readonly List<ContentElement> elements = new List<ContentElement>();

        public void Add(ContentElement element) => elements.Add(element);
        public void Remove(ContentElement element) => elements.Remove(element);

        public void Accept(ContentVisitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
