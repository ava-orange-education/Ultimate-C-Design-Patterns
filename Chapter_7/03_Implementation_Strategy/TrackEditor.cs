using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._03_Implementation_Strategy
{
    // Receiver class: the system that performs the real work
    public class TrackEditor
    {
        private readonly List<string> timeline = new List<string>();

        public void AddTrack(string trackName)
        {
            timeline.Add(trackName);
            Console.WriteLine($"Track \"{trackName}\" added.");
        }

        public void RemoveTrack(string trackName)
        {
            timeline.Remove(trackName);
            Console.WriteLine($"Track \"{trackName}\" removed.");
        }

        public void PrintTimeline()
        {
            Console.WriteLine("\n[Timeline]");
            foreach (var track in timeline)
                Console.WriteLine($" - {track}");
            Console.WriteLine();
        }
    }
}
