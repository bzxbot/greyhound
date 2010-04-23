using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Split_Tiles
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Private Events

        private void tsmi_Abrir_Click(object sender, EventArgs e)
        {
            ofd_Picture.Filter = "Image Files(*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG;*.PNM";

            if (ofd_Picture.ShowDialog() == DialogResult.OK)
            {
                this.pic_Tiles.Load(ofd_Picture.FileName);
            }
        }

        private void cmb_Separar_Click(object sender, EventArgs e)
        {
            if (!validatePicSize())
            {
                return;
            }

            //sfd_Tiles.Filter = "Image Files(*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            this.fbd_SaveTiles.Description = "Pasta onde salvar os tiles.";
            if (this.fbd_SaveTiles.ShowDialog() == DialogResult.OK)
            {
                resolveTiles(this.fbd_SaveTiles.SelectedPath);
            }
        }

        private void lbl_MaskColor_DoubleClick(object sender, EventArgs e)
        {
            this.cd_SelectColor.Color = this.lbl_MaskColor.BackColor;

            if (this.cd_SelectColor.ShowDialog() == DialogResult.OK)
            {
                this.lbl_MaskColor.BackColor = this.cd_SelectColor.Color;
            }
        }

        #endregion Private Events

        #region Private Mehtods

        private bool validatePicSize()
        {
            if (this.pic_Tiles.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (this.pic_Tiles.Image.Width % nud_PixelsPerTile.Value != 0 ||
                this.pic_Tiles.Image.Height % nud_PixelsPerTile.Value != 0)
            {
                MessageBox.Show("Tamanho da imagem nao confere com tamanho dos tiles", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void resolveTiles(string folderPath)
        {
            int totalCollumTiles = this.pic_Tiles.Image.Width / (int)nud_PixelsPerTile.Value;
            int totalLineTiles = this.pic_Tiles.Image.Height / (int)nud_PixelsPerTile.Value;
            int tileSize = (int)nud_PixelsPerTile.Value; ;

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
                    bmpImage.Clone(new Rectangle(collumTileCounter * tileSize,
                                                 lineTileCounter * tileSize,
                                                 tileSize, tileSize),
                                                 System.Drawing.Imaging.PixelFormat.Format24bppRgb).
                                                 Save(String.Format(name, totalTileCounter), System.Drawing.Imaging.ImageFormat.Png);
                }
            }

            MessageBox.Show(String.Format("Criado {0} tiles no caminho {1}", totalTileCounter, folderPath));
        }

        #endregion Private Methods

        private void cmb_ShowMask_Click(object sender, EventArgs e)
        {
            if (this.pic_Tiles.Image == null)
            {
                return;
            }

            int pixelSize = (int)nud_PixelsPerTile.Value;

            int maxNumOfColumns = this.pic_Tiles.Image.Width / pixelSize;
            int maxNumOfLines = this.pic_Tiles.Image.Height / pixelSize;

            Graphics g = this.pic_Tiles.CreateGraphics();
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


    }
}
