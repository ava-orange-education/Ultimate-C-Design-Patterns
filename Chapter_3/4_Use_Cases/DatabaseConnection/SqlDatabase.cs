using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._4_Use_Cases.DatabaseConnection
{
    public class SqlDatabase : IDatabaseConnection
    {
        public void Connect() => Console.WriteLine("Connected to SQL Database");
    }
}
