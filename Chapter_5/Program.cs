using Chapter_5._01_Intro_Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to Introduction to Prototype
            CharacterPrototype warrior = new Warrior(100, 50);
            CharacterPrototype cloneWarrior = warrior.Clone();

            Console.WriteLine($"Original Warrior: HP = {warrior.Health}, Stamina = {(warrior as Warrior).Stamina}");
            Console.WriteLine($"Cloned Warrior: HP = {cloneWarrior.Health}, Stamina = {(cloneWarrior as Warrior).Stamina}");

            CharacterPrototype mage = new Mage(80, 120);
            CharacterPrototype cloneMage = mage.Clone();

            Console.WriteLine($"Original Mage: HP = {mage.Health}, Mana = {(mage as Mage).Mana}");
            Console.WriteLine($"Cloned Mage: HP = {cloneMage.Health}, Mana = {(cloneMage as Mage).Mana}");

        }
    }
}
