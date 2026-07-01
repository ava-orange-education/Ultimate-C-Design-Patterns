using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._03_Impementation_Composite
{
    class RestaurantApp
    {
        public void ShowMenu()
        {
            MenuComponent mainMenu = new MenuGroup("Main Menu");
            MenuComponent pasta = new MenuItem("Spaghetti Carbonara");
            MenuComponent salad = new MenuItem("Caesar Salad");

            MenuGroup dessertMenu = new MenuGroup("Desserts");
            dessertMenu.Add(new MenuItem("Tiramisu"));
            dessertMenu.Add(new MenuItem("Gelato"));

            mainMenu.Add(pasta);
            mainMenu.Add(salad);
            mainMenu.Add(dessertMenu);

            mainMenu.Display();
        }
    }
}
