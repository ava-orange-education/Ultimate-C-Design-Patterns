using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._05_Introduction_Facade
{
    public class MediaFacade
    {
        private AudioProcessor audio = new AudioProcessor();
        private VideoEncoder video = new VideoEncoder();
        private MetadataManager metadata = new MetadataManager();

        public void ConvertMedia(string file)
        {
            audio.NormalizeAudio(file);
            video.EncodeVideo(file);
            metadata.EmbedMetadata(file);
            Console.WriteLine($"Media conversion complete for {file}");
        }
    }
}
