using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._03_Unit_Testing
{
    public sealed class ConfigurationManager
    {
        private static readonly Lazy<ConfigurationManager> _instance =
            new Lazy<ConfigurationManager>(() => new ConfigurationManager());

        public static ConfigurationManager Instance => _instance.Value;

        public string Environment { get; set; } = "Production";
    }
}
