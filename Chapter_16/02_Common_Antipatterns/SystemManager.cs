using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._02_Common_Antipatterns
{
    public class SystemManager
    {
        public void AuthenticateUser(string username, string password) { /* ... */ }
        public void SaveToDatabase(object data) { /* ... */ }
        public void GenerateReport() { /* ... */ }
        public void SendEmail(string to, string subject, string body) { /* ... */ }
        public void RenderDashboard() { /* ... */ }
    }
}
