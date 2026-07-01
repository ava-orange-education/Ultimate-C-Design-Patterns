using Chapter_1._4_Use_Cases.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._10_Best_Practices__Abstract_Factory
{
    public class DatabaseFactory
    {
        public IDatabaseConnection CreateConnection() => new SqlDatabaseConnection();
    }
}
