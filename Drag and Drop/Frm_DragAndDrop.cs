using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drag_and_Drop
{
    public partial class Frm_DragAndDrop : Form
    {
        #region Constructors

        public Frm_DragAndDrop()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Private Events

        private void Frm_DragAndDrop_Load(object sender, EventArgs e)
        {
            this.pic_Target.AllowDrop = true;
        }

        private void pic_Target_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pic_Target_DragDrop(object sender, DragEventArgs e)
        {
            if ((e.Data.GetDataPresent(DataFormats.Bitmap)))
            {
                this.pic_Target.Image = (Bitmap)(e.Data.GetData(DataFormats.Bitmap)); 
            }
        }

        private void pic_Source_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.pic_Source.DoDragDrop(this.pic_Source.Image, DragDropEffects.All);
            }
        }

        #endregion Private Events
    }
}
