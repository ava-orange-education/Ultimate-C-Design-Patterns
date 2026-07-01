using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._01_Introduction_Visitor
{
    abstract class ContentVisitor
    {
        public abstract void VisitArticle(Article article);
        public abstract void VisitPodcast(Podcast podcast);
    }
}
