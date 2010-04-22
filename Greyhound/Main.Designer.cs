namespace Greyhound
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ts_Menu = new System.Windows.Forms.ToolStrip();
            this.tsb_New = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_OpenTiles = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_OpenTile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_OpenTileImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_EditTile = new System.Windows.Forms.ToolStripButton();
            this.pnl_Fill = new System.Windows.Forms.Panel();
            this.ofd_Tiles = new System.Windows.Forms.OpenFileDialog();
            this.TileMap = new Greyhound.Grid3();
            this.TileSet = new Greyhound.TileSet();
            this.ts_Menu.SuspendLayout();
            this.pnl_Fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 353);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(753, 4);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // ts_Menu
            // 
            this.ts_Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_New,
            this.toolStripSeparator1,
            this.tsb_Open,
            this.toolStripSeparator2,
            this.tsb_Save,
            this.toolStripSeparator3,
            this.tsb_OpenTiles,
            this.toolStripSeparator4,
            this.tsb_EditTile});
            this.ts_Menu.Location = new System.Drawing.Point(0, 0);
            this.ts_Menu.Name = "ts_Menu";
            this.ts_Menu.Size = new System.Drawing.Size(753, 39);
            this.ts_Menu.TabIndex = 6;
            this.ts_Menu.Text = "toolStrip1";
            // 
            // tsb_New
            // 
            this.tsb_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_New.Image = ((System.Drawing.Image)(resources.GetObject("tsb_New.Image")));
            this.tsb_New.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_New.Name = "tsb_New";
            this.tsb_New.Size = new System.Drawing.Size(36, 36);
            this.tsb_New.Text = "Novo";
            this.tsb_New.ToolTipText = "Novo tile map.";
            this.tsb_New.Click += new System.EventHandler(this.tsb_New_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsb_Open
            // 
            this.tsb_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Open.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Open.Image")));
            this.tsb_Open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Open.Name = "tsb_Open";
            this.tsb_Open.Size = new System.Drawing.Size(36, 36);
            this.tsb_Open.Text = "Abrir";
            this.tsb_Open.ToolTipText = "Abrir tile map.";
            this.tsb_Open.Click += new System.EventHandler(this.tsb_Open_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsb_Save
            // 
            this.tsb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Save.Image")));
            this.tsb_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Save.Name = "tsb_Save";
            this.tsb_Save.Size = new System.Drawing.Size(36, 36);
            this.tsb_Save.Text = "Salvar";
            this.tsb_Save.ToolTipText = "Salvar tile map.";
            this.tsb_Save.Click += new System.EventHandler(this.tsb_Save_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsb_OpenTiles
            // 
            this.tsb_OpenTiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_OpenTiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_OpenTile,
            this.tsmi_OpenTileImage});
            this.tsb_OpenTiles.Image = ((System.Drawing.Image)(resources.GetObject("tsb_OpenTiles.Image")));
            this.tsb_OpenTiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_OpenTiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_OpenTiles.Name = "tsb_OpenTiles";
            this.tsb_OpenTiles.Size = new System.Drawing.Size(45, 36);
            this.tsb_OpenTiles.Text = "Carregar Tile";
            this.tsb_OpenTiles.ToolTipText = "Carregar tile.";
            // 
            // tsmi_OpenTile
            // 
            this.tsmi_OpenTile.Name = "tsmi_OpenTile";
            this.tsmi_OpenTile.Size = new System.Drawing.Size(158, 22);
            this.tsmi_OpenTile.Text = "Tile";
            this.tsmi_OpenTile.Click += new System.EventHandler(this.tsmi_OpenTile_Click);
            // 
            // tsmi_OpenTileImage
            // 
            this.tsmi_OpenTileImage.Name = "tsmi_OpenTileImage";
            this.tsmi_OpenTileImage.Size = new System.Drawing.Size(158, 22);
            this.tsmi_OpenTileImage.Text = "Imagem de tiles";
            this.tsmi_OpenTileImage.Click += new System.EventHandler(this.tsmi_openTileImage_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tsb_EditTile
            // 
            this.tsb_EditTile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EditTile.Image = ((System.Drawing.Image)(resources.GetObject("tsb_EditTile.Image")));
            this.tsb_EditTile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_EditTile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_EditTile.Name = "tsb_EditTile";
            this.tsb_EditTile.Size = new System.Drawing.Size(36, 36);
            this.tsb_EditTile.Text = "Editar Tile";
            this.tsb_EditTile.ToolTipText = "Editar tile.";
            this.tsb_EditTile.Click += new System.EventHandler(this.tsb_EditTile_Click);
            // 
            // pnl_Fill
            // 
            this.pnl_Fill.Controls.Add(this.TileMap);
            this.pnl_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fill.Location = new System.Drawing.Point(0, 39);
            this.pnl_Fill.MinimumSize = new System.Drawing.Size(300, 300);
            this.pnl_Fill.Name = "pnl_Fill";
            this.pnl_Fill.Size = new System.Drawing.Size(753, 314);
            this.pnl_Fill.TabIndex = 7;
            // 
            // ofd_Tiles
            // 
            this.ofd_Tiles.Filter = "Image Files(*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG;*.PNM";
            // 
            // TileMap
            // 
            this.TileMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TileMap.GridThickness = 1;
            this.TileMap.Location = new System.Drawing.Point(0, 0);
            this.TileMap.Margin = new System.Windows.Forms.Padding(0);
            this.TileMap.MinimumSize = new System.Drawing.Size(300, 300);
            this.TileMap.Name = "TileMap";
            this.TileMap.SelectionColor = System.Drawing.Color.Red;
            this.TileMap.SelectionThickness = 3;
            this.TileMap.Size = new System.Drawing.Size(753, 314);
            this.TileMap.TabIndex = 8;
            // 
            // TileSet
            // 
            this.TileSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TileSet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TileSet.Location = new System.Drawing.Point(0, 357);
            this.TileSet.Name = "TileSet";
            this.TileSet.SelectedColor = System.Drawing.Color.Red;
            this.TileSet.Size = new System.Drawing.Size(753, 95);
            this.TileSet.TabIndex = 5;
            this.TileSet.TileMargin = ((short)(2));
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 452);
            this.Controls.Add(this.pnl_Fill);
            this.Controls.Add(this.ts_Menu);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.TileSet);
            this.MinimumSize = new System.Drawing.Size(769, 490);
            this.Name = "Main";
            this.Text = "Tileset Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ts_Menu.ResumeLayout(false);
            this.ts_Menu.PerformLayout();
            this.pnl_Fill.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip ts_Menu;
        private System.Windows.Forms.ToolStripButton tsb_New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsb_OpenTiles;
        private System.Windows.Forms.ToolStripMenuItem tsmi_OpenTile;
        private System.Windows.Forms.ToolStripMenuItem tsmi_OpenTileImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsb_EditTile;
        private TileSet TileSet;
        private System.Windows.Forms.Panel pnl_Fill;
        private Grid3 TileMap;
        private System.Windows.Forms.OpenFileDialog ofd_Tiles;
    }
}

