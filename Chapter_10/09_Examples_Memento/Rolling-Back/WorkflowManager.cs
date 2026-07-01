using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._09_Examples_Memento.Rolling_Back
{
    public class WorkflowManager
    {
        private Stack<WorkflowSnapshot> snapshots = new Stack<WorkflowSnapshot>();
        private WorkflowState currentState = new WorkflowState();

        public void Save()
        {
            snapshots.Push(new WorkflowSnapshot(currentState));
            Console.WriteLine("Workflow snapshot saved.");
        }

        public void Restore()
        {
            if (snapshots.Count > 0)
            {
                currentState = snapshots.Pop().State;
                Console.WriteLine("Workflow rolled back to previous state.");
            }
        }

        public void ExecuteStep(string step)
        {
            Save();

            try
            {
                switch (step)
                {
                    case "UpdateDB":
                        currentState.DatabaseUpdated = true;
                        break;
                    case "SendEmail":
                        currentState.WelcomeEmailSent = true;
                        break;
                    default:
                        throw new Exception("Unknown step");
                }
            }
            catch
            {
                Console.WriteLine("Error encountered. Rolling back...");
                Restore();
            }
        }
    }
}
