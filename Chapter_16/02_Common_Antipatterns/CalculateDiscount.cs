using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._02_Common_Antipatterns
{
    internal class CalculateDiscount
    {
        public double CalculateDiscount1(Customer customer)
        {
            if (customer.IsPremium)
                return 0.1;
            else
                return 0.05;
        }

        public void ApplyDiscount(Customer customer)
        {
            if (customer.IsPremium)
                customer.Discount = 0.1;
            else
                customer.Discount = 0.05;
        }

        public List<string> GetActiveUsernames(List<User> users)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].IsActive)
                {
                    result.Add(users[i].Username);
                }
            }
            return result;
        }

    }
}
