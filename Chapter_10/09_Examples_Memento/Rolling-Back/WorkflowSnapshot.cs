using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._09_Examples_Memento.Rolling_Back
{
    public class WorkflowSnapshot
    {
        public WorkflowState State { get; }

        public WorkflowSnapshot(WorkflowState state)
        {
            // Deep copy for safety
            State = new WorkflowState
            {
                Email = state.Email,
                DatabaseUpdated = state.DatabaseUpdated,
                WelcomeEmailSent = state.WelcomeEmailSent
            };
        }
    }
}
