using Chapter_5._03_Implementation_Prototype.Hidden_Danger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._03_Implementation_Prototype.Deep_Copy
{
    class GameClient
    {
        static void Main()
        {
            GameAvatar baseAvatar = new GameAvatar("Warrior", 100, new Weapon("Sword"));
            GameAvatar playerClone = (GameAvatar)baseAvatar.Clone();
            playerClone.Customize("Elite Warrior", 150);

            Console.WriteLine($"Base Avatar: {baseAvatar.Name}, HP = {baseAvatar.Health}, Weapon = {baseAvatar.EquippedWeapon.Name}");
            Console.WriteLine($"Player Clone: {playerClone.Name}, HP = {playerClone.Health}, Weapon = {playerClone.EquippedWeapon.Name}");
        }
    }
}
