using System.Collections.Generic;

namespace Chapter_16._02_Common_Antipatterns
{
    public class Order
    {
        public List<Item> Items { get; internal set; }
    }
}