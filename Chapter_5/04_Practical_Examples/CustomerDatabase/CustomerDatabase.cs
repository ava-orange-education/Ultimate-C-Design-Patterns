using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._04_Practical_Examples.CustomerDatabase
{
    class CustomerDatabase
    {
        static void Main()
        {
            CustomerProfile originalProfile = new CustomerProfile("John Doe", "Gold", new PurchaseHistory(new string[] { "Laptop", "Phone" }));
            CustomerProfile clonedProfile = originalProfile.Clone();  // Backup before modification

            clonedProfile.LoyaltyStatus = "Platinum";  // Updating cloned version

            Console.WriteLine($"Original: {originalProfile.Name}, Status = {originalProfile.LoyaltyStatus}, Purchases = {string.Join(", ", originalProfile.History.Items)}");
            Console.WriteLine($"Clone: {clonedProfile.Name}, Status = {clonedProfile.LoyaltyStatus}, Purchases = {string.Join(", ", clonedProfile.History.Items)}");
        }
    }
}
