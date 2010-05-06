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
    public partial class TileMapGrid : UserControl
    {
        #region Private Fields

        public static int _MaxHeightWidth = 20;

        private Color _selectionColor = Color.Red;
        private Point _invalidPosition = new Point(-1, -1);

        private int _squareLines;
        private int _squareColumns;
        private int _gridMargin = 5;
        private int _penWidth = 1;
        private int _selectionThickness = 1;

        #endregion Private Fields

        #region Properties

        public TileMap TileMap { get; set; }

        public int GridThickness
        {
            get
            {
                return this._penWidth;
            }
            set
            {
                if (this._penWidth != value)
                {
                    this._penWidth = value;
                    this.pnl_Grid.Refresh();
                }
            }
        }

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

        #endregion

        #region Constructors

        public TileMapGrid()
            : this(10, 16, 32)
        {
        }

        public TileMapGrid(int heigh, int width, int tileSize)
        {
            this._squareColumns = width;
            this._squareLines = heigh;

            if (this._squareColumns > _MaxHeightWidth)
            {
                this._squareColumns = _MaxHeightWidth;
            }

            if (this._squareLines > _MaxHeightWidth)
            {
                this._squareLines = _MaxHeightWidth;
            }

            InitializeComponent();

            this.TileMap = new TileMap(_squareLines, _squareColumns, tileSize);
        }

        #endregion Constructors

        #region Private Events

        private void TileMapGrid_Load(object sender, EventArgs e)
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
                Point position = GetMatrixPosition(e.X, e.Y);

                if (position != _invalidPosition)
                {
                    pnl_Grid.DoDragDrop(position, DragDropEffects.All);
                }
            }
        }

        private void pnl_Grid_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if (e.Data is object && e.Data.GetData(typeof(Point)) is Point)
            {
                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.Move;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pnl_Grid_DragDrop(object sender, DragEventArgs e)
        {
            Point position = GetMatrixPosition(pnl_Grid.PointToClient(new Point(e.X, e.Y)));

            if (position == _invalidPosition)
            {
                return;
            }

            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                Tile tile = new Tile();

                tile.Bitmap = (Bitmap)((Bitmap)(e.Data.GetData(DataFormats.Bitmap))).Clone();

                TileMap.SetTile(position.X, position.Y, tile);
            }
            else if (e.Data is object && e.Data.GetData(typeof(Point)) is Point)
            {
                Point from = (Point)e.Data.GetData(typeof(Point));

                if (TileMap.HasTile(from.X, from.Y))
                {
                    Tile tile = TileMap.GetTile(from.X, from.Y);

                    if (e.Effect == DragDropEffects.Move)
                    {
                        TileMap.RemoveInUseTile(from.X, from.Y);
                    }

                    TileMap.SetTile(position.X, position.Y, tile);
                }
            }
            else
            {
                return;
            }

            this.DrawTiles(pnl_Grid.CreateGraphics());
        }

        private void pnl_Grid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                this.FlipTile(GetMatrixPosition(e.Location));
            }
        }

        private void cms_TileOptions_Opening(object sender, CancelEventArgs e)
        {
            Point position = GetMatrixPosition(pnl_Grid.PointToClient(new Point(cms_TileOptions.Left, cms_TileOptions.Top)));

            if (position == _invalidPosition || !TileMap.HasTile(position.X, position.Y))
            {
                e.Cancel = true;
            }
        }

        private void tsmi_Rotate_Click(object sender, EventArgs e)
        {
            this.FlipTile(GetMatrixPosition(pnl_Grid.PointToClient(new Point(cms_TileOptions.Left, cms_TileOptions.Top))));
        }

        private void tsmi_Erase_Click(object sender, EventArgs e)
        {
            Point position = GetMatrixPosition(pnl_Grid.PointToClient((new Point(cms_TileOptions.Left, cms_TileOptions.Top))));

            if (position == _invalidPosition)
            {
                return;
            }

            TileMap.RemoveTile(position.X, position.Y);

            DrawTiles(pnl_Grid.CreateGraphics());
        }

        #endregion Private Events

        #region Private Methods

        private void DrawGrid(Graphics g)
        {
            Pen pen = new Pen(Brushes.Black) { Width = this.GridThickness };

            int maxHeight = this.pnl_Grid.Height / _squareLines;
            int maxWidth = this.pnl_Grid.Width / _squareColumns;
            int maxSize;
            int squareSize;

            if (maxHeight <= maxWidth)
            {
                maxSize = (this.pnl_Grid.Height) - (_gridMargin / 2);
                squareSize = (maxSize / _squareLines) - (int)pen.Width;
            }
            else
            {
                maxSize = (this.pnl_Grid.Width) - (_gridMargin / 2);
                squareSize = (maxSize / _squareColumns) - (int)pen.Width;
            }

            int topStart = (this.pnl_Grid.Height / 2) - ((squareSize * _squareLines) / 2);
            int leftStart = (this.pnl_Grid.Width / 2) - ((squareSize * _squareColumns) / 2);

            Point startPoint;
            Point endPoint;

            for (int collumCounter = 0; collumCounter <= _squareColumns; collumCounter++)
            {
                // Coluna.
                startPoint = new Point(leftStart + (collumCounter * squareSize), topStart);
                endPoint = new Point(leftStart + (collumCounter * squareSize), topStart + (squareSize * _squareLines));
                g.DrawLine(pen, startPoint, endPoint);

                for (int lineCounter = 0; lineCounter <= _squareLines; lineCounter++)
                {
                    // Linha.
                    startPoint = new Point(leftStart, topStart + (lineCounter * squareSize));
                    endPoint = new Point(leftStart + (squareSize * _squareColumns), topStart + (lineCounter * squareSize));
                    g.DrawLine(pen, startPoint, endPoint);
                }
            }
        }

        private void DrawTiles(Graphics g)
        {
            SolidBrush sb = new SolidBrush(this.pnl_Grid.BackColor);

            Pen pen = new Pen(Brushes.Black) { Width = this.GridThickness };

            int maxHeight = this.pnl_Grid.Height / _squareLines;
            int maxWidth = this.pnl_Grid.Width / _squareColumns;
            int maxSize;
            int SquareSize;

            // Tamanho máximo entre altura e largura.
            if (maxHeight <= maxWidth)
            {
                maxSize = (this.pnl_Grid.Height) - (_gridMargin / 2);
                SquareSize = (maxSize / _squareLines) - (int)pen.Width;
            }
            else
            {
                maxSize = (this.pnl_Grid.Width) - (_gridMargin / 2);
                SquareSize = (maxSize / _squareColumns) - (int)pen.Width;
            }

            int topStart = (this.pnl_Grid.Height / 2) - ((SquareSize * _squareLines) / 2);
            int leftStart = (this.pnl_Grid.Width / 2) - ((SquareSize * _squareColumns) / 2);

            // Desenha o grid percorrento todas colunas e linhas.
            for (int collumCounter = 0; collumCounter < _squareColumns; collumCounter++)
            {
                for (int lineCounter = 0; lineCounter < _squareLines; lineCounter++)
                {
                    if (TileMap.HasTile(lineCounter, collumCounter))
                    {
                        Tile t = TileMap.GetTile(lineCounter, collumCounter);

                        g.DrawImage(t.Bitmap, leftStart + (collumCounter * SquareSize) + pen.Width,
                                             topStart + (lineCounter * SquareSize) + pen.Width,
                                             SquareSize - pen.Width, SquareSize - pen.Width);
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

        private Point GetMatrixPosition(int x, int y)
        {
            return GetMatrixPosition(new Point(x, y));
        }

        private Point GetMatrixPosition(Point pos)
        {
            int lin;
            int col;

            Pen pen = new Pen(Brushes.Black);

            int maxHeight = this.pnl_Grid.Height / _squareLines;
            int maxWidth = this.pnl_Grid.Width / _squareColumns;
            int maxSize;
            int SquareSize;

            if (maxHeight <= maxWidth)
            {
                maxSize = (this.pnl_Grid.Height) - (_gridMargin / 2);
                SquareSize = (maxSize / _squareLines) - (int)pen.Width;
            }
            else
            {
                maxSize = (this.pnl_Grid.Width) - (_gridMargin / 2);
                SquareSize = (maxSize / _squareColumns) - (int)pen.Width;
            }

            int topStart = (this.pnl_Grid.Height / 2) - ((SquareSize * _squareLines) / 2);
            int leftStart = (this.pnl_Grid.Width / 2) - ((SquareSize * _squareColumns) / 2);


            // Testa se é uma posição válida.
            if ((pos.X - leftStart) % SquareSize == 0 || (pos.Y - topStart) % SquareSize == 0 ||
                (pos.X - leftStart) < 0 || (pos.Y - topStart) < 0 ||
                (pos.X - leftStart) > (SquareSize * _squareColumns) ||
                (pos.Y - topStart) > (SquareSize * _squareLines))
            {
                return _invalidPosition;
            }

            col = (pos.X - leftStart) / SquareSize;
            lin = (pos.Y - topStart) / SquareSize;

            return new Point(lin, col);
        }

        private void FlipTile(Point position)
        {
            if (position != _invalidPosition && TileMap.HasTile(position.X, position.Y))
            {
                Tile tile = TileMap.GetTile(position.X, position.Y);

                Bitmap bitmap = new Bitmap(tile.Bitmap);

                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);

                TileMap.SetTile(position.X, position.Y, new Tile(bitmap));

                this.DrawTiles(pnl_Grid.CreateGraphics());
            }
        }

        #endregion Private Methods

        public void ReloadValues(int heigh, int width, int tileSize)
        {
            this._squareColumns = width;
            this._squareLines = heigh;

            if (this._squareColumns > _MaxHeightWidth)
            {
                this._squareColumns = _MaxHeightWidth;
            }

            if (this._squareLines > _MaxHeightWidth)
            {
                this._squareLines = _MaxHeightWidth;
            }

            this.TileMap = new TileMap(_squareLines, _squareColumns, tileSize);

            this.Refresh();
        }

        public void ReloadValues(TileMap tileMap)
        {
            this._squareColumns = tileMap.Columns;
            this._squareLines = tileMap.Lines;

            if (this._squareColumns > _MaxHeightWidth)
            {
                this._squareColumns = _MaxHeightWidth;
            }

            if (this._squareLines > _MaxHeightWidth)
            {
                this._squareLines = _MaxHeightWidth;
            }

            this.TileMap = tileMap;

            this.Refresh();
        }
    }
}
