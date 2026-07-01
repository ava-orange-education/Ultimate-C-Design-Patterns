using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._09_Examples_Flyweight
{
    class Enemy
    {
        private int x;
        private int y;
        private int health;
        private EnemyType type;

        public Enemy(int x, int y, int health, EnemyType type)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.type = type;
        }

        public void Update()
        {
            Console.WriteLine($"Enemy at ({x},{y}) with health {health}");
            type.ExecuteBehavior();
        }

        public void Draw()
        {
            type.Render();
        }
    }
}
