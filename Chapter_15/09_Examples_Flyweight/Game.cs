using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._09_Examples_Flyweight
{
    class Game
    {
        static void Main()
        {
            EnemyFactory factory = new EnemyFactory();
            List<Enemy> enemies = new();

            for (int i = 0; i < 500; i++)
            {
                int x = i % 50;
                int y = i / 10;
                int health = 100;
                var type = factory.GetEnemyType("DroneModel", "HoverAnim", "AggressiveAI");
                enemies.Add(new Enemy(x, y, health, type));
            }

            foreach (var enemy in enemies)
            {
                enemy.Update();
                enemy.Draw();
            }
        }
    }
}
