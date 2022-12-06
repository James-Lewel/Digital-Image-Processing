using System.Drawing;

namespace DIP.Processors
{
    public class Processor
    {
        public Bitmap CopyImage(Bitmap originalImage)
        {
            Bitmap processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            Color color;

            for(int x = 0; x < originalImage.Width; x++)
            {
                for(int y = 0; y < originalImage.Height; y++)
                {
                    // Gets pixel from original image
                    color = originalImage.GetPixel(x, y);

                    // Copies pixel from original image to processed image
                    processedImage.SetPixel(x, y, color);
                }
            }

            return processedImage;
        }

        public Bitmap GreyscaleImage(Bitmap originalImage)
        {
            Bitmap processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            Color oldColor, newColor;
            byte red, green, blue, grey;

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    // Gets pixel from original image
                    oldColor = originalImage.GetPixel(x, y);

                    // Sets RGB
                    red = oldColor.R;
                    green = oldColor.G;
                    blue = oldColor.B;

                    // Computes the greyscale
                    grey = (byte)((red + green + blue) / 3);
                    newColor = Color.FromArgb(grey, grey, grey);

                    // Copies pixel from original image to processed image
                    processedImage.SetPixel(x, y, newColor);
                }
            }

            return processedImage;
        }

        public Bitmap ColorInversionImage(Bitmap originalImage)
        {
            Bitmap processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            Color oldColor, newColor;
            byte red, green, blue;

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    // Gets pixel from original image
                    oldColor = originalImage.GetPixel(x, y);

                    // Sets RGB and computes inversion
                    red = (byte)(255 - oldColor.R);
                    green = (byte)(255 - oldColor.G);
                    blue = (byte)(255 - oldColor.B);
                    newColor = Color.FromArgb(red, green, blue);

                    // Copies pixel from original image to processed image
                    processedImage.SetPixel(x, y, newColor);
                }
            }

            return processedImage;
        }
    }
}
