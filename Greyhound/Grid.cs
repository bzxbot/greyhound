using System.Windows.Forms;

namespace Greyhound
{
    public partial class Grid : Control
    {
        private int NumOfBoxesPerLine = 5;
        private int NumOfBoxesPerColumn = 5;
        private int TotalNumberOfControls;

        public Grid()
        {
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            TotalNumberOfControls = NumOfBoxesPerLine * NumOfBoxesPerColumn;

            InitializeComponent();

            for (int i = 0; i < TotalNumberOfControls; i++)
            {
                this.Controls.Add(new PictureBox());
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            int pictureBoxWidth = pe.ClipRectangle.Width / NumOfBoxesPerLine;
            int pictureBoxHeight = pe.ClipRectangle.Height / NumOfBoxesPerColumn;

            for (int x = 0; x < this.Width; x += pictureBoxWidth)
            {
                for (int y = 0; y < this.Height; y += pictureBoxHeight)
                {
                    PictureBox pictureBox = this.Controls[x % NumOfBoxesPerLine + y % NumOfBoxesPerColumn] as PictureBox;

                    pictureBox.Width = pictureBoxWidth;
                    pictureBox.Height = pictureBoxHeight;

                    pictureBox.BorderStyle = BorderStyle.FixedSingle;

                    pictureBox.Left = x;
                    pictureBox.Top = y;
                }
            }

            base.OnPaint(pe);
        }
    }
}
