using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._2_Benefits.DatabaseConnection
{
    public class SqlDatabase : DatabaseConnection
    {
        public override void Connect() => Console.WriteLine("Connected to SQL Database");
    }
}
