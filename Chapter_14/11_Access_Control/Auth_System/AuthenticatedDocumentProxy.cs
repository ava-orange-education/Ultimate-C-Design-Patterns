using Chapter_14._11_Access_Control.SecureDocumentProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._11_Access_Control.Auth_System
{
    class AuthenticatedDocumentProxy : IDocument
    {
        private ConfidentialReport report;
        private AuthService authService;

        public AuthenticatedDocumentProxy(AuthService authService)
        {
            this.authService = authService;
        }

        public void View()
        {
            string role = authService.GetCurrentUserRole();

            if (role != "Admin")
            {
                Console.WriteLine($"Access denied for role: {role}");
                return;
            }

            if (report == null)
                report = new ConfidentialReport();

            report.View();
        }
    }
}
