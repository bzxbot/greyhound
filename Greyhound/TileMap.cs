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
        public int[,] TileMatrix { get; set; }
        public int TileWidth { get; set; }
        public int TileHeight { get; set; }
        public int TileCount { get; set; }
        public TileFormat TileFormat { get; set; }
        public List<Tile> Tiles { get; set; }

        public TileMap(int width, int height)
        {
            Width = width;
            Height = height;

            TileMatrix = new int[Width, Height];

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    TileMatrix[x, y] = -1;
                }
            }

            Tiles = new List<Tile>();
        }

        public void Load(string filePath)
        {

        }

        public void Save(string path)
        {
            StreamWriter sw = new StreamWriter(path);

            sw.Write(Width);
            sw.Write("  ");
            sw.WriteLine(Height);

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    sw.Write(TileMatrix[i, j]);
                    sw.Write(" ");
                }

                sw.WriteLine();
            }

            sw.Write(TileWidth);
            sw.Write("  ");
            sw.WriteLine(TileHeight);

            sw.Write(TileCount);
            sw.Write("  ");
            sw.WriteLine(TileFormat);

            foreach (Tile tile in Tiles)
            {
                if (tile.Bitmap == null)
                    continue;

                for (int x = 0; x < tile.Bitmap.Width; x++)
                {
                    for (int y = 0; y < tile.Bitmap.Height; y++)
                    {
                        Color color = tile.Bitmap.GetPixel(x, y);

                        sw.Write(color.R);
                        sw.Write(color.G);
                        sw.Write(color.B);
                    }
                }
            }

            sw.Close();
        }
    }

    public enum TileFormat
    {
        Text = 1,
        Binary = 2
    }
}
