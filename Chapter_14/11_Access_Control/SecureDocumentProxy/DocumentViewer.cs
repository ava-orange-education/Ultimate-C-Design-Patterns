using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._11_Access_Control.SecureDocumentProxy
{
    class DocumentViewer
    {
        public void Run()
        {
            IDocument docForGuest = new SecureDocumentProxy("Guest");
            docForGuest.View(); // Access denied

            IDocument docForAdmin = new SecureDocumentProxy("Admin");
            docForAdmin.View(); // Displays content
        }
    }
}
