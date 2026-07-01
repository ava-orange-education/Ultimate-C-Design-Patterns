using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._04_Real_World_Examples
{
    public sealed class DatabaseConnectionPool
    {
        private static readonly DatabaseConnectionPool _instance = new DatabaseConnectionPool();
        private readonly List<string> _availableConnections = new List<string>();

        private DatabaseConnectionPool()
        {
            _availableConnections.Add("Connection1");
            _availableConnections.Add("Connection2");
        }

        public static DatabaseConnectionPool Instance => _instance;

        public string GetConnection()
        {
            return _availableConnections.Count > 0 ? _availableConnections[0] : "No available connections.";
        }
    }
}
