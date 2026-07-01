using Chapter_1._2_Benefits.Logger;
using Chapter_1._2_Benefits.Unit_Testing;
using Chapter_1._3_Implementation.LoggerFactory;
using Chapter_1._5_Real_World_Examples.ReportGeneratorFactory;
using Chapter_1._6_Introduction_Abstract_Factory.Definition;
using Chapter_1._6_Introduction_Abstract_Factory.StorageService;
using Chapter_1._6_Introduction_Abstract_Factory.UI_Design;
using Chapter_1._6_Introduction_Abstract_Factory.UIFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Benefits - Logger
            Logger logger = TestLoggerFactory.CreateMockLogger();
            logger.Log("Unit Test Log");

            //Implementation - LoggerFactory
            _3_Implementation.LoggerFactory.LoggerFactory factory = new ConsoleLoggerFactory();
            _3_Implementation.LoggerFactory.ILogger logger1 = factory.CreateLogger();

            logger1.Log("Factory Method in action!");

            //Real-World examples
            IReportGenerator generator = ReportGeneratorFactory.CreateGenerator("PDF");
            generator.LoadDataFromDatabase();
            generator.ApplyFormatting();

            //// Example Usage -Abstract Factory
            Chapter_1._6_Introduction_Abstract_Factory.Definition.IUIFactory factory1 = new Chapter_1._6_Introduction_Abstract_Factory.Definition.WindowsUIFactory(); // Switch to MacUIFactory for MacOS
            _6_Introduction_Abstract_Factory.Definition.Application app = new _6_Introduction_Abstract_Factory.Definition.Application(factory1);
            app.RenderUI();

            //Example - Storage Factory
            IStorageFactory factory2 = new GoogleCloudStorageFactory();
            IStorageService storageService = factory2.CreateStorageService();
            storageService.UploadFile("report.pdf");

            //// Example Usage UIFactory
            // Select the correct UI factory based on the environment
            _6_Introduction_Abstract_Factory.UIFactory.IUIFactory factory3;
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    factory3 = new _6_Introduction_Abstract_Factory.UIFactory.WindowsUIFactory();
                    break;
                case PlatformID.MacOSX:
                    factory3 = new _6_Introduction_Abstract_Factory.UIFactory.MacUIFactory();
                    break;
                default:
                    factory3 = new LinuxUIFactory();
                    break;
            }

            _6_Introduction_Abstract_Factory.UIFactory.Application app1 = new _6_Introduction_Abstract_Factory.UIFactory.Application(factory3);
            app.RenderUI();

            //Example - UI_Desig
            string currentTheme = "Dark"; // Example: Retrieved from user settings
            _6_Introduction_Abstract_Factory.UI_Design.IUIFactory factory4 = GetThemeFactory(currentTheme);

            UIManager ui = new UIManager(factory4);
            ui.RenderUI();

        }

        public static _6_Introduction_Abstract_Factory.UI_Design.IUIFactory GetThemeFactory(string themePreference)
        {
            switch (themePreference)
            {
                case "Light":
                    return new LightThemeFactory();
                case "Dark":
                    return new DarkThemeFactory();
                default:
                    throw new ArgumentException("Unknown theme");
            }
        }

    }
}
