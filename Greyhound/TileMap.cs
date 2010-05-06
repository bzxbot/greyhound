using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Greyhound
{
    public class TileMap
    {
        private int[,] TileMatrix { get; set; }

        public int Lines { get; private set; }
        public int Columns { get; private set; }
        public int TileWidth { get; private set; }
        public int TileHeight { get; private set; }
        public int TileCount { get; private set; }
        public TileFormat TileFormat { get; private set; }
        public List<Tile> Tiles { get; private set; }

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
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            string[] split = line.Split(' ');

            Lines = int.Parse(split[0]);
            Columns = int.Parse(split[1]);

            TileMatrix = new int[Lines, Columns];

            for (int i = 0; i < Lines; i++)
            {
                line = sr.ReadLine();

                split = line.Split(' ');

                for (int j = 0; j < split.Length && j < Columns; j++)
                {
                    TileMatrix[i, j] = int.Parse(split[j]);
                }
            }

            line = sr.ReadLine();
            split = line.Split(' ');

            TileWidth = int.Parse(split[0]);
            TileHeight = int.Parse(split[1]);

            line = sr.ReadLine();
            split = line.Split(' ');

            TileCount = int.Parse(split[0]);
            TileFormat = (TileFormat)int.Parse(split[1]);

            Tiles = new List<Tile>();

            switch (TileFormat)
            {
                case TileFormat.Text:
                    LoadTextTiles(sr);
                    break;
                case TileFormat.Binary:
                    LoadBinaryTiles(sr);
                    break;
            }

            sr.Close();
        }

        public void LoadTextTiles(StreamReader sr)
        {
            string line = sr.ReadLine();
            string[] split = line.Split(' ');

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
        }

        public void LoadBinaryTiles(StreamReader sr)
        {
            BinaryReader br = new BinaryReader(sr.BaseStream);

            for (int i = 0; i < TileCount; i++)
            {
                Tile tile = new Tile();

                Bitmap bitmap = new Bitmap(TileWidth, TileHeight);

                for (int j = 0; j < TileHeight * TileWidth; j++)
                {
                    int r = br.ReadByte();
                    int g = br.ReadByte();
                    int b = br.ReadByte();

                    bitmap.SetPixel(j / TileWidth, j % TileHeight, Color.FromArgb(r, g, b));
                }

                tile.Bitmap = bitmap;

                Tiles.Add(tile);
            }
        }

        public void Save(string filePath)
        {
            this.Save(filePath, TileFormat.Text);
        }

        public void Save(string filePath, TileFormat format)
        {
            StreamWriter sw = new StreamWriter(filePath);

            sw.Write(this.Lines);
            sw.Write(" ");
            sw.WriteLine(this.Columns);

            for (int i = 0; i < this.Lines; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    sw.Write(this.TileMatrix[i, j]);
                    sw.Write(" ");
                }

                sw.WriteLine();
            }

            sw.Write(this.TileWidth);
            sw.Write(" ");
            sw.WriteLine(this.TileHeight);

            sw.Write(Tiles.Count);
            sw.Write(" ");
            sw.WriteLine((int)format);

            switch (format)
            {
                case TileFormat.Text:
                    this.SaveTextTiles(sw);
                    break;
                case TileFormat.Binary:
                    this.SaveBinaryTiles(sw);
                    break;
            }

            sw.Close();
        }

        public void SaveTextTiles(StreamWriter sw)
        {
            foreach (Tile tile in Tiles)
            {
                if (tile.Bitmap == null)
                    continue;

                for (int x = 0; x < this.TileWidth; x++)
                {
                    for (int y = 0; y < this.TileHeight; y++)
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
        }

        public void SaveBinaryTiles(StreamWriter sw)
        {
            BinaryWriter bw = new BinaryWriter(sw.BaseStream);

            foreach (Tile tile in Tiles)
            {
                if (tile.Bitmap == null)
                    continue;

                for (int x = 0; x < this.TileWidth; x++)
                {
                    for (int y = 0; y < this.TileHeight; y++)
                    {
                        Color color = tile.Bitmap.GetPixel(x, y);

                        bw.Write(color.R);
                        bw.Write(color.G);
                        bw.Write(color.B);
                    }
                }
            }

            bw.Close();
        }

        public void RemoveTile(int x, int y)
        {
            if (x < 0 || y < 0 || x > this.Lines || y > this.Columns)
                throw new ArgumentException();

            if (this.TileMatrix[x, y] == -1)
            {
                return;
            }

            int index = this.TileMatrix[x, y];

            bool inUse = false;

            for (int i = 0; i < this.Lines; i++)
            {
                if (inUse)
                {
                    break;
                }

                for (int j = 0; j < this.Columns; j++)
                {
                    if ((x != i || y != j) && this.TileMatrix[i, j] == this.TileMatrix[x, y])
                    {
                        inUse = true;

                        break;
                    }
                }
            }

            if (!inUse)
            {
                this.Tiles.RemoveAt(index);

                for (int i = 0; i < Lines; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (this.TileMatrix[i, j] > index)
                        {
                            this.TileMatrix[i, j]--;
                        }
                    }
                }
            }

            this.TileMatrix[x, y] = -1;
        }

        public void RemoveInUseTile(int x, int y)
        {
            if (x < 0 || y < 0 || x > this.Lines || y > this.Columns)
                throw new ArgumentException();

            this.TileMatrix[x, y] = -1;
        }

        public void SetTile(int x, int y, Tile tile)
        {
            if (x < 0 || y < 0 || x > this.Lines || y > this.Columns)
                throw new ArgumentException();

            int index = this.Tiles.FindIndex(t => t.ImageHash == tile.ImageHash);

            if (index == -1)
            {
                this.Tiles.Add(tile);

                if (this.TileMatrix[x, y] != -1)
                {
                    this.RemoveTile(x, y);
                }

                this.TileMatrix[x, y] = this.Tiles.Count - 1;
            }
            else
            {
                this.TileMatrix[x, y] = index;
            }
        }

        public bool HasTile(int x, int y)
        {
            if (x < 0 || y < 0 || x > this.Lines || y > this.Columns)
                throw new ArgumentException();

            return TileMatrix[x, y] != -1;
        }

        public Tile GetTile(int x, int y)
        {
            if (x < 0 || y < 0 || x > this.Lines || y > this.Columns)
                throw new ArgumentException();

            if (!this.HasTile(x, y))
                return null;
            else
                return this.Tiles[TileMatrix[x, y]];
        }
    }

    public enum TileFormat
    {
        Text = 1,
        Binary = 2
    }
}
