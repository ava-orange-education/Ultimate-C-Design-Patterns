using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._05_The_Builder_Pattern.Factory_Method_vs_Builder
{
    public class Pizza
    {
        private string v;

        public Pizza()
        {
        }

        public Pizza(string v)
        {
            this.v = v;
        }

        internal void AddIngredient(string v)
        {
            Console.WriteLine(v);
        }
    }
}
