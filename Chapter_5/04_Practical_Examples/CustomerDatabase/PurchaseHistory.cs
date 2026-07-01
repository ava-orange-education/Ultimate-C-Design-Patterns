using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._04_Practical_Examples.CustomerDatabase
{
    class PurchaseHistory
    {
        public string[] Items { get; set; }

        public PurchaseHistory(string[] items)
        {
            Items = items;
        }

        public PurchaseHistory DeepCopy()
        {
            return new PurchaseHistory((string[])Items.Clone());
        }
    }
}
