using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_OP
{
    public abstract class PixelCoordinates
    {
        protected int x;
        protected int y;

        public PixelCoordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            PixelCoordinates other = (PixelCoordinates)obj;
            return x == other.x && y == other.y;
        }


        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }

}
