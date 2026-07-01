using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversionPrinciple.UserService
{
    public class UserService1
    {
        private readonly IDatabase _database;

        public UserService(IDatabase database) // Dependency injected via constructor
        {
            _database = database;
        }

        public void SaveUser(User user)
        {
            _database.Save(user); // Works with any database implementation
        }
    }
}
