using Chapter_7._03_Implementation_Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._04_Undo_Redo
{
    public class MacroCommand : IAction
    {
        private readonly List<IAction> actions = new List<IAction>();

        public void AddAction(IAction action)
        {
            actions.Add(action);
        }

        public void Execute()
        {
            foreach (var action in actions)
                action.Execute();
        }

        public void Undo()
        {
            for (int i = actions.Count - 1; i >= 0; i--)
                actions[i].Undo();
        }
    }
}
