using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._07_Implementation_Facade
{
    public class MediaConverterFacade
    {
        private readonly VideoDecoder _decoder;
        private readonly AudioExtractor _audioExtractor;
        private readonly FormatConverter _converter;
        private readonly Logger _logger;
        private readonly Watermarker _watermarker;

        public MediaConverterFacade()
        {
            _decoder = new VideoDecoder();
            _audioExtractor = new AudioExtractor();
            _converter = new FormatConverter();
            _logger = new Logger();
            _watermarker = new Watermarker();
        }

        public void ConvertVideo(string filePath)
        {
            _logger.Log("Starting media conversion...");
            _decoder.Decode(filePath);
            _audioExtractor.ExtractAudio(filePath);
            _converter.ConvertToMp4(filePath);
            _logger.Log("Media conversion completed.");
            _watermarker.ApplyWatermark(filePath);
        }
    }
}
