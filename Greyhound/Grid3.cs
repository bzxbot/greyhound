using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Greyhound.Properties;

namespace Greyhound
{
    public partial class Grid3 : UserControl
    {
        #region Private Fields

        Tile[,] tiles = new Tile[5, 5];

        private int SquaresPerLine = 10;
        private int SquaresPerColumn = 16;
        private int GridMargin = 5;

        #endregion Private Fields

        #region Constructors

        public Grid3()
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

        #endregion Constructors

        #region Private Events

        private void pnl_Grid_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics);
        }

        private void pnl_Grid_Resize(object sender, EventArgs e)
        {
            pnl_Grid.Refresh();
        }

        #endregion Private Events

        #region Private Methods

        private void DrawGrid(Graphics g)
        {
            Pen pen = new Pen(Brushes.Black);

            int maxHeight = this.pnl_Grid.Height / SquaresPerLine;
            int maxWidth = this.pnl_Grid.Width / SquaresPerColumn;
            int maxSize;
            int SquareSize;
            
            if (maxHeight <= maxWidth)
            {
                maxSize = (this.pnl_Grid.Height) - (GridMargin / 2);
                SquareSize = (maxSize / SquaresPerLine) - (int)pen.Width;
            }
            else
            {
                maxSize = (this.pnl_Grid.Width) - (GridMargin / 2);
                SquareSize = (maxSize / SquaresPerColumn) - (int)pen.Width;
            }

            int topStart = (this.pnl_Grid.Height / 2) - ((SquareSize*SquaresPerLine) / 2);
            int leftStart = (this.pnl_Grid.Width / 2) - ((SquareSize * SquaresPerColumn) / 2);            

            Point startPoint;
            Point endPoint;

            for (int collumCounter = 0; collumCounter < SquaresPerColumn; collumCounter++)
            {
                //desenha linha da coluna
                startPoint = new Point(leftStart + (collumCounter * SquareSize), topStart);
                endPoint = new Point(leftStart + (collumCounter * SquareSize), topStart + (SquareSize * SquaresPerLine));
                g.DrawLine(pen, startPoint, endPoint);

                for (int lineCounter = 0; lineCounter < SquaresPerLine; lineCounter++)
                {
                    //desenha linha da linha
                    startPoint = new Point(leftStart, topStart + (lineCounter * SquareSize));
                    endPoint = new Point(leftStart + (SquareSize * SquaresPerColumn), topStart + (lineCounter * SquareSize));
                    g.DrawLine(pen, startPoint, endPoint);
                }
            }

            //desenha ultimas linha das colunas
            startPoint = new Point(leftStart + (SquareSize * SquaresPerColumn), topStart);
            endPoint = new Point(leftStart + (SquareSize * SquaresPerColumn), topStart + (SquareSize * SquaresPerLine));
            g.DrawLine(pen, startPoint, endPoint);

            //desenha ultima linha das linhas
            startPoint = new Point(leftStart, topStart + (SquaresPerLine * SquareSize));
            endPoint = new Point(leftStart + (SquareSize * SquaresPerColumn), topStart + (SquaresPerLine * SquareSize));
            g.DrawLine(pen, startPoint, endPoint);
        }

        #endregion Private Methods
    }
}
