using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._10_Examples_Lazy.Document_Viewer
{
    class DocumentProxy : IDocument
    {
        private string path;
        private PdfDocument realDocument;

        public DocumentProxy(string path)
        {
            this.path = path;
        }

        public void Open()
        {
            if (realDocument == null)
            {
                Console.WriteLine("Initializing document...");
                realDocument = new PdfDocument(path);
            }
            realDocument.Open();
        }
    }
}
