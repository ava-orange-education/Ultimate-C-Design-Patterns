using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._03_Implementation_Iterator
{
    class SmartPlaylist : IEnumerable<Track>
    {
        private readonly List<Track> _library = new List<Track>();

        public void AddTrack(Track track)
        {
            _library.Add(track);
        }

        public IEnumerable<Track> FilterByGenre(string genre)
        {
            foreach (var track in _library)
            {
                if (track.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"[DJ] Found a {genre} track: {track.Title}");
                    yield return track;
                }
            }
        }

        public IEnumerator<Track> GetEnumerator() => _library.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
