using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._11_Access_Control.SecureDocumentProxy
{
    class ConfidentialReport : IDocument
    {
        private string content;

        public ConfidentialReport()
        {
            content = "Top Secret: The cake is not a lie.";
        }

        public void View()
        {
            Console.WriteLine($"Document Content: {content}");
        }
    }
}
