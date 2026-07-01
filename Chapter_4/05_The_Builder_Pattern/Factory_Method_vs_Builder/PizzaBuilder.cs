using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._05_The_Builder_Pattern.Factory_Method_vs_Builder
{
    public class PizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PizzaBuilder AddCheese()
        {
            _pizza.AddIngredient("Cheese");
            return this;
        }

        public PizzaBuilder AddTomato()
        {
            _pizza.AddIngredient("Tomato");
            return this;
        }

        public PizzaBuilder AddPepperoni()
        {
            _pizza.AddIngredient("Pepperoni");
            return this;
        }

        public Pizza Build() => _pizza;
    }
}
