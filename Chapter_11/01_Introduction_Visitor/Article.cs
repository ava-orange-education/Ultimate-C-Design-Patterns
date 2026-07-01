using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._01_Introduction_Visitor
{
    class Article : ContentElement
    {
        public override void Accept(ContentVisitor visitor)
        {
            visitor.VisitArticle(this);
        }

        public void Analyze() { /* logic here */ }
        public void Export() { /* logic here */ }
    }
}
