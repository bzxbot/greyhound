using System.Windows.Forms;

namespace Greyhound
{
    public partial class Grid : Control
    {
        private int NumOfBoxesPerLine = 5;
        private int NumOfBoxesPerColumn = 5;

        public Grid()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            int pictureBoxWidth = pe.ClipRectangle.Width / NumOfBoxesPerLine;
            int pictureBoxHeight = pe.ClipRectangle.Height / NumOfBoxesPerColumn;

            for (int x = 0; x < this.Width; x += pictureBoxWidth)
            {
                for (int y = 0; y < this.Height; y += pictureBoxHeight)
                {
                    PictureBox pictureBox = new PictureBox();

                    pictureBox.Width = pictureBoxWidth;
                    pictureBox.Height = pictureBoxHeight;

                    pictureBox.BorderStyle = BorderStyle.FixedSingle;

                    pictureBox.Left = x;
                    pictureBox.Top = y;

                    this.Controls.Add(pictureBox);
                }
            }
        }
    }
}
