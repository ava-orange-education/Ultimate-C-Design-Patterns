using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._04_Integration_testing
{
    public class VideoStreamingFacade
    {
        private readonly Encoder _encoder;
        private readonly Storage _storage;
        private readonly Notifier _notifier;

        public VideoStreamingFacade(Encoder encoder, Storage storage, Notifier notifier)
        {
            _encoder = encoder;
            _storage = storage;
            _notifier = notifier;
        }

        public bool StreamVideo(string rawVideo)
        {
            var encoded = _encoder.Encode(rawVideo);
            var stored = _storage.Save(encoded);
            _notifier.Notify("Video is live!");
            return stored;
        }
    }
}
