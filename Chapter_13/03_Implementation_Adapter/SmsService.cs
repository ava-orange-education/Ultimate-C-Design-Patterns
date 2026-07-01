using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._03_Implementation_Adapter
{
    // The adaptee class with a different method
    public class SmsService
    {
        public void SendTextMessage(string text)
        {
            Console.WriteLine($"Sending SMS: {text}");
        }
    }
}
