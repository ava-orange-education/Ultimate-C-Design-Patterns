using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._08_Implementation_Memento
{
    public class GoalSnapshot
    {
        public string StoredGoal { get; }
        public DateTime Timestamp { get; }
        public int MotivationLevel { get; }

        public GoalSnapshot(string goal, int motivationLevel)
        {
            StoredGoal = goal;
            MotivationLevel = motivationLevel;
            Timestamp = DateTime.Now;
        }
    }
}
