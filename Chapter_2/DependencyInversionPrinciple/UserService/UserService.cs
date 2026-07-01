using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversionPrinciple.UserService
{
    public class UserService
    {
        private readonly SqlDatabase _database; // Direct dependency on concrete class

        public UserService()
        {
            _database = new SqlDatabase(); // Hardcoded dependency
        }

        public void SaveUser(User user)
        {
            _database.Save(user); // Directly calling low-level class
        }
    }
}
