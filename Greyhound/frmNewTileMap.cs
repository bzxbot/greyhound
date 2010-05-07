using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Greyhound
{
    public partial class frmNewTileMap : Form
    {
        #region Properties

        public int TileMapWidth
        {
            get { return (int)nud_Width.Value; }
        }

        public int TileMapHeight
        {
            get { return (int)nud_Height.Value; }
        }

        public int TileImageSize
        {
            get { return (int)nud_TileSize.Value; }
        }

        #endregion Properties

        #region Constructors

        public frmNewTileMap(): this(16,10,32)
        {
            
        }

        public frmNewTileMap(int columns, int lines, int size)
        {
            InitializeComponent();

            this.nud_Width.Value = columns;
            this.nud_Height.Value = lines;
            this.nud_TileSize.Value = size;            
        }

        #endregion Constructors

        #region Private Events

        private void Frm_NewTileMap_Load(object sender, EventArgs e)
        {
        }

        #endregion Private Events
    }
}
