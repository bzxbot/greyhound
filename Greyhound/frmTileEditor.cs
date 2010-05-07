using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Greyhound.TileEditor
{
    public partial class frmTileEditor : Form
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

        public frmTileEditor(Image img)
        {
            InitializeComponent();

            this.imgOrig = img;
        }

        #endregion Constructors

        #region Private Events

        private void Frm_TileEditor_Load(object sender, EventArgs e)
        {
            this.pic_Orig.Image = this.imgOrig;
        }

        private void tsmi_GrayScale_Click(object sender, EventArgs e)
        {
            imgEdit = ImageProcessing.ApplyGrayScale(imgOrig);
            this.pic_Edited.Image = imgEdit;
        }

        private void tsmi_Sepia_Click(object sender, EventArgs e)
        {
            imgEdit = ImageProcessing.ApplySepia(imgOrig);
            this.pic_Edited.Image = imgEdit;
        }

        private void tsmi_InvertColors_Click(object sender, EventArgs e)
        {
            imgEdit = ImageProcessing.ApplyInvertColor(imgOrig);
            this.pic_Edited.Image = imgEdit;
        }

        private void tsmi_ChangeHue_Click(object sender, EventArgs e)
        {
            if (this.cd_SelectColor.ShowDialog() == DialogResult.OK)
            {
                imgEdit = ImageProcessing.ChangeHue(imgOrig, cd_SelectColor.Color);
                this.pic_Edited.Image = imgEdit;
            }
        }

        #endregion Private Events
    }
}
