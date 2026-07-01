using Chapter_13._03_Implementation_Adapter;
using Chapter_13._04_Examples_Adapter;
using Chapter_13._05_Introduction_Facade;
using Chapter_13._07_Implementation_Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to topic 3 - Implementation Adapter
            var client = new NotificationClient();
            var adapter = new SmsAdapter();

            client.Notify(adapter);

            //to topic 4 - Examples Adapter
            var client1 = new PaymentClient();
            var adapter1 = new BillingAdapter();

            client1.MakePayment(adapter1, 199.99m);

            //to topic 6 - Introduction Facade
            MediaFacade converter = new MediaFacade();
            converter.ConvertMedia("holiday_clip.mp4");

            //to topic 7 - Implementation Facade
            var mediaConverter = new MediaConverterFacade();
            mediaConverter.ConvertVideo("holiday_clip.avi");


        }
    }
}
