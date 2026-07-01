using Chapter_1._4_Use_Cases.DatabaseConnection;
using Chapter_1._6_Introduction_Abstract_Factory.UI_Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._10_Best_Practices__Abstract_Factory
{
    public class MixedFactory
    {
        public IButton CreateButton() => new DarkButton();
        public IDatabaseConnection CreateDatabaseConnection() => new SqlDatabaseConnection(); // ❌ UI and database mixed!
    }
}
