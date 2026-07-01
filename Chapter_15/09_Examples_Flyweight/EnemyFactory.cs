using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._09_Examples_Flyweight
{
    class EnemyFactory
    {
        private Dictionary<string, EnemyType> types = new Dictionary<string, EnemyType>();

        public EnemyType GetEnemyType(string model, string animationSet, string behaviorScript)
        {
            string key = model + animationSet + behaviorScript;
            if (!types.ContainsKey(key))
            {
                types[key] = new EnemyType(model, animationSet, behaviorScript);
                Console.WriteLine($"Created new EnemyType: {key}");
            }
            return types[key];
        }
    }
}
