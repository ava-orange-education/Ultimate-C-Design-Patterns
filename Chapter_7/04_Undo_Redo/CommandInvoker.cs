using Chapter_7._03_Implementation_Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._04_Undo_Redo
{
    public class CommandInvoker
    {
        private readonly Stack<IAction> undoStack = new Stack<IAction>();
        private readonly Stack<IAction> redoStack = new Stack<IAction>();

        public void ExecuteAction(IAction action)
        {
            action.Execute();
            undoStack.Push(action);
            redoStack.Clear(); // Once a new action is executed, redo history is reset
        }

        public void UndoLast()
        {
            if (undoStack.Count == 0)
            {
                Console.WriteLine("Nothing to undo.");
                return;
            }

            var last = undoStack.Pop();
            last.Undo();
            redoStack.Push(last);
        }

        public void RedoLast()
        {
            if (redoStack.Count == 0)
            {
                Console.WriteLine("Nothing to redo.");
                return;
            }

            var next = redoStack.Pop();
            next.Execute();
            undoStack.Push(next);
        }
    }
}
