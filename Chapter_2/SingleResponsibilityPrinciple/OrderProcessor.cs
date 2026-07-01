using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    public class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            // Validate order details
            if (string.IsNullOrEmpty(order.CustomerName))
                throw new Exception("Invalid order!");

            // Save order to database
            SaveToDatabase(order);

            // Send confirmation email
            SendEmail(order);
        }

        private void SaveToDatabase(Order order)
        {
            // Logic for saving order
        }

        private void SendEmail(Order order)
        {
            // Logic for sending email
        }
    }
}
