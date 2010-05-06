namespace Greyhound.Tile_Editor
{
    partial class frmTileEditor
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
            this.pic_Orig = new System.Windows.Forms.PictureBox();
            this.pic_Edited = new System.Windows.Forms.PictureBox();
            this.inf_ImgEdit = new System.Windows.Forms.Label();
            this.inf_ImgOrig = new System.Windows.Forms.Label();
            this.cb_SaveAsCopy = new System.Windows.Forms.CheckBox();
            this.cmb_Cancel = new System.Windows.Forms.Button();
            this.cmb_Ok = new System.Windows.Forms.Button();
            this.menu_TileEditor = new System.Windows.Forms.MenuStrip();
            this.tsmi_Filters = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_GrayScale = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Sepia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_InvertColors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ChangeHue = new System.Windows.Forms.ToolStripMenuItem();
            this.cd_SelectColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Orig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Edited)).BeginInit();
            this.menu_TileEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Orig
            // 
            this.pic_Orig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Orig.Location = new System.Drawing.Point(12, 54);
            this.pic_Orig.Name = "pic_Orig";
            this.pic_Orig.Size = new System.Drawing.Size(150, 150);
            this.pic_Orig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Orig.TabIndex = 0;
            this.pic_Orig.TabStop = false;
            // 
            // pic_Edited
            // 
            this.pic_Edited.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Edited.Location = new System.Drawing.Point(173, 54);
            this.pic_Edited.Name = "pic_Edited";
            this.pic_Edited.Size = new System.Drawing.Size(150, 150);
            this.pic_Edited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Edited.TabIndex = 0;
            this.pic_Edited.TabStop = false;
            // 
            // inf_ImgEdit
            // 
            this.inf_ImgEdit.AutoSize = true;
            this.inf_ImgEdit.Location = new System.Drawing.Point(170, 38);
            this.inf_ImgEdit.Name = "inf_ImgEdit";
            this.inf_ImgEdit.Size = new System.Drawing.Size(83, 13);
            this.inf_ImgEdit.TabIndex = 1;
            this.inf_ImgEdit.Text = "Imagem Editada";
            // 
            // inf_ImgOrig
            // 
            this.inf_ImgOrig.AutoSize = true;
            this.inf_ImgOrig.Location = new System.Drawing.Point(12, 38);
            this.inf_ImgOrig.Name = "inf_ImgOrig";
            this.inf_ImgOrig.Size = new System.Drawing.Size(82, 13);
            this.inf_ImgOrig.TabIndex = 1;
            this.inf_ImgOrig.Text = "Imagem Original";
            // 
            // cb_SaveAsCopy
            // 
            this.cb_SaveAsCopy.AutoSize = true;
            this.cb_SaveAsCopy.Checked = true;
            this.cb_SaveAsCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_SaveAsCopy.Location = new System.Drawing.Point(12, 210);
            this.cb_SaveAsCopy.Name = "cb_SaveAsCopy";
            this.cb_SaveAsCopy.Size = new System.Drawing.Size(130, 17);
            this.cb_SaveAsCopy.TabIndex = 2;
            this.cb_SaveAsCopy.Text = "Salvar tile como cópia";
            this.cb_SaveAsCopy.UseVisualStyleBackColor = true;
            // 
            // cmb_Cancel
            // 
            this.cmb_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmb_Cancel.Location = new System.Drawing.Point(173, 251);
            this.cmb_Cancel.Name = "cmb_Cancel";
            this.cmb_Cancel.Size = new System.Drawing.Size(75, 23);
            this.cmb_Cancel.TabIndex = 3;
            this.cmb_Cancel.Text = "Cancelar";
            this.cmb_Cancel.UseVisualStyleBackColor = true;
            // 
            // cmb_Ok
            // 
            this.cmb_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmb_Ok.Location = new System.Drawing.Point(87, 251);
            this.cmb_Ok.Name = "cmb_Ok";
            this.cmb_Ok.Size = new System.Drawing.Size(75, 23);
            this.cmb_Ok.TabIndex = 3;
            this.cmb_Ok.Text = "Ok";
            this.cmb_Ok.UseVisualStyleBackColor = true;
            // 
            // menu_TileEditor
            // 
            this.menu_TileEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Filters});
            this.menu_TileEditor.Location = new System.Drawing.Point(0, 0);
            this.menu_TileEditor.Name = "menu_TileEditor";
            this.menu_TileEditor.Size = new System.Drawing.Size(338, 24);
            this.menu_TileEditor.TabIndex = 4;
            this.menu_TileEditor.Text = "menuStrip1";
            // 
            // tsmi_Filters
            // 
            this.tsmi_Filters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_GrayScale,
            this.tsmi_Sepia,
            this.tsmi_InvertColors,
            this.tsmi_ChangeHue});
            this.tsmi_Filters.Name = "tsmi_Filters";
            this.tsmi_Filters.Size = new System.Drawing.Size(51, 20);
            this.tsmi_Filters.Text = "Filtros";
            // 
            // tsmi_GrayScale
            // 
            this.tsmi_GrayScale.Name = "tsmi_GrayScale";
            this.tsmi_GrayScale.Size = new System.Drawing.Size(170, 22);
            this.tsmi_GrayScale.Text = "Escala de Cinza";
            this.tsmi_GrayScale.Click += new System.EventHandler(this.tsmi_GrayScale_Click);
            // 
            // tsmi_Sepia
            // 
            this.tsmi_Sepia.Name = "tsmi_Sepia";
            this.tsmi_Sepia.Size = new System.Drawing.Size(170, 22);
            this.tsmi_Sepia.Text = "Sepia";
            this.tsmi_Sepia.Click += new System.EventHandler(this.tsmi_Sepia_Click);
            // 
            // tsmi_InvertColors
            // 
            this.tsmi_InvertColors.Name = "tsmi_InvertColors";
            this.tsmi_InvertColors.Size = new System.Drawing.Size(170, 22);
            this.tsmi_InvertColors.Text = "Inverter Cores";
            this.tsmi_InvertColors.Click += new System.EventHandler(this.tsmi_InvertColors_Click);
            // 
            // tsmi_ChangeHue
            // 
            this.tsmi_ChangeHue.Name = "tsmi_ChangeHue";
            this.tsmi_ChangeHue.Size = new System.Drawing.Size(170, 22);
            this.tsmi_ChangeHue.Text = "Trocar Tonalidade";
            this.tsmi_ChangeHue.Click += new System.EventHandler(this.tsmi_ChangeHue_Click);
            // 
            // Frm_TileEditor
            // 
            this.AcceptButton = this.cmb_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmb_Cancel;
            this.ClientSize = new System.Drawing.Size(338, 283);
            this.Controls.Add(this.cmb_Ok);
            this.Controls.Add(this.cmb_Cancel);
            this.Controls.Add(this.cb_SaveAsCopy);
            this.Controls.Add(this.inf_ImgOrig);
            this.Controls.Add(this.inf_ImgEdit);
            this.Controls.Add(this.pic_Edited);
            this.Controls.Add(this.pic_Orig);
            this.Controls.Add(this.menu_TileEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu_TileEditor;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TileEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tile Editor";
            this.Load += new System.EventHandler(this.Frm_TileEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Orig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Edited)).EndInit();
            this.menu_TileEditor.ResumeLayout(false);
            this.menu_TileEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Orig;
        private System.Windows.Forms.PictureBox pic_Edited;
        private System.Windows.Forms.Label inf_ImgEdit;
        private System.Windows.Forms.Label inf_ImgOrig;
        private System.Windows.Forms.CheckBox cb_SaveAsCopy;
        private System.Windows.Forms.Button cmb_Cancel;
        private System.Windows.Forms.Button cmb_Ok;
        private System.Windows.Forms.MenuStrip menu_TileEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Filters;
        private System.Windows.Forms.ToolStripMenuItem tsmi_GrayScale;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Sepia;
        private System.Windows.Forms.ToolStripMenuItem tsmi_InvertColors;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ChangeHue;
        private System.Windows.Forms.ColorDialog cd_SelectColor;
    }
}