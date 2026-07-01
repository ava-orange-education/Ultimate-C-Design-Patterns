using Chapter_7._03_Implementation_Strategy;
using Chapter_7._06_Introduction_Template;
using Chapter_7._07_Implementation_Template.ReportGenerator;
using Chapter_7._08_Example_Template;
using Chapter_7._08_Example_Template.Medical_Reporting;
using Chapter_7._08_Example_Template.Web_Scrapers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to part 3 - Implementation of Strategy
            var editor = new TrackEditor();
            var invoker = new CommandInvoker();

            IAction addDrums = new AddTrackCommand(editor, "Drum Beat");
            IAction addVocals = new AddTrackCommand(editor, "Vocal Line");
            IAction addBass = new AddTrackCommand(editor, "Bass Groove");

            invoker.ExecuteAction(addDrums);
            invoker.ExecuteAction(addVocals);
            invoker.ExecuteAction(addBass);

            editor.PrintTimeline();

            // Undo the last action
            invoker.UndoLast();
            editor.PrintTimeline();

            //to part 6 - Introduction to Template
            AbstractProcessor file = new FileProcessor();
            AbstractProcessor web = new WebProcessor();

            file.ExecuteProcess();
            Console.WriteLine();
            web.ExecuteProcess();

            //to part 7 - Implementation of Template
            ReportGenerator email = new EmailSummaryReport();
            ReportGenerator finance = new ExcelFinancialReport();
            ReportGenerator dialogue = new DialogueScriptReport();

            email.Generate();
            Console.WriteLine(new string('-', 40));

            finance.Generate();
            Console.WriteLine(new string('-', 40));

            dialogue.Generate();

            //to part 8 - Enemy AI
            EnemyAI guard = new GuardAI();
            EnemyAI drone = new DroneAI();

            guard.TakeTurn();
            Console.WriteLine();
            drone.TakeTurn();

            //to part 8 - Web Scrapers
            JobScraper scraper = new IndeedScraper();
            scraper.Scrape();

            //to part 8 - Medical Report
            MedicalReportGenerator report = new RadiologyReport();
            report.GenerateReport();



        }
    }
}
