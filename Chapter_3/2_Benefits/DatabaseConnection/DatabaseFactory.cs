using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._2_Benefits.DatabaseConnection
{
    public class DatabaseFactory
    {
        public static DatabaseConnection CreateDatabase(string type)
        {
            switch (type)
            {
                case "SQL":
                    return new SqlDatabase();
                default:
                    throw new ArgumentException("Unknown database type");
            }
        }
    }
}
