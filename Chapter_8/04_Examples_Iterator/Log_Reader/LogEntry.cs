using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._04_Examples_Iterator.Log_Reader
{
    class LogEntry
    {
        public DateTime Timestamp { get; }
        public string Level { get; }
        public string Message { get; }

        public LogEntry(DateTime timestamp, string level, string message)
        {
            Timestamp = timestamp;
            Level = level;
            Message = message;
        }
    }
}
