using Chapter_16._02_Common_Antipatterns;
using Chapter_16._03_Practical_examples_Antipatterns.Web_Example;

namespace Chapter_16
{
    internal class UserRepository : IUserRepository
    {
        public void Save(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}