using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to topic 1 - introduction
            var contentLibrary = new ContentCollection();
            contentLibrary.Add(new Article());
            contentLibrary.Add(new Podcast());

            contentLibrary.Accept(new ContentAnalyzerVisitor());
            contentLibrary.Accept(new ContentExporterVisitor());

        }
    }
}
