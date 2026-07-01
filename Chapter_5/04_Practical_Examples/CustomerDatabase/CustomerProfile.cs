using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._04_Practical_Examples.CustomerDatabase
{
    class CustomerProfile : ICloneable
    {
        public string Name { get; set; }
        public string LoyaltyStatus { get; set; }
        public PurchaseHistory History { get; set; }

        public CustomerProfile(string name, string loyaltyStatus, PurchaseHistory history)
        {
            Name = name;
            LoyaltyStatus = loyaltyStatus;
            History = history;
        }

        public object Clone()
        {
            return new CustomerProfile(this.Name, this.LoyaltyStatus, this.History.DeepCopy());
        }
    }
}
