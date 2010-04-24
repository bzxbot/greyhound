﻿namespace Greyhound.Tile_Editor
{
    partial class Frm_TileEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Orig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Edited)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(338, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosToolStripMenuItem.Text = "Filtros";
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_TileEditor";
            this.Text = "Tile Editor";
            this.Load += new System.EventHandler(this.Frm_TileEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Orig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Edited)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
    }
}