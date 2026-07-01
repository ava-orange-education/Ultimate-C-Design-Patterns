using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._03_Implementation_Strategy
{
    // Invoker: stores and invokes commands
    public class CommandInvoker
    {
        private readonly Stack<IAction> history = new Stack<IAction>();

        public void ExecuteAction(IAction action)
        {
            action.Execute();
            history.Push(action);
        }

        public void UndoLast()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("Nothing to undo.");
                return;
            }

            var lastAction = history.Pop();
            lastAction.Undo();
        }
    }
}
