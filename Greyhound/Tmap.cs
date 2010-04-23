using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greyhound
{
    class Tmap
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int[,] TileMap { get; set; }

        public int TileWidth { get; set; }
        public int TileHeight { get; set; }

        public int TileCount { get; set; }
    }
}
