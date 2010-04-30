namespace Greyhound
{
    partial class Frm_NewTileMap
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
            this.cmb_Ok = new System.Windows.Forms.Button();
            this.cmb_Cancel = new System.Windows.Forms.Button();
            this.nud_Height = new System.Windows.Forms.NumericUpDown();
            this.inf_Width = new System.Windows.Forms.Label();
            this.grp_Config = new System.Windows.Forms.GroupBox();
            this.inf_Height = new System.Windows.Forms.Label();
            this.nud_Width = new System.Windows.Forms.NumericUpDown();
            this.inf_TileSize = new System.Windows.Forms.Label();
            this.nud_TileSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).BeginInit();
            this.grp_Config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TileSize)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Ok
            // 
            this.cmb_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmb_Ok.Location = new System.Drawing.Point(21, 118);
            this.cmb_Ok.Name = "cmb_Ok";
            this.cmb_Ok.Size = new System.Drawing.Size(75, 23);
            this.cmb_Ok.TabIndex = 0;
            this.cmb_Ok.Text = "Ok";
            this.cmb_Ok.UseVisualStyleBackColor = true;
            // 
            // cmb_Cancel
            // 
            this.cmb_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmb_Cancel.Location = new System.Drawing.Point(121, 118);
            this.cmb_Cancel.Name = "cmb_Cancel";
            this.cmb_Cancel.Size = new System.Drawing.Size(75, 23);
            this.cmb_Cancel.TabIndex = 0;
            this.cmb_Cancel.Text = "Cancelar";
            this.cmb_Cancel.UseVisualStyleBackColor = true;
            // 
            // nud_Height
            // 
            this.nud_Height.Location = new System.Drawing.Point(109, 20);
            this.nud_Height.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Height.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Height.Name = "nud_Height";
            this.nud_Height.Size = new System.Drawing.Size(57, 20);
            this.nud_Height.TabIndex = 1;
            this.nud_Height.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // inf_Width
            // 
            this.inf_Width.AutoSize = true;
            this.inf_Width.Location = new System.Drawing.Point(63, 22);
            this.inf_Width.Name = "inf_Width";
            this.inf_Width.Size = new System.Drawing.Size(37, 13);
            this.inf_Width.TabIndex = 2;
            this.inf_Width.Text = "Altura:";
            // 
            // grp_Config
            // 
            this.grp_Config.Controls.Add(this.nud_TileSize);
            this.grp_Config.Controls.Add(this.nud_Width);
            this.grp_Config.Controls.Add(this.nud_Height);
            this.grp_Config.Controls.Add(this.inf_TileSize);
            this.grp_Config.Controls.Add(this.inf_Height);
            this.grp_Config.Controls.Add(this.inf_Width);
            this.grp_Config.Location = new System.Drawing.Point(12, 12);
            this.grp_Config.Name = "grp_Config";
            this.grp_Config.Size = new System.Drawing.Size(192, 100);
            this.grp_Config.TabIndex = 3;
            this.grp_Config.TabStop = false;
            this.grp_Config.Text = "Configurações";
            // 
            // inf_Height
            // 
            this.inf_Height.AutoSize = true;
            this.inf_Height.Location = new System.Drawing.Point(54, 48);
            this.inf_Height.Name = "inf_Height";
            this.inf_Height.Size = new System.Drawing.Size(46, 13);
            this.inf_Height.TabIndex = 2;
            this.inf_Height.Text = "Largura:";
            // 
            // nud_Width
            // 
            this.nud_Width.Location = new System.Drawing.Point(109, 46);
            this.nud_Width.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Width.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Width.Name = "nud_Width";
            this.nud_Width.Size = new System.Drawing.Size(57, 20);
            this.nud_Width.TabIndex = 1;
            this.nud_Width.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // inf_TileSize
            // 
            this.inf_TileSize.AutoSize = true;
            this.inf_TileSize.Location = new System.Drawing.Point(6, 74);
            this.inf_TileSize.Name = "inf_TileSize";
            this.inf_TileSize.Size = new System.Drawing.Size(97, 13);
            this.inf_TileSize.TabIndex = 2;
            this.inf_TileSize.Text = "Tamanho dos Tiles";
            // 
            // nud_TileSize
            // 
            this.nud_TileSize.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nud_TileSize.Location = new System.Drawing.Point(109, 72);
            this.nud_TileSize.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.nud_TileSize.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nud_TileSize.Name = "nud_TileSize";
            this.nud_TileSize.Size = new System.Drawing.Size(57, 20);
            this.nud_TileSize.TabIndex = 1;
            this.nud_TileSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // Frm_NewTileMap
            // 
            this.AcceptButton = this.cmb_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmb_Cancel;
            this.ClientSize = new System.Drawing.Size(216, 150);
            this.Controls.Add(this.grp_Config);
            this.Controls.Add(this.cmb_Cancel);
            this.Controls.Add(this.cmb_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_NewTileMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Tile Map";
            this.Load += new System.EventHandler(this.Frm_NewTileMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).EndInit();
            this.grp_Config.ResumeLayout(false);
            this.grp_Config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TileSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmb_Ok;
        private System.Windows.Forms.Button cmb_Cancel;
        private System.Windows.Forms.NumericUpDown nud_Height;
        private System.Windows.Forms.Label inf_Width;
        private System.Windows.Forms.GroupBox grp_Config;
        private System.Windows.Forms.NumericUpDown nud_TileSize;
        private System.Windows.Forms.NumericUpDown nud_Width;
        private System.Windows.Forms.Label inf_TileSize;
        private System.Windows.Forms.Label inf_Height;
    }
}