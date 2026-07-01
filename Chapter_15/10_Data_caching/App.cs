using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._10_Data_caching
{
    class App
    {
        static void Main()
        {
            ConfigFactory factory = new ConfigFactory();

            var devProfile = factory.GetProfile("Development");
            devProfile.Display();

            var prodProfile = factory.GetProfile("Production");
            prodProfile.Display();

            var devAgain = factory.GetProfile("Development");
            devAgain.Display();
        }
    }
}
