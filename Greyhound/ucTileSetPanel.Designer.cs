namespace Greyhound
{
    partial class ucTileSetPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flpnl_Tiles = new System.Windows.Forms.FlowLayoutPanel();
            this.cms_TileOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Apagar = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_TileOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpnl_Tiles
            // 
            this.flpnl_Tiles.AutoScroll = true;
            this.flpnl_Tiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnl_Tiles.Location = new System.Drawing.Point(0, 0);
            this.flpnl_Tiles.Name = "flpnl_Tiles";
            this.flpnl_Tiles.Size = new System.Drawing.Size(528, 150);
            this.flpnl_Tiles.TabIndex = 0;
            this.flpnl_Tiles.MouseEnter += new System.EventHandler(this.flpnl_Tiles_MouseEnter);
            // 
            // cms_TileOptions
            // 
            this.cms_TileOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Apagar});
            this.cms_TileOptions.Name = "cms_TileOptions";
            this.cms_TileOptions.Size = new System.Drawing.Size(153, 48);
            // 
            // tsmi_Apagar
            // 
            this.tsmi_Apagar.Name = "tsmi_Apagar";
            this.tsmi_Apagar.Size = new System.Drawing.Size(152, 22);
            this.tsmi_Apagar.Text = "Apagar";
            this.tsmi_Apagar.Click += new System.EventHandler(this.tsmi_Apagar_Click);
            // 
            // TileSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpnl_Tiles);
            this.Name = "TileSet";
            this.Size = new System.Drawing.Size(528, 150);
            this.cms_TileOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnl_Tiles;
        private System.Windows.Forms.ContextMenuStrip cms_TileOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Apagar;

    }
}
