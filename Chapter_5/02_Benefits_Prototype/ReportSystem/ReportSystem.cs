using Chapter_5._02_Benefits_Prototype.ReportSystem;
using System;

class ReportSystem
{
    static void Main()
    {
        ReportTemplate baseReport = new ReportTemplate("Financial Q2", "Revenue analysis", new ReportConfig("USD", true));
        ReportTemplate clonedReport = baseReport.Clone();

        clonedReport.Title = "Financial Q3";  // Modifying only necessary data

        Console.WriteLine($"Original Report: {baseReport.Title}, Currency = {baseReport.Config.Currency}");
        Console.WriteLine($"Cloned Report: {clonedReport.Title}, Currency = {clonedReport.Config.Currency}");
    }
}
