using Chapter_10._03_Implementation_Mediator;
using Chapter_10._06_Introduction_Memento;
using Chapter_10._08_Implementation_Memento;
using Chapter_10._10_Best_Practices_Memento.History;
using Chapter_10._10_Best_Practices_Memento.Snapshot;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Chapter_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to topic 3 - Implementation Mediator
            ClassroomHub mediator = new ClassroomHub();

            var projector = new SmartProjector(mediator);
            var lights = new SmartLights(mediator);
            var ac = new ClimateControl(mediator);

            mediator.Projector = projector;
            mediator.Lights = lights;
            mediator.AC = ac;

            projector.StartPresentation();

            Console.WriteLine();

            lights.DetectLowAmbientLight();

            Console.WriteLine();

            projector.EndPresentation();

            //to topic 6 - Introduction Memento
            var editor = new NoteEditor();
            var history = new VersionManager();

            editor.Write("First draft.");
            history.SaveSnapshot(editor.Save());

            editor.Write("Second draft.");
            editor.Write("Third draft.");

            editor.Restore(history.RetrieveSnapshot());


            //to topic 7 - Implementation Memento
            var tracker = new GoalTracker();
            var memory = new GoalHistory();

            tracker.UpdateGoal("Become a C# master.");
            memory.Save(tracker.SaveState());

            tracker.UpdateGoal("Build a billion-dollar startup.");
            memory.Save(tracker.SaveState());

            tracker.UpdateGoal("Write code in the Alps.");

            Console.WriteLine("\nOops, let's rewind...\n");
            var previous = memory.Undo();
            if (previous != null)
                tracker.RestoreState(previous);

            previous = memory.Undo();
            if (previous != null)
                tracker.RestoreState(previous);


        }

        //to topic 10
        // Saving to file
        public void SaveSnapshot(GameStateSnapshot snapshot, string path)
        {
            var json = JsonSerializer.Serialize(snapshot);
            File.WriteAllText(path, json);
        }

        // Restoring from file
        public GameStateSnapshot LoadSnapshot(string path)
        {
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<GameStateSnapshot>(json);
        }

        public void RestoreState(ConfigSnapshot snapshot)
        {
            switch (snapshot.Version)
            {
                case 1:
                    // Handle legacy format
                    break;
                case 2:
                    // Apply new logic
                    break;
                default:
                    throw new NotSupportedException("Unknown snapshot version");
            }
        }

    }
}
