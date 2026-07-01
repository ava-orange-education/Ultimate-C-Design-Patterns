using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public double TotalAmount { get; set; }
    }
}
