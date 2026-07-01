using Chapter_12._01_Introduction_Decorator;
using Chapter_12._03_Implementation_Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for topic 1 - Introduction Decorator
            // Usage
            var plainFormatter = new PlainTextFormatter();
            var htmlDecorator = new HtmlDecorator();
            var markdownDecorator = new MarkdownDecorator();

            htmlDecorator.SetFormatter(plainFormatter);
            markdownDecorator.SetFormatter(htmlDecorator);

            markdownDecorator.Format();

            //for the topic 3 - Implementation Decorator
            IMessageFormatter formatter = new EncryptionDecorator(
            new TimestampDecorator(
                new UppercaseDecorator(
                    new BasicFormatter()
                    )
                )
            );

            string result = formatter.Format("Hello, world!");
            Console.WriteLine(result);


        }
    }
}
