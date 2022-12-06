using DIP.Processors;
using System.Drawing;

namespace DIP.ImageProcessors
{
    internal class Greyscale
    {
        private static readonly Processor _processor = new Processor();

        public static Bitmap Process(Bitmap originalBitap)
        {
            return _processor.GreyscaleImage(originalBitap);
        }
    }
}
