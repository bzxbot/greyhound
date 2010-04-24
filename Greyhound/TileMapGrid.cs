﻿using System;
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
    public partial class TileMapGrid : UserControl
    {
        #region Private Fields

        Tile[,] tiles;

        private int SquareLines = 10;
        private int SquareColumns = 16;
        private int GridMargin = 5;

        private int _PenWidth = 1;

        #endregion Private Fields

        #region Properties

        public int GridThickness
        {
            get
            {
                return this._PenWidth;
            }

            set
            {
                if (this._PenWidth != value)
                {
                    this._PenWidth = value;
                    this.pnl_Grid.Refresh();
                }
            }
        }

        private Color _selectionColor = Color.Red;
        public Color SelectionColor
        {
            get { return this._selectionColor; }
            set
            {
                if (this._selectionColor != value)
                {
                    this._selectionColor = value;
                    this.DrawTiles(pnl_Grid.CreateGraphics());
                }
            }
        }

        private int _selectionThickness = 1;
        public int SelectionThickness
        {
            get { return this._selectionThickness; }
            set
            {
                if (this._selectionThickness != value)
                {
                    this._selectionThickness = value;
                    this.DrawTiles(pnl_Grid.CreateGraphics());
                }
            }
        }

        private Tile _selectedTile = null;
        public  Tile SelectedTile
        {
            get { return this._selectedTile; }
        }

        #endregion

        #region Constructors

        public TileMapGrid()
        {
            InitializeComponent();

            this.tiles = new Tile[SquareLines, SquareColumns];

            for (int i = 0; i < this.tiles.GetLength(0); i++)
            {
                for (int j = 0; j < this.tiles.GetLength(1); j++)
                {
                    tiles[i, j] = new Tile(i, j);
                }
            }
        }

        #endregion Constructors

        #region Private Events

        private void Grid3_Load(object sender, EventArgs e)
        {
            this.pnl_Grid.AllowDrop = true;
        }

        private void pnl_Grid_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics);
            DrawTiles(e.Graphics);
        }

        private void pnl_Grid_Resize(object sender, EventArgs e)
        {
            pnl_Grid.Refresh();
        }

        private void pnl_Grid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Tile t = GetTileByPosition(e.X, e.Y);

                if (t != null && t.Image != null)
                {
                    pnl_Grid.DoDragDrop(t, DragDropEffects.All);
                }
            }
        }

        private void pnl_Grid_DragEnter(object sender, DragEventArgs e)
        {
            //Testa se ctrl está sendo segurado


            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if (e.Data is object)
            {
                object o = e.Data.GetData(typeof(Tile));

                if (o is Tile)
                {
                    if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                    //if (e.KeyState == 9)
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                    else
                    {
                        e.Effect = DragDropEffects.Move;
                    }
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pnl_Grid_DragDrop(object sender, DragEventArgs e)
        {
            Point gridPoint = pnl_Grid.PointToClient(new Point(e.X, e.Y));

            Tile tileTarget = this.GetTileByPosition(gridPoint);

            if ((e.Data.GetDataPresent(DataFormats.Bitmap)) && tileTarget != null)
            {
                tileTarget.Image = (Bitmap)((Bitmap)(e.Data.GetData(DataFormats.Bitmap))).Clone();

                this.DrawTiles(pnl_Grid.CreateGraphics());
            }

            if (e.Data is object && tileTarget != null)
            {
                object o = e.Data.GetData(typeof(Tile));

                if (o is Tile)
                {
                    Tile tileSource = (Tile)o;

                    if (tileSource == null || tileSource.Image == null)
                    {
                        return;
                    }

                    if (tileSource == tileTarget)
                    {
                        return;
                    }

                    if (e.Effect == DragDropEffects.Copy)
                    {
                        tileTarget.Image = (Image)tileSource.Image.Clone();
                    }
                    else
                    {
                        tileTarget.Image = (Image)tileSource.Image.Clone();
                        tileSource.Image = null;
                    }

                    this.DrawTiles(pnl_Grid.CreateGraphics());
                }
            }
        }

        private void pnl_Grid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                this.FlipTile(this.GetTileByPosition(e.Location));
            }
        }

        private void cms_TileOptions_Opening(object sender, CancelEventArgs e)
        {
            Tile t = GetTileByPosition(pnl_Grid.PointToClient(new Point(cms_TileOptions.Left, cms_TileOptions.Top)));
            if (t == null || t.Image == null)
            {
                e.Cancel = true;
            }
        }

        private void tsmi_Selecionar_Click(object sender, EventArgs e)
        {
            this.SelectTile(GetTileByPosition(pnl_Grid.PointToClient(new Point(cms_TileOptions.Left, cms_TileOptions.Top))));
        }

        private void tsmi_Rotate_Click(object sender, EventArgs e)
        {
            this.FlipTile(GetTileByPosition(pnl_Grid.PointToClient(new Point(cms_TileOptions.Left, cms_TileOptions.Top))));
        }

        private void tsmi_Erase_Click(object sender, EventArgs e)
        {
            RemoveTileImage(GetTileByPosition(pnl_Grid.PointToClient(new Point(cms_TileOptions.Left, cms_TileOptions.Top))));
        }

        #endregion Private Events

        #region Private Methods

        private void DrawGrid(Graphics g)
        {
            Pen pen = new Pen(Brushes.Black);
            pen.Width = this.GridThickness;

            int maxHeight = this.pnl_Grid.Height / SquareLines;
            int maxWidth = this.pnl_Grid.Width / SquareColumns;
            int maxSize;
            int SquareSize;

            //Descobre se tamanho estora em altura ou largura
            if (maxHeight <= maxWidth)
            {
                maxSize = (this.pnl_Grid.Height) - (GridMargin / 2);
                SquareSize = (maxSize / SquareLines) - (int)pen.Width;
            }
            else
            {
                maxSize = (this.pnl_Grid.Width) - (GridMargin / 2);
                SquareSize = (maxSize / SquareColumns) - (int)pen.Width;
            }

            int topStart = (this.pnl_Grid.Height / 2) - ((SquareSize * SquareLines) / 2);
            int leftStart = (this.pnl_Grid.Width / 2) - ((SquareSize * SquareColumns) / 2);

            Point startPoint;
            Point endPoint;

            //Desenha a grid percorrento todas colunas e linhas
            for (int collumCounter = 0; collumCounter <= SquareColumns; collumCounter++)
            {
                //desenha linha da coluna
                startPoint = new Point(leftStart + (collumCounter * SquareSize), topStart);
                endPoint = new Point(leftStart + (collumCounter * SquareSize), topStart + (SquareSize * SquareLines));
                g.DrawLine(pen, startPoint, endPoint);

                for (int lineCounter = 0; lineCounter <= SquareLines; lineCounter++)
                {
                    //desenha linha da linha
                    startPoint = new Point(leftStart, topStart + (lineCounter * SquareSize));
                    endPoint = new Point(leftStart + (SquareSize * SquareColumns), topStart + (lineCounter * SquareSize));
                    g.DrawLine(pen, startPoint, endPoint);

                    //if (tiles[lineCounter, collumCounter].Image != null)
                    //{
                    //    Tile t = tiles[lineCounter, collumCounter];

                    //    //Image im = tiles[lineCounter, collumCounter].Image;
                    //    g.DrawImage(t.Image, leftStart + (collumCounter * SquareSize) + pen.Width, 
                    //                         topStart + (lineCounter * SquareSize) + pen.Width, SquareSize - pen.Width, SquareSize - pen.Width);
                    //}
                }
            }

            ////desenha ultimas linha das colunas
            //startPoint = new Point(leftStart + (SquareSize * SquareColumns), topStart);
            //endPoint = new Point(leftStart + (SquareSize * SquareColumns), topStart + (SquareSize * SquareLines));
            //g.DrawLine(pen, startPoint, endPoint);

            ////desenha ultima linha das linhas
            //startPoint = new Point(leftStart, topStart + (SquareLines * SquareSize));
            //endPoint = new Point(leftStart + (SquareSize * SquareColumns), topStart + (SquareLines * SquareSize));
            //g.DrawLine(pen, startPoint, endPoint);
        }

        private void DrawTiles(Graphics g)
        {
            SolidBrush sb = new SolidBrush(this.pnl_Grid.BackColor);
            Pen pen = new Pen(Brushes.Black);
            pen.Width = this.GridThickness;

            int maxHeight = this.pnl_Grid.Height / SquareLines;
            int maxWidth = this.pnl_Grid.Width / SquareColumns;
            int maxSize;
            int SquareSize;

            //Descobre se tamanho estora em altura ou largura
            if (maxHeight <= maxWidth)
            {
                maxSize = (this.pnl_Grid.Height) - (GridMargin / 2);
                SquareSize = (maxSize / SquareLines) - (int)pen.Width;
            }
            else
            {
                maxSize = (this.pnl_Grid.Width) - (GridMargin / 2);
                SquareSize = (maxSize / SquareColumns) - (int)pen.Width;
            }

            int topStart = (this.pnl_Grid.Height / 2) - ((SquareSize * SquareLines) / 2);
            int leftStart = (this.pnl_Grid.Width / 2) - ((SquareSize * SquareColumns) / 2);

            //Desenha a grid percorrento todas colunas e linhas
            for (int collumCounter = 0; collumCounter < SquareColumns; collumCounter++)
            {
                for (int lineCounter = 0; lineCounter < SquareLines; lineCounter++)
                {
                    if (tiles[lineCounter, collumCounter].Image != null)
                    {
                        Tile t = tiles[lineCounter, collumCounter];

                        //g.DrawRectangle(pen, leftStart + (collumCounter * SquareSize) + pen.Width,
                        //                     topStart + (lineCounter * SquareSize) + pen.Width,
                        //                     SquareSize - pen.Width, SquareSize - pen.Width);

                        g.DrawImage(t.Image, leftStart + (collumCounter * SquareSize) + pen.Width,
                                             topStart + (lineCounter * SquareSize) + pen.Width,
                                             SquareSize - pen.Width, SquareSize - pen.Width);

                        if (this._selectedTile != null && t == this._selectedTile)
                        {
                            float savePenWidth = pen.Width;
                            Color savedPenColo = pen.Color;

                            pen.Width = this.SelectionThickness;
                            pen.Color = this.SelectionColor;

                            g.DrawRectangle(pen, leftStart + (collumCounter * SquareSize) + savePenWidth + pen.Width / 2,
                                             topStart + (lineCounter * SquareSize) + savePenWidth + pen.Width / 2,
                                             SquareSize - (pen.Width + pen.Width / 2), SquareSize - (pen.Width + pen.Width / 2));

                            pen.Width = savePenWidth;
                            pen.Color = savedPenColo;
                        }
                    }
                    else
                    {
                        g.FillRectangle(sb, leftStart + (collumCounter * SquareSize) + pen.Width,
                                             topStart + (lineCounter * SquareSize) + pen.Width,
                                             SquareSize - pen.Width, SquareSize - pen.Width);
                    }
                }
            }
        }

        private Tile GetTileByPosition(int x, int y)
        {
            return GetTileByPosition(new Point(x, y));
        }

        private Tile GetTileByPosition(Point pos)
        {
            int lin;
            int col;

            Pen pen = new Pen(Brushes.Black);

            int maxHeight = this.pnl_Grid.Height / SquareLines;
            int maxWidth = this.pnl_Grid.Width / SquareColumns;
            int maxSize;
            int SquareSize;

            if (maxHeight <= maxWidth)
            {
                maxSize = (this.pnl_Grid.Height) - (GridMargin / 2);
                SquareSize = (maxSize / SquareLines) - (int)pen.Width;
            }
            else
            {
                maxSize = (this.pnl_Grid.Width) - (GridMargin / 2);
                SquareSize = (maxSize / SquareColumns) - (int)pen.Width;
            }

            int topStart = (this.pnl_Grid.Height / 2) - ((SquareSize * SquareLines) / 2);
            int leftStart = (this.pnl_Grid.Width / 2) - ((SquareSize * SquareColumns) / 2);


            //testa se esta em cima da linha ou fora da grid
            if ((pos.X - leftStart) % SquareSize == 0 || (pos.Y - topStart) % SquareSize == 0 ||
                (pos.X - leftStart) < 0 || (pos.Y - topStart) < 0 ||
                (pos.X - leftStart) > (SquareSize * SquareColumns) ||
                (pos.Y - topStart) > (SquareSize * SquareLines))
            {
                //ignora se sim
                return null;
            }

            col = (pos.X - leftStart) / SquareSize;
            lin = (pos.Y - topStart) / SquareSize;

            try
            {
                return this.tiles[lin, col];
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }

        }

        private void FlipTile(Tile t)
        {
            if (t != null && t.Image != null)
            {
                t.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                this.DrawTiles(pnl_Grid.CreateGraphics());
            }
        }

        private void SelectTile(Tile t)
        {
            if (t != null && t.Image != null)
            {
                this._selectedTile = t;
                this.DrawTiles(pnl_Grid.CreateGraphics());
            }
        }

        private void RemoveTileImage(Tile t)
        {
            if (t != null && t.Image != null)
            {
                if (t == this._selectedTile)
                {
                    this._selectedTile = null;
                }

                t.Image = null;
                this.DrawTiles(pnl_Grid.CreateGraphics());
            }
        }

        #endregion Private Methods

        private void pnl_Grid_MouseMove(object sender, MouseEventArgs e)
        {
            //lbl_GridPlace.Text = String.Format(" Panel: x:{0:00} y:{1:00}", e.X, e.Y);

            //int lin;
            //int col;

            //Pen pen = new Pen(Brushes.Black);

            //int maxHeight = this.pnl_Grid.Height / SquareLines;
            //int maxWidth = this.pnl_Grid.Width / SquareColumns;
            //int maxSize;
            //int SquareSize;

            //if (maxHeight <= maxWidth)
            //{
            //    maxSize = (this.pnl_Grid.Height) - (GridMargin / 2);
            //    SquareSize = (maxSize / SquareLines) - (int)pen.Width;
            //}
            //else
            //{
            //    maxSize = (this.pnl_Grid.Width) - (GridMargin / 2);
            //    SquareSize = (maxSize / SquareColumns) - (int)pen.Width;
            //}

            //int topStart = (this.pnl_Grid.Height / 2) - ((SquareSize * SquareLines) / 2);
            //int leftStart = (this.pnl_Grid.Width / 2) - ((SquareSize * SquareColumns) / 2);


            //if ((e.X - leftStart) % SquareSize == 0 || (e.Y - topStart) % SquareSize == 0 ||
            //    (e.X - leftStart) < 0 || (e.Y - topStart) < 0 ||
            //    (e.X - leftStart) > (SquareSize * SquareColumns) ||
            //    (e.Y - topStart) > (SquareSize * SquareLines))
            //{
            //    lin = col = -1;
            //    lbl_GridSquare.Text = String.Format("Square: L:{0:00} C:{1:00}", lin, col);
            //    return;
            //}

            //lin = (e.Y - topStart)/SquareSize;
            //col = (e.X - leftStart) / SquareSize;

            //lbl_GridSquare.Text = String.Format("Square: L:{0:00} C:{1:00}", lin, col);        

            //if (e.Button == MouseButtons.Left)
            //{
            //    //PictureBox picBox = (PictureBox)sender;

            //    //if (picBox.Image == null)
            //    //{
            //    //    return;
            //    //}

            //    Tile t = GetTileByPosition(e.X, e.Y);

            //    if (t != null && t.Image != null)
            //    {
            //        pnl_Grid.DoDragDrop(t.Image, DragDropEffects.All);
            //    }
            //}
        }
    }
}
