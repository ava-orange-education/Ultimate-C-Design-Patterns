using Chapter_1._5_Real_World_Examples.UserServiceFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._10_Best_Practices__Abstract_Factory
{
    public class SingletonServiceFactory
    {
        public static IUserService CreateService() => new UserService();
    }
}
