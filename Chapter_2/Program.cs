using SolidPrinciples.DependencyInversionPrinciple.UserService;
using SolidPrinciples.OpenClosedPrinciple.NotificationFactory;
using SolidPrinciples.Plugin;
using SolidPrinciples.ReportGenerator;
using SolidPrinciples.SortStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Step 5: Using different sorting strategies dynamically
            var data = new int[] { 5, 2, 8, 3 };

            SortContext sorter = new SortContext(new BubbleSort());
            sorter.ExecuteSort(data);  // Outputs: Sorting using Bubble Sort...

            sorter = new SortContext(new QuickSort());
            sorter.ExecuteSort(data);  // Outputs: Sorting using Quick Sort...


            // Step 4: Using different reports dynamically
            SolidPrinciples.ReportGenerator.ReportGenerator report = new CsvReport();
            report.GenerateReport();

            report = new PdfReport();
            report.GenerateReport();

            // Usage
            var notification = NotificationFactory.CreateNotification("Email");
            notification.Send("Hello, Open/Closed Principle!");

        }

        //Plugin
        public void LoadPlugins(List<IPlugin> plugins)
        {
            foreach (var plugin in plugins)
            {
                Console.WriteLine($"Loading {plugin.Name}");
                plugin.Execute();
            }
        }

        //Character
        public void PerformAction(SolidPrinciples.Character.Character character)
        {
            character.Move();
            character.Attack();
        }
    }
}
