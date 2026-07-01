using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._11_Access_Control.Auth_System
{
    class AuthService
    {
        public string GetCurrentUserRole()
        {
            // Simulate fetching role from session or token
            return "Editor"; // Change this to "Admin" to test access
        }
    }
}
