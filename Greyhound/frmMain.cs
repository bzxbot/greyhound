namespace Greyhound
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Greyhound.Properties;
    using Greyhound.Tile_Editor;
    using Greyhound.TileSplitter;

    public partial class frmMain : Form
    {
        #region Contructors

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Events

        private void Main_Load(object sender, EventArgs e)
        {
            Bitmap[] images = new Bitmap[] 
            { 
                Resources.Tile_01, Resources.Tile_02, Resources.Tile_03, 
                Resources.Tile_04, Resources.Tile_05, Resources.Tile_06,
                Resources.Tile_07, Resources.Tile_08, Resources.Tile_09,
                Resources.Tile_10, Resources.Tile_11, Resources.Tile_12,
                Resources.Tile_13, Resources.Tile_14, Resources.Tile_15,
                Resources.Tile_16, Resources.Tile_17, Resources.Tile_18,
                Resources.Tile_19, Resources.Tile_20, Resources.Tile_21,
                Resources.Tile_22, Resources.Tile_23, Resources.Tile_24 
            };

            this.tileSetPanel.AddImages(images);
        }

        private void tsb_New_Click(object sender, EventArgs e)
        {
            frmNewTileMap tileMapInstance = new frmNewTileMap(this.tileMapGrid.SquareColumns,
                                                              this.tileMapGrid.SquareLines,
                                                              this.tileMapGrid.TileMap.TileWidth);

            if (tileMapInstance.ShowDialog() == DialogResult.OK)
            {
                this.tileMapGrid.ReloadValues(tileMapInstance.TileMapWidth,
                                                   tileMapInstance.TileMapHeight,
                                                   tileMapInstance.TileImageSize);

                this.tileSetPanel.ClearImages();
            }
        }

        private void tsb_Open_Click(object sender, EventArgs e)
        {
            if (this.ofdTMap.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofdTMap.FileName))
            {
                try
                {
                    TileMap tileMap = new TileMap(ofdTMap.FileName);

                    this.tileMapGrid.ReloadValues(tileMap);

                    tileSetPanel.ClearImages();

                    foreach (Tile tile in tileMapGrid.TileMap.Tiles)
                    {
                        tileSetPanel.AddImage(tile.Bitmap);
                    }
                }
                catch (IOException ex)
                {
                    ErrorMessageBox.Show("Não foi possível ler o arquivo especificado, verifique se o arquivo está acessível.", ex);
                }
                catch (Exception ex)
                {
                    ErrorMessageBox.Show("Ocorreu um erro ao abrir o arquivo, verifique o formato do arquivo.", ex);
                }
            }
        }

        private void tsb_Save_Click(object sender, EventArgs e)
        {
            if (this.sfdTMap.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfdTMap.FileName))
            {
                try
                {
                    if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                    {

                    }
                    else
                    {
                        tileMapGrid.TileMap.Save(sfdTMap.FileName);
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessageBox.Show("Não foi possível salvar a imagem no local informado, verifique o nome e o local do arquivo.", ex);
                }
            }
        }

        private void tsmi_openTileImage_Click(object sender, EventArgs e)
        {
            this.ofd_Tiles.Multiselect = false;
            this.ofd_Tiles.Title = "Abrir imagem com tiles";

            Image image = null;

            if (this.ofd_Tiles.ShowDialog() == DialogResult.OK)
            {
                image = this.OpenImage(ofd_Tiles.FileName, false);

                if (image != null)
                {
                    Frm_TileSplitter tileSplitter = new Frm_TileSplitter(image);

                    if (tileSplitter.ShowDialog() == DialogResult.OK)
                    {
                        foreach (Bitmap bitmap in tileSplitter.SplittedTiles)
                        {
                            this.tileSetPanel.AddImage(ResizeBitmap(bitmap, tileMapGrid.TileMap.TileWidth, tileMapGrid.TileMap.TileHeight));
                        }
                    }
                }
            }
        }

        private void tsmi_OpenTile_Click(object sender, EventArgs e)
        {
            this.ofd_Tiles.Multiselect = true;
            this.ofd_Tiles.Title = "Abrir tile(s)";

            if (this.ofd_Tiles.ShowDialog() == DialogResult.OK)
            {
                List<Image> images = new List<Image>();

                string[] files = this.ofd_Tiles.FileNames;

                foreach (string file in files)
                {
                    Bitmap bitmap = this.OpenImage(file, true);

                    images.Add(bitmap);
                }

                this.tileSetPanel.AddImages(images.ToArray());
            }
        }

        private void tsb_EditTile_Click(object sender, EventArgs e)
        {
            if (this.tileSetPanel.SelectedPic != null)
            {
                frmTileEditor frm_TileEditor = new frmTileEditor(this.tileSetPanel.SelectedPic.Image);

                if (frm_TileEditor.ShowDialog() == DialogResult.OK)
                {
                    if (frm_TileEditor.EditedImage != null)
                    {
                        if (frm_TileEditor.ReplaceImage)
                        {
                            this.tileSetPanel.SelectedPic.Image = frm_TileEditor.EditedImage;
                            this.tileSetPanel.SelectedPic.Refresh();
                        }
                        else
                        {
                            this.tileSetPanel.AddImage(frm_TileEditor.EditedImage);
                        }
                    }
                }
            }
        }

        private void splTileSetGrid_SplitterMoved(object sender, SplitterEventArgs e)
        {
            int limitLocation = this.pnl_Fill.Top + this.pnl_Fill.MinimumSize.Height;

            if (this.splTileSetGrid.Top < limitLocation)
            {
                e.SplitY = limitLocation;
            }
        }

        #endregion Private Events

        #region Methods

        private Bitmap OpenImage(string filePath, bool resizeImage)
        {
            FileInfo fInfo = new FileInfo(filePath);

            try
            {
                string fileExtension = fInfo.Extension.ToLower();

                if (fileExtension == ".pbm" || fileExtension == ".pgm" || fileExtension == ".ppm")
                {
                    Image image = new PNMReader().ReadImage(fInfo.FullName);

                    if (resizeImage)
                    {
                        return ResizeBitmap((Bitmap)image, tileMapGrid.TileMap.TileWidth, tileMapGrid.TileMap.TileHeight);
                    }
                    else
                    {
                        return (Bitmap)image;
                    }
                }
                else
                {
                    if (resizeImage)
                    {
                        return ResizeBitmap((Bitmap)Image.FromFile(fInfo.FullName), tileMapGrid.TileMap.TileWidth, tileMapGrid.TileMap.TileHeight);
                    }
                    else
                    {
                        return (Bitmap)Image.FromFile(fInfo.FullName);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(String.Format("Erro ao carregar imagem {0}", fInfo.FullName), ex);
            }

            return null;
        }

        private Bitmap ResizeBitmap(Bitmap bitmap, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.DrawImage(bitmap, 0, 0, width, height);
            }

            return result;
        }

        #endregion
    }
}
