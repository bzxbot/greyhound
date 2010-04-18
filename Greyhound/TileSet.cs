using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Greyhound
{
    public partial class TileSet : UserControl
    {
        #region Constructors

        public TileSet()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        [Category("Appearance")]
        [Description("Margin size between tiles.")]
        public Int16 TileMargin { get; set; }

        #endregion

        #region Private Events

        private void tile_Source_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle && sender is PictureBox)
            {
                PictureBox picBox = (PictureBox)sender;

                if (picBox.Image == null)
                {
                    return;
                }

                picBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                picBox.Refresh();
            }
        }

        private void tile_Source_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && sender is PictureBox)
            {
                PictureBox picBox = (PictureBox)sender;

                if (picBox.Image == null)
                {
                    return;
                }

                picBox.DoDragDrop(picBox.Image, DragDropEffects.All);
            }
        }

        private void flpnl_Tiles_MouseEnter(object sender, EventArgs e)
        {
            this.flpnl_Tiles.Select();
        }

        private void tsmi_Apagar_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem myItem = (ToolStripMenuItem)sender;
            ContextMenuStrip theStrip = (ContextMenuStrip)myItem.Owner;
                       
            if (theStrip.SourceControl is PictureBox)
            {
                this.flpnl_Tiles.Controls.Remove((PictureBox)theStrip.SourceControl);
            }
        }

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        public void ClearImages()
        {
        }

        public void AddImage(Image image)
        {
            PictureBox pic_Source = new PictureBox();
            pic_Source.Image = image;
            pic_Source.SizeMode = PictureBoxSizeMode.Zoom;

            //pic_Source.Parent = pnl_Tiles;
            pic_Source.BorderStyle = BorderStyle.FixedSingle;
            pic_Source.MouseClick += new MouseEventHandler(tile_Source_MouseClick);
            pic_Source.MouseMove += new MouseEventHandler(tile_Source_MouseMove);
            pic_Source.ContextMenuStrip = this.cms_TileOptions;

            pic_Source.Margin = new Padding(this.TileMargin);

            pic_Source.Width = 32;
            pic_Source.Height = 32;

            this.flpnl_Tiles.Controls.Add(pic_Source);
        }

        public void AddImages(Image[] images)
        {
            foreach (Bitmap image in images)
            {
                this.AddImage(image);
            }


            //int LastPosition = 0;

            //for (int bmCounter = 0; bmCounter < images.Length; bmCounter++)
            //{
            //    PictureBox pic_Source = new PictureBox();
            //    pic_Source.Image = images[bmCounter];
            //    pic_Source.SizeMode = PictureBoxSizeMode.Zoom;

            //    pic_Source.Parent = pnl_Tiles;
            //    pic_Source.BorderStyle = BorderStyle.FixedSingle;
            //    pic_Source.MouseClick += new MouseEventHandler(tile_Source_MouseClick);
            //    pic_Source.MouseMove += new MouseEventHandler(tile_Source_MouseMove);

            //    pic_Source.Top = margin;
            //    pic_Source.Left = LastPosition + margin;

            //    pic_Source.Width = 32;
            //    pic_Source.Height = 32;

            //    LastPosition = pic_Source.Width + pic_Source.Left;
            //}
        }

        #endregion
    }
}
