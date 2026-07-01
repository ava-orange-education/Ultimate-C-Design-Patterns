using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._03_Implementation_Iterator
{
    class Track
    {
        public string Title { get; }
        public string Artist { get; }
        public string Genre { get; }

        public Track(string title, string artist, string genre)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
        }
    }
}
