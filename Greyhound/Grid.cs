﻿using System.Windows.Forms;
using System.Drawing;
using System;
using Greyhound.Properties;

namespace Greyhound
{
    public partial class Grid : Control
    {
        Tile[,] tiles = new Tile[5, 5];

        private int RectanglesPerLine = 5;
        private int RectanglesPerColumn = 5;

        public Grid()
        {
            InitializeComponent();

            for (int i = 0; i < Math.Sqrt(tiles.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(tiles.Length); j++)
                {
                    tiles[i, j] = new Tile(i, j);
                }
            }

            tiles[0, 0].Image = Resources.Chrysanthemum;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            panel1.CreateGraphics();
            
            base.OnPaint(pe);
        }

        void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Brushes.Black);

            float rectangleWidth = e.ClipRectangle.Width / RectanglesPerLine - pen.Width;
            float rectangleHeight = e.ClipRectangle.Height / RectanglesPerColumn - pen.Width;

            int i = 0;

            for (float y = 0; y < e.ClipRectangle.Height && i < RectanglesPerColumn; y += rectangleHeight)
            {
                int j = 0;

                for (float x = 0; x < e.ClipRectangle.Width && j < RectanglesPerLine; x += rectangleWidth)
                {
                    if (tiles[i, j].Image == null)
                    {
                        e.Graphics.DrawRectangle(pen, x, y, rectangleWidth, rectangleHeight);
                    }
                    else
                    {
                        e.Graphics.DrawImage(tiles[i, j].Image, x, y, rectangleWidth, rectangleHeight);
                    }

                    j++;
                }

                i++;
            }
        }

        private void Grid_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
