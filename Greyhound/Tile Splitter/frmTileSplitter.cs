using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Greyhound.TileSplitter
{
    public partial class Frm_TileSplitter : Form
    {
        #region Fields

        private List<Bitmap> splittedTiles = new List<Bitmap>();

        #endregion Fields

        #region Properties

        public Bitmap[] SplittedTiles
        {
            get { return this.splittedTiles.ToArray(); }
        }

        #endregion Properties

        #region Constructors

        public Frm_TileSplitter(Image img_Tiles)
        {
            InitializeComponent();
            this.pic_Tiles.Image = img_Tiles;
        }

        #endregion Constructors

        #region Private Events

        private void cmb_Split_Click(object sender, EventArgs e)
        {
            if (!validatePicSize())
            {
                return;
            }

            //sfd_Tiles.Filter = "Image Files(*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            //this.fbd_SaveTiles.Description = "Pasta onde salvar os tiles.";
            //if (this.fbd_SaveTiles.ShowDialog() == DialogResult.OK)
            //{
            this.resolveTiles(this.fbd_SaveTiles.SelectedPath);
            //}
        }

        private void lbl_MaskColor_Click(object sender, EventArgs e)
        {
            this.cd_SelectColor.Color = this.lbl_MaskColor.BackColor;

            if (this.cd_SelectColor.ShowDialog() == DialogResult.OK)
            {
                if (this.lbl_MaskColor.BackColor != this.cd_SelectColor.Color)
                {
                    this.lbl_MaskColor.BackColor = this.cd_SelectColor.Color;
                    this.pic_Tiles.Refresh();
                }
            }
        }

        private void nud_PixelsPerTile_ValueChanged(object sender, EventArgs e)
        {
            this.pic_Tiles.Refresh();
        }

        private void chBox_VerMascara_CheckedChanged(object sender, EventArgs e)
        {
            this.pic_Tiles.Refresh();
        }

        private void pic_Tiles_Paint(object sender, PaintEventArgs e)
        {
            if (this.pic_Tiles.Image == null || chBox_VerMascara.Checked == false)
            {
                return;
            }

            int pixelSize = (int)nud_PixelsPerTile.Value;

            int maxNumOfColumns = this.pic_Tiles.Image.Width / pixelSize;
            int maxNumOfLines = this.pic_Tiles.Image.Height / pixelSize;

            Graphics g = e.Graphics;
            Pen p = new Pen(lbl_MaskColor.BackColor);

            Point start;
            Point end;

            for (int colCounter = 0; colCounter <= maxNumOfColumns; colCounter++)
            {
                start = new Point(colCounter * pixelSize, 0);
                end = new Point(colCounter * pixelSize, maxNumOfLines * pixelSize);

                g.DrawLine(p, start, end);

                for (int lineCounter = 0; lineCounter <= maxNumOfLines; lineCounter++)
                {
                    start = new Point(0, lineCounter * pixelSize);
                    end = new Point(maxNumOfColumns * pixelSize, lineCounter * pixelSize);

                    g.DrawLine(p, start, end);
                }
            }
        }

        #endregion Private Events

        #region Private Methods

        private bool validatePicSize()
        {
            if (this.pic_Tiles.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if (this.pic_Tiles.Image.Width % nud_PixelsPerTile.Value != 0 ||
            //    this.pic_Tiles.Image.Height % nud_PixelsPerTile.Value != 0)
            //{
            //    MessageBox.Show("Tamanho da imagem nao confere com tamanho dos tiles", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            return true;
        }

        private void resolveTiles(string folderPath)
        {
            int totalCollumTiles = this.pic_Tiles.Image.Width / (int)nud_PixelsPerTile.Value;
            int totalLineTiles = this.pic_Tiles.Image.Height / (int)nud_PixelsPerTile.Value;
            int tileSize = (int)nud_PixelsPerTile.Value;

            Bitmap bmpImage = new Bitmap(this.pic_Tiles.Image);
            //Bitmap bmpCrop = bmpImage.Clone(cropArea,
            //bmpImage.PixelFormat);
            //return (Image)(bmpCrop);

            String name = folderPath + @"\Tile_{0:00}.png";
            int totalTileCounter = 0;

            for (int collumTileCounter = 0; collumTileCounter < totalCollumTiles; collumTileCounter++)
            {
                for (int lineTileCounter = 0; lineTileCounter < totalLineTiles; lineTileCounter++)
                {
                    totalTileCounter++;

                    this.splittedTiles.Add(bmpImage.Clone(new Rectangle(collumTileCounter * tileSize,
                                           lineTileCounter * tileSize,
                                           tileSize, tileSize),
                                           System.Drawing.Imaging.PixelFormat.Format24bppRgb));

                                                 //Save(String.Format(name, totalTileCounter), System.Drawing.Imaging.ImageFormat.Png);
                }
            }

            this.DialogResult = DialogResult.OK;
            //MessageBox.Show(String.Format("Criado {0} tiles no caminho {1}", totalTileCounter, folderPath));
        }

        #endregion Private Methods
    }
}
