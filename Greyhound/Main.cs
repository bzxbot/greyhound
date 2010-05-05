using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Greyhound.Properties;
using Greyhound.Tile_Editor;
using Greyhound.TileSplitter;
using PNMReader;

namespace Greyhound
{
    public partial class Main : Form
    {
        #region Contructors

        public Main()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Private Events

        private void Main_Load(object sender, EventArgs e)
        {
            Bitmap[] images = new Bitmap[] { Resources.Tile_01, Resources.Tile_02, Resources.Tile_03, 
                                             Resources.Tile_04, Resources.Tile_05, Resources.Tile_06,
                                             Resources.Tile_07, Resources.Tile_08, Resources.Tile_09,
                                             Resources.Tile_10, Resources.Tile_11, Resources.Tile_12,
                                             Resources.Tile_13, Resources.Tile_14, Resources.Tile_15,
                                             Resources.Tile_16, Resources.Tile_17, Resources.Tile_18,
                                             Resources.Tile_19, Resources.Tile_20, Resources.Tile_21,
                                             Resources.Tile_22, Resources.Tile_23, Resources.Tile_24 };

            this.tileSetPanel.AddImages(images);
        }

        private void tsb_New_Click(object sender, EventArgs e)
        {
            Frm_NewTileMap tileMapInstance = new Frm_NewTileMap();

            if (tileMapInstance.ShowDialog() == DialogResult.OK)
            {
                this.tileMapGrid.ReloadValues(tileMapInstance.TileMapWidth,
                                                   tileMapInstance.TileMapHeight,
                                                   tileMapInstance.TileImageSize);
            }
        }

        private void tsb_Open_Click(object sender, EventArgs e)
        {
            if (ofdTMap.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofdTMap.FileName))
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
            if (sfdTMap.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfdTMap.FileName))
            {
                try
                {
                    tileMapGrid.TileMap.Save(sfdTMap.FileName);
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
                FileInfo fInfo = new FileInfo(this.ofd_Tiles.FileName);

                try
                {
                    if (fInfo.Extension.ToLower() == "pnm")
                    {
                        PPMReader ppmReader = new PPMReader();
                        image = ppmReader.GetImage(fInfo.FullName);
                    }
                    else
                    {
                        image = Image.FromFile(fInfo.FullName);
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessageBox.Show(String.Format("Erro ao carregar imagem {0}", fInfo.FullName), ex);
                    return;
                }

                Frm_TileSplitter tileSplitter = new Frm_TileSplitter(image);

                if (tileSplitter.ShowDialog() == DialogResult.OK)
                {
                    this.tileSetPanel.AddImages(tileSplitter.SplittedTiles);
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
                    FileInfo fInfo = new FileInfo(file);

                    try
                    {
                        if (fInfo.Extension.ToLower() == ".ppm")
                        {
                            PPMReader ppmReader = new PPMReader();
                            images.Add(ppmReader.GetImage(fInfo.FullName));
                        }
                        else
                        {
                            images.Add(Image.FromFile(fInfo.FullName));
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorMessageBox.Show(String.Format("Erro ao carregar imagem {0}", fInfo.FullName), ex);
                    }
                }

                this.tileSetPanel.AddImages(images.ToArray());
            }
        }

        private void tsb_EditTile_Click(object sender, EventArgs e)
        {
            if (this.tileSetPanel.SelectedPic != null)
            {
                Frm_TileEditor frm_TileEditor = new Frm_TileEditor(this.tileSetPanel.SelectedPic.Image);

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

    }
}
