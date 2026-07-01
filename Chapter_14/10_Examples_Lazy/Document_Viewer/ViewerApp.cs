using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._10_Examples_Lazy.Document_Viewer
{
    class ViewerApp
    {
        public void Run()
        {
            IDocument doc = new DocumentProxy("report.pdf");
            Console.WriteLine("Viewer loaded. Document not yet initialized.");
            doc.Open(); // Loads and opens the document
        }
    }
}
