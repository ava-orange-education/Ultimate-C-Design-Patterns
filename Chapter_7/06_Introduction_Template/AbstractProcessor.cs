using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._06_Introduction_Template
{
    abstract class AbstractProcessor
    {
        public void ExecuteProcess()
        {
            Initialize();
            FetchData();
            OptionallyLog();
            CleanUp();
        }

        private void Initialize()
        {
            Console.WriteLine("Initialization complete.");
        }

        protected abstract void FetchData();

        protected virtual void OptionallyLog()
        {
            // Default: do nothing
        }

        private void CleanUp()
        {
            Console.WriteLine("Cleanup complete.");
        }
    }
}
