using SolidPrinciples.DependencyInversionPrinciple.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._5_Real_World_Examples.UserServiceFactory
{
    public class UserServiceFactory
    {
        public static IUserService CreateService() => new UserService();
    }
}
