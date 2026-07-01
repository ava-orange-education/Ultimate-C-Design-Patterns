using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._04_Practical_Examples.ServerConfig
{
    class DeploymentSystem
    {
        static void Main()
        {
            ServerConfig baseConfig = new ServerConfig("Production", 500);
            ServerConfig newServerConfig = (ServerConfig)baseConfig.Clone();
            newServerConfig.MaxConnections = 1000;  // Adjusting for higher load

            Console.WriteLine($"Base Config: Environment = {baseConfig.Environment}, MaxConnections = {baseConfig.MaxConnections}");
            Console.WriteLine($"New Server Config: Environment = {newServerConfig.Environment}, MaxConnections = {newServerConfig.MaxConnections}");
        }
    }
}
