using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._06_Introduction_Memento
{
    public class VersionManager
    {
        private StateSnapshot snapshot;

        public void SaveSnapshot(StateSnapshot s)
        {
            snapshot = s;
        }

        public StateSnapshot RetrieveSnapshot()
        {
            return snapshot;
        }
    }
}
