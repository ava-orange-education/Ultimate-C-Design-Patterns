using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._09_Examples_Flyweight
{
    class EnemyType
    {
        public string Model { get; }
        public string AnimationSet { get; }
        public string BehaviorScript { get; }

        public EnemyType(string model, string animationSet, string behaviorScript)
        {
            Model = model;
            AnimationSet = animationSet;
            BehaviorScript = behaviorScript;
        }

        public void ExecuteBehavior()
        {
            Console.WriteLine($"Executing shared behavior: {BehaviorScript}");
        }

        public void Render()
        {
            Console.WriteLine($"Rendering model: {Model} with animations: {AnimationSet}");
        }
    }
}
