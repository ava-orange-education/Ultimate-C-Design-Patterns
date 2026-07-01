using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._02_Best_Practices
{
    public class AddToCartCommand : ICommand
    {
        private readonly Cart _cart;
        private readonly Product _product;

        public AddToCartCommand(Cart cart, Product product)
        {
            _cart = cart;
            _product = product;
        }

        public void Execute()
        {
            _cart.Add(_product);
        }
    }
}
