using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_14._10_Examples_Lazy.Document_Viewer
{
    class PdfDocument : IDocument
    {
        private string path;

        public PdfDocument(string path)
        {
            this.path = path;
            LoadDocument();
        }

        private void LoadDocument()
        {
            Console.WriteLine($"Loading PDF from: {path}");
            Thread.Sleep(1500); // Simulate heavy load
        }

        public void Open()
        {
            Console.WriteLine($"Opening PDF: {path}");
        }
    }
}
