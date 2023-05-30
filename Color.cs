using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_OP
{
    public class Color
    {
        private readonly int red;
        private readonly int green;
        private readonly int blue;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public int Red
        {
            get { return red; }
        }

        public int Green
        {
            get { return green; }
        }

        public int Blue
        {
            get { return blue; }
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Color other = (Color)obj;
            return red == other.red && green == other.green && blue == other.blue;
        }

        public override string ToString()
        {
            return $"RGBA: {red}, {green}, {blue}";
        }

        public Color Blend(Color other, double blendFactor)
        {
            int blendedRed = (int)(Red + (other.Red - Red) * blendFactor);
            int blendedGreen = (int)(Green + (other.Green - Green) * blendFactor);
            int blendedBlue = (int)(Blue + (other.Blue - Blue) * blendFactor);

            return new Color(blendedRed, blendedGreen, blendedBlue);
        }
    }

}
