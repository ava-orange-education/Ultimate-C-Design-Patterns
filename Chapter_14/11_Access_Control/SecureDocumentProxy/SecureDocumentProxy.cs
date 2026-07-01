using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._11_Access_Control.SecureDocumentProxy
{
    class SecureDocumentProxy : IDocument
    {
        private ConfidentialReport report;
        private string userRole;

        public SecureDocumentProxy(string userRole)
        {
            this.userRole = userRole;
        }

        public void View()
        {
            if (userRole != "Admin")
            {
                Console.WriteLine("Access denied: You do not have permission to view this document.");
                return;
            }

            if (report == null)
                report = new ConfidentialReport();

            report.View();
        }
    }
}
