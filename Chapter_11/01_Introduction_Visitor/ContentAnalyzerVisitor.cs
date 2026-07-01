using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._01_Introduction_Visitor
{
    class ContentAnalyzerVisitor : ContentVisitor
    {
        public override void VisitArticle(Article article)
        {
            article.Analyze();
        }

        public override void VisitPodcast(Podcast podcast)
        {
            podcast.Analyze();
        }
    }
}
