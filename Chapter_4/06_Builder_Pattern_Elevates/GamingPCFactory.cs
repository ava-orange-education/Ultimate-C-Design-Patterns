using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._06_Builder_Pattern_Elevates
{
    public class GamingPCFactory
    {
        public static GamingPC CreateHighEndPC()
        {
            return new GamingPC("Intel i9", "NVIDIA RTX 4090", "32GB RAM", "2TB SSD");
        }

        public static GamingPC CreateBudgetPC()
        {
            return new GamingPC("AMD Ryzen 5", "RTX 3060", "16GB RAM", "512GB SSD");
        }
    }
}
