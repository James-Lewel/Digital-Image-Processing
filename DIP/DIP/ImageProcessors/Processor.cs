using System.Drawing;

namespace DIP.Processors
{
    public class Processor
    {
        public Bitmap CopyImage(Bitmap originalImage)
        {
            return originalImage;

            /*Bitmap processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            Color color;

            for(int x = 0; x < originalImage.Width; x++)
            {
                for(int y = 0; y < originalImage.Height; y++)
                {
                    color = originalImage.GetPixel(x, y);
                    processedImage.SetPixel(x, y, color);
                }
            }

            return processedImage;*/

            /*BitmapData bitmapData = originalImage.LockBits(
                new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                ImageLockMode.ReadWrite,
                originalImage.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(originalImage.PixelFormat) / 8;
            int byteCount = bitmapData.Stride * originalImage.Height;
            byte[] pixels = new byte[byteCount];
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;

            byte oldBlue;
            byte oldGreen;
            byte oldRed;

            for (int y = 0; y < heightInPixels; y++)
            {
                int currentLine = y * bitmapData.Stride;
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    oldBlue = pixels[currentLine + x];
                    oldGreen = pixels[currentLine + x + 1];
                    oldRed = pixels[currentLine + x + 2];

                    // calculate new pixel value
                    pixels[currentLine + x] = oldBlue;
                    pixels[currentLine + x + 1] = oldGreen;
                    pixels[currentLine + x + 2] = oldRed;
                }
            }

            // copy modified bytes back
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            originalImage.UnlockBits(bitmapData);

            return originalImage;*/
        }
    }
}
