using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._08_Implementation_Memento
{
    public class GoalHistory
    {
        private readonly Stack<GoalSnapshot> history = new Stack<GoalSnapshot>();

        public void Save(GoalSnapshot snapshot)
        {
            Console.WriteLine("Saving snapshot to history.");
            history.Push(snapshot);
        }

        public GoalSnapshot Undo()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("No previous goal to restore.");
                return null;
            }

            Console.WriteLine("Reverting to previous goal.");
            return history.Pop();
        }
    }
}
