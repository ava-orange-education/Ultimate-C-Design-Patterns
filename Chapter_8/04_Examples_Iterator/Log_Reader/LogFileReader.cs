using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._04_Examples_Iterator.Log_Reader
{
    class LogFileReader
    {
        private readonly List<LogEntry> _logEntries;

        public LogFileReader()
        {
            _logEntries = GenerateFakeLogs();
        }

        public IEnumerable<LogEntry> FilterByLevel(string level)
        {
            foreach (var entry in _logEntries)
            {
                if (entry.Level.Equals(level, StringComparison.OrdinalIgnoreCase))
                {
                    yield return entry;
                }
            }
        }

        private List<LogEntry> GenerateFakeLogs()
        {
            return new List<LogEntry>
        {
            new LogEntry(DateTime.Now, "Info", "System started"),
            new LogEntry(DateTime.Now, "Debug", "Initialization step 1 complete"),
            new LogEntry(DateTime.Now, "Warning", "Low disk space"),
            new LogEntry(DateTime.Now, "Error", "Connection timeout"),
            new LogEntry(DateTime.Now, "Info", "Health check passed")
        };
        }
    }
}
