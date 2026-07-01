using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._10_Best_Practices_Builder_Pattern
{
    public class UserProfile
    {
        public string Username { get; }
        public string Email { get; }
        public int Age { get; }

        public UserProfile(string username, string email, int age)
        {
            Username = username;
            Email = email;
            Age = age;
        }
    }
}
