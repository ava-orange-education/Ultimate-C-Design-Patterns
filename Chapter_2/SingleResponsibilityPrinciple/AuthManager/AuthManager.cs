using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple.AuthManager
{
    public class AuthManager
    {
        public bool Authenticate(string username, string password)
        {
            // Authentication logic
            if (username == "admin" && password == "password123")
            {
                return true;
            }
            else
            {
                // Logging responsibility mixed in
                Console.WriteLine("Authentication failed!");
                return false;
            }
        }
    }
}
