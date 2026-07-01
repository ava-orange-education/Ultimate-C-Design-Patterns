using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._09_Examples_Memento.Game_Checkpoints
{
    public class Hero
    {
        public int Level { get; private set; }
        public List<string> Inventory { get; private set; } = new List<string>();

        public void AddItem(string item)
        {
            Inventory.Add(item);
            Console.WriteLine($"Picked up: {item}");
        }

        public void LevelUp()
        {
            Level++;
            Console.WriteLine($"Level increased to: {Level}");
        }

        public HeroCheckpoint SaveState()
        {
            return new HeroCheckpoint(Level, new List<string>(Inventory));
        }

        public void RestoreState(HeroCheckpoint checkpoint)
        {
            Level = checkpoint.Level;
            Inventory = new List<string>(checkpoint.Items);
            Console.WriteLine("Game restored to previous checkpoint.");
        }
    }
}
