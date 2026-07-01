using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._4_Use_Cases.Repository
{
    public class NoSqlRepository : IRepository
    {
        public void FetchData() => Console.WriteLine("Fetched data from NoSQL database.");
    }
}
