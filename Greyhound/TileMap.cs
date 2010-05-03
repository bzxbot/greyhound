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
        public int Lines { get; set; }
        public int Columns { get; set; }
        public int[,] TileMatrix { get; set; }
        public int TileWidth { get; set; }
        public int TileHeight { get; set; }
        public int TileCount { get; set; }
        public TileFormat TileFormat { get; set; }
        public List<Tile> Tiles { get; set; }

        public TileMap(int lines, int columns, int tileSize)
        {
            Lines = lines;
            Columns = columns;
            TileWidth = tileSize;
            TileHeight = tileSize;

            TileMatrix = new int[Lines, Columns];

            for (int x = 0; x < Lines; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    TileMatrix[x, y] = -1;
                }
            }

            Tiles = new List<Tile>();

            TileFormat = TileFormat.Text;
        }

        public TileMap(string path)
        {
            Load(path);
        }

        public void Load(string path)
        {
            StreamReader sw = new StreamReader(path);

            string line = sw.ReadLine();
            string[] split = line.Split(' ');

            Lines = int.Parse(split[0]);
            Columns = int.Parse(split[1]);

            TileMatrix = new int[Lines, Columns];

            for (int i = 0; i < Lines; i++)
            {
                line = sw.ReadLine();

                split = line.Split(' ');

                for (int j = 0; j < split.Length && j < Columns; j++)
                {
                    TileMatrix[i, j] = int.Parse(split[j]);
                }
            }

            line = sw.ReadLine();
            split = line.Split(' ');

            TileWidth = int.Parse(split[0]);
            TileHeight = int.Parse(split[1]);

            line = sw.ReadLine();
            split = line.Split(' ');

            TileCount = int.Parse(split[0]);
            TileFormat = (TileFormat)int.Parse(split[1]);

            Tiles = new List<Tile>();

            line = sw.ReadLine();
            split = line.Split(' ');

            int offset = 0;

            for (int i = 0; i < TileCount; i++)
            {
                Tile tile = new Tile();

                Bitmap bitmap = new Bitmap(TileWidth, TileHeight);

                for (int j = 0; j < TileHeight * TileWidth; j++)
                {
                    int r = int.Parse(split[offset++]);
                    int g = int.Parse(split[offset++]);
                    int b = int.Parse(split[offset++]);

                    bitmap.SetPixel(j / TileWidth, j % TileHeight, Color.FromArgb(r, g, b));
                }

                tile.Bitmap = bitmap;

                Tiles.Add(tile);
            }

            sw.Close();
        }

        public void Save(string path)
        {
            StreamWriter sw = new StreamWriter(path);

            sw.Write(Lines);
            sw.Write(" ");
            sw.WriteLine(Columns);

            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    sw.Write(TileMatrix[i, j]);
                    sw.Write(" ");
                }

                sw.WriteLine();
            }

            sw.Write(TileWidth);
            sw.Write(" ");
            sw.WriteLine(TileHeight);

            sw.Write(Tiles.Count);
            sw.Write(" ");
            sw.WriteLine((int)TileFormat);

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
                        sw.Write(" ");
                        sw.Write(color.G);
                        sw.Write(" ");
                        sw.Write(color.B);
                        sw.Write(" ");
                    }
                }
            }

            sw.Close();
        }

        public void RemoveTile(int x, int y)
        {
            if (TileMatrix[x, y] == -1)
            {
                return;
            }

            int index = TileMatrix[x, y];

            bool inUse = false;

            for (int i = 0; i < Lines; i++)
            {
                if (inUse)
                {
                    break;
                }

                for (int j = 0; j < Columns; j++)
                {
                    if ((x != i || y != j) && TileMatrix[i, j] == TileMatrix[x, y])
                    {
                        inUse = true;

                        break;
                    }
                }
            }

            if (!inUse)
            {
                Tiles.RemoveAt(index);

                for (int i = 0; i < Lines; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (TileMatrix[i, j] > index)
                        {
                            TileMatrix[i, j]--;
                        }
                    }
                }
            }

            TileMatrix[x, y] = -1;
        }

        public void SetTile(int x, int y, Tile tile)
        {
            int index = Tiles.FindIndex(t => t.ImageHash == tile.ImageHash);

            if (index == -1)
            {
                Tiles.Add(tile);

                if (TileMatrix[x, y] != -1)
                {
                    RemoveTile(x, y);
                }

                TileMatrix[x, y] = Tiles.Count - 1;
            }
            else
            {
                TileMatrix[x, y] = index;
            }
        }
    }

    public enum TileFormat
    {
        Text = 1,
        Binary = 2
    }
}
