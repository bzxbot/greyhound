using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Greyhound.Tile_Editor
{
    public partial class Frm_TileEditor : Form
    {
        #region Fields

        private Image imgOrig;
        private Image imgEdit;

        #endregion Fields

        #region Properties

        public bool ReplaceImage
        {
            get { return !this.cb_SaveAsCopy.Checked; }
        }

        public Image EditedImage
        {
            get { return this.imgEdit; }
        }

        #endregion Properties

        #region Constructors

        public Frm_TileEditor(Image img)
        {
            InitializeComponent();

            this.imgOrig = img;
        }

        #endregion Constructors

        #region Private Mehtods

        private Image ApplyGrayScale(Image imgOrig)
        {
            Bitmap grayScale = new Bitmap(imgOrig);

            for (int x = 0; x < grayScale.Width; x++)
            {
                for (int y = 0; y < grayScale.Height; y++)
                {
                    Color pixel = grayScale.GetPixel(x, y);
                    byte grayedValue = (byte)(.299 * pixel.R + .587 * pixel.G + .114 * pixel.B);
                    grayScale.SetPixel(x, y, Color.FromArgb(grayedValue, grayedValue, grayedValue));
                }
            }

            return grayScale;
        }

        #endregion Private Methods

        #region Private Events

        private void Frm_TileEditor_Load(object sender, EventArgs e)
        {
            this.pic_Orig.Image = this.imgOrig;
        }

        private void cmb_GrayScale_Click(object sender, EventArgs e)
        {
            imgEdit = this.ApplyGrayScale(imgOrig);
            this.pic_Edited.Image = imgEdit;
        }

        #endregion Private Events
    }
}
