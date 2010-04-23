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



        #endregion Private Methods

        #region Private Events

        private void Frm_TileEditor_Load(object sender, EventArgs e)
        {
            this.pic_Orig.Image = this.imgOrig;
        }

        private void cmb_GrayScale_Click(object sender, EventArgs e)
        {
            imgEdit = ImageFilters.ApplyGrayScale(imgOrig);
            this.pic_Edited.Image = imgEdit;
        }

        #endregion Private Events
    }
}
