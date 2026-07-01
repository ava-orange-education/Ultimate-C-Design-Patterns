using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple.AuthManager
{
    public class AuthManager1
    {
        private readonly ILogger _logger;

        public AuthManager1(ILogger logger)
        {
            _logger = logger;
        }

        public bool Authenticate(string username, string password)
        {
            if (username == "admin" && password == "password123")
            {
                return true;
            }
            else
            {
                _logger.LogError("Authentication failed!");
                return false;
            }
        }
    }

}
