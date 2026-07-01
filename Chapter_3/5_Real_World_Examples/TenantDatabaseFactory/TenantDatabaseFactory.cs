using Chapter_1._4_Use_Cases.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._5_Real_World_Examples.TenantDatabaseFactory
{
    public class TenantDatabaseFactory
    {
        public static IDatabaseConnection CreateDatabase(string tenantId)
        {
            string type = FetchDatabaseTypeFromTenantConfig(tenantId);

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

        private static string FetchDatabaseTypeFromTenantConfig(string tenantId)
        {
            throw new NotImplementedException();
        }
    }
}
