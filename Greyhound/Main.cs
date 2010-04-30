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

        #region Private Methods

        private void LoadImages(Bitmap[] images)
        {
            //int margin = 5;
            //int LastPosition = 0;

            //for (int bmCounter = 0; bmCounter < images.Length; bmCounter++)
            //{
            //    PictureBox pic_Source = new PictureBox();
            //    pic_Source.Image = images[bmCounter];
            //    pic_Source.SizeMode = PictureBoxSizeMode.Zoom;

            //    pic_Source.Parent = pnl_Bottom;
            //    pic_Source.BorderStyle = BorderStyle.FixedSingle;
            //    pic_Source.MouseClick += new MouseEventHandler(pic_Source_MouseClick);
            //    pic_Source.MouseMove += new MouseEventHandler(pic_Source_MouseMove);

            //    pic_Source.Top = margin;
            //    pic_Source.Left = LastPosition + margin;

            //    pic_Source.Width = 32;
            //    pic_Source.Height = 32;

            //    LastPosition = pic_Source.Width + pic_Source.Left;
            //}
        }

        #endregion Private Methods

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
            ofdTMap.ShowDialog();

            if (!string.IsNullOrEmpty(ofdTMap.FileName))
            {
                try
                {
                    tileMapGrid.TileMap.Load(ofdTMap.FileName);

                    tileMapGrid.Refresh();

                    tileSetPanel.ClearImages();

                    foreach (Tile tile in tileMapGrid.TileMap.Tiles)
                    {
                        tileSetPanel.AddImage(tile.Bitmap);
                    }
                }
                catch (IOException ex)
                {
                    ErrorMessageBox.Show("Não foi possível ler o arquivo especificado. Verifique se o arquivo está acessível.", ex);
                }
                catch (Exception ex)
                {
                    ErrorMessageBox.Show("Ocorreu um erro na leitura do arquivo. Verifique se o arquivo tem um formato válido.", ex);
                }
            }
        }

        private void tsb_Save_Click(object sender, EventArgs e)
        {
            sfdTMap.ShowDialog();

            if (!string.IsNullOrEmpty(sfdTMap.FileName))
            {
                try
                {
                    tileMapGrid.TileMap.Save(sfdTMap.FileName);
                }
                catch (Exception ex)
                {
                    ErrorMessageBox.Show("Não foi possível salvar a imagem no local informado. Verifique o nome e o local do arquivo.", ex);
                }
            }
        }

        private void tsmi_openTileImage_Click(object sender, EventArgs e)
        {
            this.ofd_Tiles.Multiselect = false;
            this.ofd_Tiles.Title = "Abrir imagem com tiles.";
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
            {
                if (this.ofd_Tiles.ShowDialog() == DialogResult.OK)
                {
                    string[] files = this.ofd_Tiles.FileNames;
                    List<Image> images = new List<Image>();

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

        //private void pic_Source_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Middle && sender is PictureBox)
        //    {
        //        PictureBox picBox = (PictureBox)sender;

        //        if (picBox.Image == null)
        //        {
        //            return;
        //        }

        //        picBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        //        picBox.Refresh();
        //    }
        //}

        //private void pic_Source_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left && sender is PictureBox)
        //    {
        //        PictureBox picBox = (PictureBox)sender;

        //        if (picBox.Image == null)
        //        {
        //            return;
        //        }

        //        picBox.DoDragDrop(picBox.Image, DragDropEffects.All);
        //    }
        //}

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            int limitLocation = this.pnl_Fill.Top + this.pnl_Fill.MinimumSize.Height;

            if (this.splitter1.Top < limitLocation)
            {
                e.SplitY = limitLocation;
            }
        }

        #endregion Private Events
    }
}
