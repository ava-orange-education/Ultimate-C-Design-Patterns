using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._01_Introduction_Strategy
{
    // Invoker
    class TaskInvoker
    {
        private ActionCommand command;

        public void SetCommand(ActionCommand command)
        {
            this.command = command;
        }

        public void Run()
        {
            command.Execute();
        }

        public void Cancel()
        {
            command.Undo();
        }
    }
}
