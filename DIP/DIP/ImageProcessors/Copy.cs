using DIP.Processors;
using System.Drawing;
using System.Windows.Forms;

namespace DIP.ImageProcessors
{
    internal class Copy
    {
        private static readonly Processor _processor = new Processor();

        public static Bitmap Process(Bitmap originalBitap)
        {
            return _processor.CopyImage(originalBitap);
        }
    }
}
