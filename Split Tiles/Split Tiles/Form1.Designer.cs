namespace Split_Tiles
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd_Picture = new System.Windows.Forms.OpenFileDialog();
            this.fbd_SaveTiles = new System.Windows.Forms.FolderBrowserDialog();
            this.cmb_ShowMask = new System.Windows.Forms.Button();
            this.cmBox_MaskColor = new System.Windows.Forms.ComboBox();
            this.lbl_Splitter = new System.Windows.Forms.Label();
            this.inf_MaskColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PixelsPerTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Tiles)).BeginInit();
            this.pnl_Top.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.pic_Tiles.Location = new System.Drawing.Point(0, 24);
            this.pic_Tiles.Name = "pic_Tiles";
            this.pic_Tiles.Size = new System.Drawing.Size(485, 380);
            this.pic_Tiles.TabIndex = 0;
            this.pic_Tiles.TabStop = false;
            // 
            // cmb_Split
            // 
            this.cmb_Split.Location = new System.Drawing.Point(15, 123);
            this.cmb_Split.Name = "cmb_Split";
            this.cmb_Split.Size = new System.Drawing.Size(75, 23);
            this.cmb_Split.TabIndex = 3;
            this.cmb_Split.Text = "Separar";
            this.cmb_Split.UseVisualStyleBackColor = true;
            this.cmb_Split.Click += new System.EventHandler(this.cmb_Separar_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.inf_MaskColor);
            this.pnl_Top.Controls.Add(this.cmBox_MaskColor);
            this.pnl_Top.Controls.Add(this.cmb_ShowMask);
            this.pnl_Top.Controls.Add(this.lbl_PixelPerTile);
            this.pnl_Top.Controls.Add(this.cmb_Split);
            this.pnl_Top.Controls.Add(this.nud_PixelsPerTile);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Top.Location = new System.Drawing.Point(486, 24);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(177, 380);
            this.pnl_Top.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Abrir});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // tsmi_Abrir
            // 
            this.tsmi_Abrir.Name = "tsmi_Abrir";
            this.tsmi_Abrir.Size = new System.Drawing.Size(152, 22);
            this.tsmi_Abrir.Text = "Abrir";
            this.tsmi_Abrir.Click += new System.EventHandler(this.tsmi_Abrir_Click);
            // 
            // ofd_Picture
            // 
            this.ofd_Picture.FileName = "openFileDialog1";
            // 
            // cmb_ShowMask
            // 
            this.cmb_ShowMask.Location = new System.Drawing.Point(15, 94);
            this.cmb_ShowMask.Name = "cmb_ShowMask";
            this.cmb_ShowMask.Size = new System.Drawing.Size(121, 23);
            this.cmb_ShowMask.TabIndex = 4;
            this.cmb_ShowMask.Text = "Ver máscara";
            this.cmb_ShowMask.UseVisualStyleBackColor = true;
            // 
            // cmBox_MaskColor
            // 
            this.cmBox_MaskColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBox_MaskColor.FormattingEnabled = true;
            this.cmBox_MaskColor.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Vermelho",
            "Verde"});
            this.cmBox_MaskColor.Location = new System.Drawing.Point(15, 67);
            this.cmBox_MaskColor.Name = "cmBox_MaskColor";
            this.cmBox_MaskColor.Size = new System.Drawing.Size(121, 21);
            this.cmBox_MaskColor.TabIndex = 5;
            // 
            // lbl_Splitter
            // 
            this.lbl_Splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Splitter.Location = new System.Drawing.Point(485, 24);
            this.lbl_Splitter.Name = "lbl_Splitter";
            this.lbl_Splitter.Size = new System.Drawing.Size(1, 380);
            this.lbl_Splitter.TabIndex = 6;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 404);
            this.Controls.Add(this.pic_Tiles);
            this.Controls.Add(this.lbl_Splitter);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_PixelsPerTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Tiles)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_PixelsPerTile;
        private System.Windows.Forms.Label lbl_PixelPerTile;
        private System.Windows.Forms.PictureBox pic_Tiles;
        private System.Windows.Forms.Button cmb_Split;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Abrir;
        private System.Windows.Forms.OpenFileDialog ofd_Picture;
        private System.Windows.Forms.FolderBrowserDialog fbd_SaveTiles;
        private System.Windows.Forms.ComboBox cmBox_MaskColor;
        private System.Windows.Forms.Button cmb_ShowMask;
        private System.Windows.Forms.Label lbl_Splitter;
        private System.Windows.Forms.Label inf_MaskColor;
    }
}

