using DIP.Processors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
