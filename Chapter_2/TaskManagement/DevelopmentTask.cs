using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.TaskManagement
{
    public class DevelopmentTask : Task, ITrackable
    {
        public override void Execute()
        {
            Console.WriteLine("Writing code...");
        }

        public void TrackProgress()
        {
            Console.WriteLine("Tracking development progress...");
        }
    }
}
