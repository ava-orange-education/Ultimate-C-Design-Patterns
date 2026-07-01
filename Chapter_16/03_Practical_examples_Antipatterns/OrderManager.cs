using Chapter_16._02_Common_Antipatterns;
using Chapter_16._05_Best_Practices_Anti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_16._03_Practical_examples_Antipatterns
{
    public class OrderManager
    {
        public void LoadOrders()
        {
            var orders = Database.Load("SELECT * FROM Orders");
            DisplayOrders(orders);
        }

        public void DisplayOrders(List<Order> orders)
        {
            // UI rendering logic
        }

        public void SaveOrder(Order order)
        {
            if (IsValid(order))
            {
                Database.Save(order);
                MessageBox.Show("Order saved!");
            }
        }

        private bool IsValid(Order order)
        {
            // Validation logic
            return true;
        }
    }

    internal class Database
    {
        internal static List<Order> Load(string v)
        {
            throw new NotImplementedException();
        }

        internal static void Save(Order order)
        {
            throw new NotImplementedException();
        }

        internal static void Save(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        internal void Save(Feedback feedback)
        {
            throw new NotImplementedException();
        }
    }
}
