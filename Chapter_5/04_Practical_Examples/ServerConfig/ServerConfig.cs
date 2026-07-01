using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._04_Practical_Examples.ServerConfig
{
    class ServerConfig : ICloneable
    {
        public string Environment { get; set; }
        public int MaxConnections { get; set; }

        public ServerConfig(string environment, int maxConnections)
        {
            Environment = environment;
            MaxConnections = maxConnections;
        }

        public object Clone()
        {
            return new ServerConfig(this.Environment, this.MaxConnections);
        }
    }
}
