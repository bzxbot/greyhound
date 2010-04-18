namespace Greyhound.TileSplitter
{
    partial class Frm_TileSplitter
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
            this.nud_PixelsPerTile = new System.Windows.Forms.NumericUpDown();
            this.lbl_PixelPerTile = new System.Windows.Forms.Label();
            this.pic_Tiles = new System.Windows.Forms.PictureBox();
            this.cmb_Split = new System.Windows.Forms.Button();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.chBox_VerMascara = new System.Windows.Forms.CheckBox();
            this.lbl_MaskColor = new System.Windows.Forms.Label();
            this.inf_MaskColor = new System.Windows.Forms.Label();
            this.ofd_Picture = new System.Windows.Forms.OpenFileDialog();
            this.fbd_SaveTiles = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_Splitter = new System.Windows.Forms.Label();
            this.cd_SelectColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PixelsPerTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Tiles)).BeginInit();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // nud_PixelsPerTile
            // 
            this.nud_PixelsPerTile.Location = new System.Drawing.Point(92, 12);
            this.nud_PixelsPerTile.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_PixelsPerTile.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nud_PixelsPerTile.Name = "nud_PixelsPerTile";
            this.nud_PixelsPerTile.Size = new System.Drawing.Size(52, 20);
            this.nud_PixelsPerTile.TabIndex = 1;
            this.nud_PixelsPerTile.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nud_PixelsPerTile.ValueChanged += new System.EventHandler(this.nud_PixelsPerTile_ValueChanged);
            // 
            // lbl_PixelPerTile
            // 
            this.lbl_PixelPerTile.AutoSize = true;
            this.lbl_PixelPerTile.Location = new System.Drawing.Point(12, 14);
            this.lbl_PixelPerTile.Name = "lbl_PixelPerTile";
            this.lbl_PixelPerTile.Size = new System.Drawing.Size(74, 13);
            this.lbl_PixelPerTile.TabIndex = 2;
            this.lbl_PixelPerTile.Text = "Pixel dos Tiles";
            // 
            // pic_Tiles
            // 
            this.pic_Tiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Tiles.Location = new System.Drawing.Point(0, 0);
            this.pic_Tiles.Name = "pic_Tiles";
            this.pic_Tiles.Size = new System.Drawing.Size(485, 404);
            this.pic_Tiles.TabIndex = 0;
            this.pic_Tiles.TabStop = false;
            this.pic_Tiles.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Tiles_Paint);
            // 
            // cmb_Split
            // 
            this.cmb_Split.Location = new System.Drawing.Point(15, 106);
            this.cmb_Split.Name = "cmb_Split";
            this.cmb_Split.Size = new System.Drawing.Size(75, 23);
            this.cmb_Split.TabIndex = 3;
            this.cmb_Split.Text = "Separar";
            this.cmb_Split.UseVisualStyleBackColor = true;
            this.cmb_Split.Click += new System.EventHandler(this.cmb_Split_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.chBox_VerMascara);
            this.pnl_Top.Controls.Add(this.lbl_MaskColor);
            this.pnl_Top.Controls.Add(this.inf_MaskColor);
            this.pnl_Top.Controls.Add(this.lbl_PixelPerTile);
            this.pnl_Top.Controls.Add(this.cmb_Split);
            this.pnl_Top.Controls.Add(this.nud_PixelsPerTile);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Top.Location = new System.Drawing.Point(486, 0);
            this.pnl_Top.MinimumSize = new System.Drawing.Size(177, 404);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(177, 404);
            this.pnl_Top.TabIndex = 4;
            // 
            // chBox_VerMascara
            // 
            this.chBox_VerMascara.AutoSize = true;
            this.chBox_VerMascara.Location = new System.Drawing.Point(16, 83);
            this.chBox_VerMascara.Name = "chBox_VerMascara";
            this.chBox_VerMascara.Size = new System.Drawing.Size(85, 17);
            this.chBox_VerMascara.TabIndex = 8;
            this.chBox_VerMascara.Text = "Ver máscara";
            this.chBox_VerMascara.UseVisualStyleBackColor = true;
            this.chBox_VerMascara.CheckedChanged += new System.EventHandler(this.chBox_VerMascara_CheckedChanged);
            // 
            // lbl_MaskColor
            // 
            this.lbl_MaskColor.BackColor = System.Drawing.Color.Lime;
            this.lbl_MaskColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_MaskColor.Location = new System.Drawing.Point(102, 51);
            this.lbl_MaskColor.Name = "lbl_MaskColor";
            this.lbl_MaskColor.Size = new System.Drawing.Size(15, 13);
            this.lbl_MaskColor.TabIndex = 7;
            this.lbl_MaskColor.Click += new System.EventHandler(this.lbl_MaskColor_Click);
            // 
            // inf_MaskColor
            // 
            this.inf_MaskColor.AutoSize = true;
            this.inf_MaskColor.Location = new System.Drawing.Point(12, 51);
            this.inf_MaskColor.Name = "inf_MaskColor";
            this.inf_MaskColor.Size = new System.Drawing.Size(84, 13);
            this.inf_MaskColor.TabIndex = 6;
            this.inf_MaskColor.Text = "Cor da máscara:";
            // 
            // ofd_Picture
            // 
            this.ofd_Picture.FileName = "openFileDialog1";
            // 
            // lbl_Splitter
            // 
            this.lbl_Splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Splitter.Location = new System.Drawing.Point(485, 0);
            this.lbl_Splitter.Name = "lbl_Splitter";
            this.lbl_Splitter.Size = new System.Drawing.Size(1, 404);
            this.lbl_Splitter.TabIndex = 6;
            // 
            // Frm_TileSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 404);
            this.Controls.Add(this.pic_Tiles);
            this.Controls.Add(this.lbl_Splitter);
            this.Controls.Add(this.pnl_Top);
            this.MinimizeBox = false;
            this.Name = "Frm_TileSplitter";
            this.Text = "Tile Splitter";
            ((System.ComponentModel.ISupportInitialize)(this.nud_PixelsPerTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Tiles)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_PixelsPerTile;
        private System.Windows.Forms.Label lbl_PixelPerTile;
        private System.Windows.Forms.PictureBox pic_Tiles;
        private System.Windows.Forms.Button cmb_Split;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.OpenFileDialog ofd_Picture;
        private System.Windows.Forms.FolderBrowserDialog fbd_SaveTiles;
        private System.Windows.Forms.Label lbl_Splitter;
        private System.Windows.Forms.Label inf_MaskColor;
        private System.Windows.Forms.Label lbl_MaskColor;
        private System.Windows.Forms.ColorDialog cd_SelectColor;
        private System.Windows.Forms.CheckBox chBox_VerMascara;
    }
}

