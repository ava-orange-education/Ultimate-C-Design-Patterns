using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversionPrinciple.UserService
{
    public class SqlDatabase1 : IDatabase
    {
        public void Save(User user)
        {
            Console.WriteLine("Saving user to SQL database...");
        }
    }
}
