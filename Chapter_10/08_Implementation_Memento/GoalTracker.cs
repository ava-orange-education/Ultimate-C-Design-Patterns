using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._08_Implementation_Memento
{
    public class GoalTracker
    {
        public string Goal { get; private set; }

        public void UpdateGoal(string newGoal)
        {
            Console.WriteLine($"Updating goal to: {newGoal}");
            Goal = newGoal;
        }

        public GoalSnapshot SaveState()
        {
            Console.WriteLine($"Saving current goal: {Goal}");
            return new GoalSnapshot(Goal);
        }

        public void RestoreState(GoalSnapshot snapshot)
        {
            Goal = snapshot.StoredGoal;
            Console.WriteLine($"Goal restored to: {Goal}");
        }
    }
}
