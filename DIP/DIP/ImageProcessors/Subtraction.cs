using DIP.Processors;
using System.Drawing;

namespace DIP.ImageProcessors
{
    internal class Subtraction
    {
        private static readonly Processor _processor = new Processor();

        public static Bitmap Process(Bitmap foregroundBitmap, Bitmap backgroundBitMap, byte threshold)
        {
            return _processor.SubtractionImage(foregroundBitmap, backgroundBitMap, threshold);
        }
    }
}
