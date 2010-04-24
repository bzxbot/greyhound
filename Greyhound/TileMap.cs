using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace Greyhound
{
    public class TileMap
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int[,] TileMap { get; set; }
        public int TileWidth { get; set; }
        public int TileHeight { get; set; }
        public int TileCount { get; set; }
        public TileFormat TileFormat { get; set; }
        public Tile[] Tiles { get; set; }

        public void Load(string filePath)
        {

        }

        public void Save(string path)
        {
            StreamWriter sw = new StreamWriter(path);

            sw.Write(Width);
            sw.Write("  ");
            sw.WriteLine(Height);

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    sw.Write(TileMap[i, j]);
                    sw.Write(" ");
                }

                sw.WriteLine();
            }

            sw.Write(TileWidth);
            sw.Write("  ");
            sw.WriteLine(TileHeight);

            sw.Write(TileCount);
            sw.Write("  ");
            sw.Write(TileFormat);

            foreach (Tile tile in Tiles)
            {
                for (int x = 0; x < TileWidth; x++)
                {
                    for (int y = 0; y < TileHeight; y++)
                    {
                        Color color = tile.Bitmap.GetPixel(x, y);

                        sw.Write(color.R);
                        sw.Write(color.G);
                        sw.Write(color.B);
                    }
                }
            }
        }
    }

    public enum TileFormat
    {
        Text = 1,
        Binary = 2
    }
}
