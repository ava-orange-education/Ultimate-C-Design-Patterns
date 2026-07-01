using Chapter_16._02_Common_Antipatterns;
using Chapter_16._03_Practical_examples_Antipatterns.Web_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._09_Examples_ASP_NET_Core
{
    public class FakeUserRepository : IUserRepository
    {
        public User GetById(int id)
        {
            return new User { Id = id, Name = "Test User" };
        }

        public void Save(User user)
        {
            throw new NotImplementedException();
        }
    }
}
