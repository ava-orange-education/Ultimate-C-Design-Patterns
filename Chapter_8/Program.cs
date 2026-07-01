using Chapter_8._03_Implementation_Iterator;
using Chapter_8._04_Examples_Iterator.Log_Reader;
using Chapter_8._04_Examples_Iterator.Navigating_UI;
using Chapter_8._04_Examples_Iterator.Paging_ASP;
using Chapter_8._06_Introduction_State;
using Chapter_8._08_Implementation_State;
using Chapter_8._09_Examples_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to part 3 - Implementation Iterator
            var generator = new IntervalGenerator();
            Console.WriteLine("Even numbers between 1 and 10:");

            foreach (var number in generator.GetEvenNumbers(1, 10))
            {
                Console.WriteLine(number);
            }

            //to part 3 - Implementation Iterator - Track
            SmartPlaylist playlist = new SmartPlaylist();

            playlist.AddTrack(new Track("Code & Chill", "ByteBeats", "Lo-Fi"));
            playlist.AddTrack(new Track("Syntax Rave", "NullPointer", "Electronic"));
            playlist.AddTrack(new Track("Null Exception", "Stacktrace", "Lo-Fi"));
            playlist.AddTrack(new Track("Recursive Dreams", "NodeRunner", "Ambient"));

            Console.WriteLine("Lo-Fi Vibes:");
            foreach (var song in playlist.FilterByGenre("Lo-Fi"))
            {
                Console.WriteLine($"Now playing: {song.Title} by {song.Artist}");
            }

            //to part 4 - Search results
            var results = new SearchResults();
            var page = results.GetPage(10, 3);

            Console.WriteLine("Page 3:");
            foreach (var entry in page)
            {
                Console.WriteLine(entry);
            }

            //to part 4 - navigating UI
            var window = new Panel { Name = "MainWindow" };
            var tabPanel = new Panel { Name = "TabPanel" };
            tabPanel.Children.Add(new Button { Name = "SaveButton" });
            tabPanel.Children.Add(new TextBox { Name = "SearchBox" });
            window.Children.Add(tabPanel);

            var walker = new UIWalker();

            Console.WriteLine("All components:");
            foreach (var element in walker.Traverse(window))
            {
                Console.WriteLine($"- {element.Name}");
            }

            //to part 4 - Log Entry
            var reader = new LogFileReader();

            Console.WriteLine("Errors only:");
            foreach (var entry in reader.FilterByLevel("Error"))
            {
                Console.WriteLine($"[{entry.Timestamp}] {entry.Level}: {entry.Message}");
            }

            //to part 6 - Introduction State
            MachineContext machine = new MachineContext(new IdleMode());

            machine.Request(); // Switches to RunningMode
            machine.Request(); // Switches back to IdleMode

            //to part 8 - Chatbot
            ChatbotContext assistant = new ChatbotContext(new ListeningState());

            // Simulate three conversation cycles
            assistant.Receive(); // Listening → Thinking
            assistant.Receive(); // Thinking → Replying
            assistant.Receive(); // Replying → Listening

            //to part 9 - Game
            KaiContext kai = new KaiContext(new IdleState());

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Frame {i + 1}: ");
                kai.Update();
            }


        }
    }
}
