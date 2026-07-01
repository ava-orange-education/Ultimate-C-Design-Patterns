using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._02_Best_Practices
{
    internal class CartCommand_Test
    {
        [Fact]
        public void Execute_ShouldAddProductToCart()
        {
            var cart = new Cart();
            var product = new Product("Book", 29.99m);
            var command = new AddToCartCommand(cart, product);

            command.Execute();

            Assert.Contains(product, cart.Items);
        }
    }
}
