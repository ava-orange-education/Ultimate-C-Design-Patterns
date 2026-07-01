using System.Collections.Generic;

namespace Chapter_16._02_Common_Antipatterns
{
    public class ConfigurationManager
    {
        public Dictionary<string, string> AppSettings { get; internal set; }
    }
}