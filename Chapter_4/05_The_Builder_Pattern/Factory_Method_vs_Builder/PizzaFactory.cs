using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._05_The_Builder_Pattern.Factory_Method_vs_Builder
{
    public class PizzaFactory
    {
        public static Pizza CreatePizza(string type)
        {
            if (type == "Margherita") return new Pizza("Tomato, Cheese");
            if (type == "Pepperoni") return new Pizza("Tomato, Cheese, Pepperoni");
            return new Pizza("Custom toppings");
        }
    }
}
