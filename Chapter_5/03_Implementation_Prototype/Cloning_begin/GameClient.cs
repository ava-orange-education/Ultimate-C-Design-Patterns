using Chapter_5._01_Intro_Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._03_Implementation_Prototype.Cloning_begin
{
    class GameClient
    {
        static void Main()
        {
            CharacterPrototype original = new CharacterPrototype("Knight", 100, 50);
            CharacterPrototype clone = (CharacterPrototype)original.Clone();

            Console.WriteLine($"Original Character: {original.Name}, HP = {original.Health}, Stamina = {original.Stamina}");
            Console.WriteLine($"Cloned Character: {clone.Name}, HP = {clone.Health}, Stamina = {clone.Stamina}");
        }
    }
}
