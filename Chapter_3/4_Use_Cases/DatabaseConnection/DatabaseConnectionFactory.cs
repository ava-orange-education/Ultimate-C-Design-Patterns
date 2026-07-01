using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._4_Use_Cases.DatabaseConnection
{
    public class DatabaseConnectionFactory
    {
        public static IDatabaseConnection CreateDatabase(string type)
        {
            switch (type)
            {
                case "SQL":
                    return new SqlDatabase();
                case "NoSQL":
                    return new NoSqlDatabase();
                default:
                    throw new ArgumentException("Unsupported database type");
            }
        }
    }
}
