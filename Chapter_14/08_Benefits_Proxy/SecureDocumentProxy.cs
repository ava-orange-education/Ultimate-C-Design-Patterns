using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter_14._08_Benefits_Proxy
{
    class SecureDocumentProxy : IDocument
    {
        private RealDocument document;
        private string userRole;

        public SecureDocumentProxy(string userRole)
        {
            this.userRole = userRole;
        }

        public void Open()
        {
            if (userRole != "Admin")
            {
                Console.WriteLine("Access denied: insufficient permissions.");
                return;
            }

            if (document == null)
                document = new RealDocument();

            document.Open();
        }
    }
}
