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
            this.pnl_Fill = new System.Windows.Forms.Panel();
            this.grid31 = new Greyhound.Grid3();
            this.ts_Menu = new System.Windows.Forms.ToolStrip();
            this.tsb_New = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_OpenTiles = new System.Windows.Forms.ToolStripDropDownButton();
            this.abrirTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemDeTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_EditTile = new System.Windows.Forms.ToolStripButton();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnl_Fill.SuspendLayout();
            this.ts_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Fill
            // 
            this.pnl_Fill.Controls.Add(this.grid31);
            this.pnl_Fill.Controls.Add(this.ts_Menu);
            this.pnl_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fill.Location = new System.Drawing.Point(0, 0);
            this.pnl_Fill.Name = "pnl_Fill";
            this.pnl_Fill.Size = new System.Drawing.Size(753, 349);
            this.pnl_Fill.TabIndex = 2;
            // 
            // grid31
            // 
            this.grid31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid31.GridThickness = 1;
            this.grid31.Location = new System.Drawing.Point(0, 39);
            this.grid31.MinimumSize = new System.Drawing.Size(300, 300);
            this.grid31.Name = "grid31";
            this.grid31.Size = new System.Drawing.Size(753, 310);
            this.grid31.TabIndex = 0;
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
            this.ts_Menu.TabIndex = 1;
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
            this.abrirTileToolStripMenuItem,
            this.imagemDeTilesToolStripMenuItem});
            this.tsb_OpenTiles.Image = ((System.Drawing.Image)(resources.GetObject("tsb_OpenTiles.Image")));
            this.tsb_OpenTiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_OpenTiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_OpenTiles.Name = "tsb_OpenTiles";
            this.tsb_OpenTiles.Size = new System.Drawing.Size(45, 36);
            this.tsb_OpenTiles.Text = "Carregar Tile";
            this.tsb_OpenTiles.ToolTipText = "Carregar tile.";
            // 
            // abrirTileToolStripMenuItem
            // 
            this.abrirTileToolStripMenuItem.Name = "abrirTileToolStripMenuItem";
            this.abrirTileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.abrirTileToolStripMenuItem.Text = "Tile";
            // 
            // imagemDeTilesToolStripMenuItem
            // 
            this.imagemDeTilesToolStripMenuItem.Name = "imagemDeTilesToolStripMenuItem";
            this.imagemDeTilesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.imagemDeTilesToolStripMenuItem.Text = "Imagem de tiles";
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
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.AutoScroll = true;
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 352);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(753, 100);
            this.pnl_Bottom.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 349);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(753, 3);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 452);
            this.Controls.Add(this.pnl_Fill);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnl_Bottom);
            this.Name = "Main";
            this.Text = "Tileset Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnl_Fill.ResumeLayout(false);
            this.pnl_Fill.PerformLayout();
            this.ts_Menu.ResumeLayout(false);
            this.ts_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fill;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Splitter splitter1;
        private Grid3 grid31;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip ts_Menu;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsb_New;
        private System.Windows.Forms.ToolStripButton tsb_Open;
        private System.Windows.Forms.ToolStripButton tsb_Save;
        private System.Windows.Forms.ToolStripButton tsb_EditTile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsb_OpenTiles;
        private System.Windows.Forms.ToolStripMenuItem abrirTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemDeTilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

