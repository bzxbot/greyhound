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
            ofd_Picture.Filter = "Image Files(*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";

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
            int tileSize = (int)nud_PixelsPerTile.Value;;

            Bitmap bmpImage = new Bitmap(this.pic_Tiles.Image);
            //Bitmap bmpCrop = bmpImage.Clone(cropArea,
            //bmpImage.PixelFormat);
            //return (Image)(bmpCrop);

            String name = folderPath+@"\Tile_{0:00}.png";
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
    }
}
