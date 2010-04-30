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
    public partial class TileSetPanel : UserControl
    {
        #region Constructors

        public TileSetPanel()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        [Category("Appearance")]
        [Description("Margin size between tiles.")]
        public Int16 TileMargin { get; set; }

        private Color _selectedColor = Color.Red;
        public Color SelectedColor
        {
            get { return this._selectedColor;}
            set
            {
                if (this._selectedColor != value)
                {
                    this._selectedColor = value;

                    if (this._selectedPic != null)
                    {
                        this._selectedPic.BackColor = this._selectedColor;
                    }
                }                
            }
        }

        private PictureBox _selectedPic = null;
        public PictureBox SelectedPic
        {
            get
            {
                return this._selectedPic;
            }
        }

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

            if (e.Button == MouseButtons.Left && sender is PictureBox)
            {
                PictureBox lastSelected = this._selectedPic;

                PictureBox picBox = (PictureBox)sender;
                this._selectedPic = picBox;
                picBox.Refresh();

                if (lastSelected != null)
                {
                    lastSelected.Refresh();
                }
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

        private void tile_Source_Paint(object sender, PaintEventArgs e)
        {
            if (sender is PictureBox && ((PictureBox)sender) == this._selectedPic)
            {
                PictureBox picBox = (PictureBox) sender;

                Pen pen = new Pen(new SolidBrush(this._selectedColor));
                pen.Width = 2;

                e.Graphics.DrawRectangle(pen, 0, 0, picBox.Width, picBox.Height);
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
            flpnl_Tiles.Controls.Clear();
        }

        public void AddImage(Image image)
        {
            PictureBox pic_Source = new PictureBox();
            pic_Source.Image = image;
            pic_Source.SizeMode = PictureBoxSizeMode.Zoom;

            //pic_Source.Parent = pnl_Tiles;
            //pic_Source.BorderStyle = BorderStyle.FixedSingle;
            pic_Source.BackColor = Color.Black;
            pic_Source.MouseClick += new MouseEventHandler(tile_Source_MouseClick);
            pic_Source.MouseMove += new MouseEventHandler(tile_Source_MouseMove);
            pic_Source.Paint += new PaintEventHandler(tile_Source_Paint);
            pic_Source.ContextMenuStrip = this.cms_TileOptions;

            pic_Source.Margin = new Padding(this.TileMargin);

            pic_Source.Width = 48;
            pic_Source.Height = 48;

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
