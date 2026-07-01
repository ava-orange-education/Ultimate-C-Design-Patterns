using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_03_Emerging_Paradigm
{
    public class QueuedState : IQuantumState
    {
        public void Handle(QuantumJob job)
        {
            Console.WriteLine("Job is queued. Submitting to quantum processor...");
            job.SetState(new RunningState());
        }
    }
}
