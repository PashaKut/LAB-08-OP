using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_OP
{
    public class Pixel : PixelCoordinates
    {
        private readonly Color color;

        public Pixel(int x, int y, Color color) : base(x, y)
        {
            this.color = color;
        }

        public Color Color
        {
            get { return color; }
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            Pixel other = (Pixel)obj;
            return color.Equals(other.color);
        }

        public override string ToString()
        {
            return $"({X}, {Y}) - {color}";
        }
    }

}
