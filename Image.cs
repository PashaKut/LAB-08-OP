using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_OP
{
    public class Image
    {
        private readonly Pixel[,] pixels;
        private readonly int width;
        private readonly int height;

        public Image(int width, int height, Pixel[,] pixels)
        {
            this.width = width;
            this.height = height;
            this.pixels = pixels;
        }

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        public Pixel GetPixel(int x, int y)
        {
            return pixels[x, y];
        }

        public Image Resize(int newWidth, int newHeight)
        {
            Pixel[,] resizedPixels = new Pixel[newWidth, newHeight];

            double widthRatio = (double)width / newWidth;
            double heightRatio = (double)height / newHeight;

            for (int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int sourceX = (int)(x * widthRatio);
                    int sourceY = (int)(y * heightRatio);

                    resizedPixels[x, y] = pixels[sourceX, sourceY];
                }
            }

            return new Image(newWidth, newHeight, resizedPixels);
        }

        public Image Crop(int x, int y, int cropWidth, int cropHeight)
        {
            Pixel[,] croppedPixels = new Pixel[cropWidth, cropHeight];

            for (int i = 0; i < cropWidth; i++)
            {
                for (int j = 0; j < cropHeight; j++)
                {
                    int sourceX = x + i;
                    int sourceY = y + j;

                    croppedPixels[i, j] = pixels[sourceX, sourceY];
                }
            }

            return new Image(cropWidth, cropHeight, croppedPixels);
        }


    }

}
