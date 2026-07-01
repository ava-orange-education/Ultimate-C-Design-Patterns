using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._04_Real_World_Examples
{
    public sealed class ConfigurationManager
    {
        private static readonly ConfigurationManager _instance = new ConfigurationManager();
        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>();

        private ConfigurationManager()
        {
            _settings.Add("DatabaseConnection", "Server=127.0.0.1;User=admin;");
            _settings.Add("APIKey", "12345-abcde-67890");
        }

        public static ConfigurationManager Instance => _instance;

        public string GetSetting(string key)
        {
            return _settings.ContainsKey(key) ? _settings[key] : "Setting not found";
        }
    }
}
