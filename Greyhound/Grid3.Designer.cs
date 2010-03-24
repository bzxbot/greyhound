namespace Greyhound
{
    partial class Grid3
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
            this.pnl_Grid = new System.Windows.Forms.Panel();
            this.cms_TileOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Rotate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Erase = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_GridPlace = new System.Windows.Forms.Label();
            this.lbl_GridSquare = new System.Windows.Forms.Label();
            this.pnl_Grid.SuspendLayout();
            this.cms_TileOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Grid
            // 
            this.pnl_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Grid.ContextMenuStrip = this.cms_TileOptions;
            this.pnl_Grid.Controls.Add(this.lbl_GridPlace);
            this.pnl_Grid.Controls.Add(this.lbl_GridSquare);
            this.pnl_Grid.Location = new System.Drawing.Point(6, 6);
            this.pnl_Grid.Name = "pnl_Grid";
            this.pnl_Grid.Size = new System.Drawing.Size(288, 288);
            this.pnl_Grid.TabIndex = 0;
            this.pnl_Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Grid_Paint);
            this.pnl_Grid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Grid_MouseMove);
            this.pnl_Grid.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_Grid_DragDrop);
            this.pnl_Grid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Grid_MouseClick);
            this.pnl_Grid.Resize += new System.EventHandler(this.pnl_Grid_Resize);
            this.pnl_Grid.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_Grid_DragEnter);
            // 
            // cms_TileOptions
            // 
            this.cms_TileOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Rotate,
            this.tsmi_Erase});
            this.cms_TileOptions.Name = "cms_TileOptions";
            this.cms_TileOptions.Size = new System.Drawing.Size(153, 70);
            this.cms_TileOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cms_TileOptions_Opening);
            // 
            // tsmi_Rotate
            // 
            this.tsmi_Rotate.Name = "tsmi_Rotate";
            this.tsmi_Rotate.Size = new System.Drawing.Size(152, 22);
            this.tsmi_Rotate.Text = "Girar";
            this.tsmi_Rotate.Click += new System.EventHandler(this.tsmi_Rotate_Click);
            // 
            // tsmi_Erase
            // 
            this.tsmi_Erase.Name = "tsmi_Erase";
            this.tsmi_Erase.Size = new System.Drawing.Size(152, 22);
            this.tsmi_Erase.Text = "Apagar";
            this.tsmi_Erase.Click += new System.EventHandler(this.tsmi_Erase_Click);
            // 
            // lbl_GridPlace
            // 
            this.lbl_GridPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_GridPlace.AutoSize = true;
            this.lbl_GridPlace.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GridPlace.Location = new System.Drawing.Point(3, 257);
            this.lbl_GridPlace.Name = "lbl_GridPlace";
            this.lbl_GridPlace.Size = new System.Drawing.Size(49, 14);
            this.lbl_GridPlace.TabIndex = 0;
            this.lbl_GridPlace.Text = "label1";
            // 
            // lbl_GridSquare
            // 
            this.lbl_GridSquare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_GridSquare.AutoSize = true;
            this.lbl_GridSquare.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GridSquare.Location = new System.Drawing.Point(3, 272);
            this.lbl_GridSquare.Name = "lbl_GridSquare";
            this.lbl_GridSquare.Size = new System.Drawing.Size(49, 14);
            this.lbl_GridSquare.TabIndex = 0;
            this.lbl_GridSquare.Text = "label1";
            // 
            // Grid3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Grid);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Grid3";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.Grid3_Load);
            this.pnl_Grid.ResumeLayout(false);
            this.pnl_Grid.PerformLayout();
            this.cms_TileOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Grid;
        private System.Windows.Forms.Label lbl_GridPlace;
        private System.Windows.Forms.Label lbl_GridSquare;
        private System.Windows.Forms.ContextMenuStrip cms_TileOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Rotate;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Erase;
    }
}
