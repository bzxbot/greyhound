using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Greyhound
{
    public class Tile
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Bitmap Bitmap { get; set; }

        public Tile(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
