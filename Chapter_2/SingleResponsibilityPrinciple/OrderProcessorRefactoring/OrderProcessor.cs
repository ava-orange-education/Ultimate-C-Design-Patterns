using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple.OrderProcessorRefactoring
{
    public class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            // Validate Order
            if (order.TotalAmount <= 0)
                throw new Exception("Invalid order amount");

            // Apply Discount Logic (Should be separate)
            order.TotalAmount -= order.TotalAmount * 0.1;

            // Generate Invoice (Should be separate)
            Console.WriteLine($"Invoice generated for Order: {order.Id}");
        }
    }
}
