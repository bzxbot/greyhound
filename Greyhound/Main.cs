using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Greyhound.Properties;

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
            int margin = 5;
            int LastPosition = 0;

            for (int bmCounter = 0; bmCounter < images.Length; bmCounter++)
            {
                PictureBox pic_Source = new PictureBox();
                pic_Source.Image = images[bmCounter];
                pic_Source.SizeMode = PictureBoxSizeMode.Zoom;

                pic_Source.Parent = pnl_Bottom;
                pic_Source.BorderStyle = BorderStyle.FixedSingle;
                pic_Source.MouseClick += new MouseEventHandler(pic_Source_MouseClick);
                pic_Source.MouseMove += new MouseEventHandler(pic_Source_MouseMove);

                pic_Source.Top = margin;
                pic_Source.Left = LastPosition + margin;

                pic_Source.Width = 32;
                pic_Source.Height = 32;

                LastPosition = pic_Source.Width + pic_Source.Left;
            }
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

            LoadImages(images);
        }

        private void pic_Source_MouseClick(object sender, MouseEventArgs e)
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

        private void pic_Source_MouseMove(object sender, MouseEventArgs e)
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

        #endregion Private Events
    }
}
