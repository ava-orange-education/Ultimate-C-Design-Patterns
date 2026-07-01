using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._03_Implementation_Strategy
{
    // Concrete command: encapsulates the action of adding a track
    public class AddTrackCommand : IAction
    {
        private readonly TrackEditor editor;
        private readonly string trackName;

        public AddTrackCommand(TrackEditor editor, string trackName)
        {
            this.editor = editor;
            this.trackName = trackName;
        }

        public void Execute()
        {
            editor.AddTrack(trackName);
        }

        public void Undo()
        {
            editor.RemoveTrack(trackName);
        }
    }
}
