using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._4_Use_Cases.Repository
{
    public class RepositoryFactory
    {
        public static IRepository CreateRepository(string type)
        {
            switch (type)
            {
                case "SQL":
                    return new SqlRepository();
                case "NoSQL":
                    return new NoSqlRepository();
                default:
                    throw new ArgumentException("Unknown repository type");
            }
        }
    }
}
