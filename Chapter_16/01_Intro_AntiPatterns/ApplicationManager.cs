using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._01_Intro_AntiPatterns
{
    public class ApplicationManager
    {
        public void HandleUserLogin(string username, string password) { /* ... */ }
        public void SaveToDatabase(object data) { /* ... */ }
        public void GenerateReport() { /* ... */ }
        public void SendEmail(string to, string subject, string body) { /* ... */ }
        public void LogError(Exception ex) { /* ... */ }
        public void RenderUI() { /* ... */ }
    }
}
