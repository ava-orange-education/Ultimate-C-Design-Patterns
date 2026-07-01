using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._10_Data_caching
{
    class ConfigProfile
    {
        public string Environment { get; }
        public string ApiEndpoint { get; }
        public string LogLevel { get; }

        public ConfigProfile(string environment, string apiEndpoint, string logLevel)
        {
            Environment = environment;
            ApiEndpoint = apiEndpoint;
            LogLevel = logLevel;
        }

        public void Display()
        {
            Console.WriteLine($"[{Environment}] Endpoint: {ApiEndpoint}, LogLevel: {LogLevel}");
        }
    }
}
