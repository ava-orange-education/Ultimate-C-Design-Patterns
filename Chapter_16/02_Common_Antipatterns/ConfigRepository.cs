using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._02_Common_Antipatterns
{
    public class ConfigRepository : IConfigRepository
    {
        public ConfigurationManager ConfigurationManager { get; private set; }

        public string GetSetting(string key)
        {
            // Reads from appsettings.json
            return ConfigurationManager.AppSettings[key];
        }
    }
}
