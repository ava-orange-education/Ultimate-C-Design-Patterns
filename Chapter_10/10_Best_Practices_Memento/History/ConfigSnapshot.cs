using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._10_Best_Practices_Memento.History
{
    public class ConfigSnapshot
    {
        public int Version { get; }
        public Dictionary<string, string> Settings { get; }

        public ConfigSnapshot(int version, Dictionary<string, string> settings)
        {
            Version = version;
            Settings = settings;
        }
    }
}
