using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._10_Data_caching
{
    class ConfigFactory
    {
        private Dictionary<string, ConfigProfile> profiles = new Dictionary<string, ConfigProfile>();

        public ConfigProfile GetProfile(string environment)
        {
            if (!profiles.ContainsKey(environment))
            {
                // Simulate loading from a database or config file
                string endpoint = $"https://api.{environment}.example.com";
                string logLevel = environment == "Production" ? "Error" : "Debug";
                profiles[environment] = new ConfigProfile(environment, endpoint, logLevel);
                Console.WriteLine($"Created new profile for {environment}");
            }
            return profiles[environment];
        }
    }
}
