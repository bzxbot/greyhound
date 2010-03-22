using System.Windows.Forms;
using System.Drawing;
using System;
using Greyhound.Properties;

namespace Greyhound
{
    public partial class Grid : Control
    {
        Tile[,] tiles = new Tile[5, 5];

        private int SquaresPerLine = 5;
        private int SquaresPerColumn = 5;
        private int Margin = 5;

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
            pnl_Grig.CreateGraphics();
            
            base.OnPaint(pe);
        }

        private void pnl_Grid_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Brushes.Black);

            float rectangleWidth = e.ClipRectangle.Width / SquaresPerLine - pen.Width;
            float rectangleHeight = e.ClipRectangle.Height / SquaresPerColumn - pen.Width;

            int i = 0;

            for (float y = 0; y < e.ClipRectangle.Height && i < SquaresPerColumn; y += rectangleHeight)
            {
                int j = 0;

                for (float x = 0; x < e.ClipRectangle.Width && j < SquaresPerLine; x += rectangleWidth)
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

        private void Grid_Resize(object sender, EventArgs e)
        {
            this.pnl_Grig.Refresh();
        }

        private void pnl_Grig_Resize(object sender, EventArgs e)
        {
            this.pnl_Grig.Refresh();
        }
    }
}
