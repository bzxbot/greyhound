﻿namespace Greyhound
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
            this.pnl_Grid = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_Grid
            // 
            this.pnl_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Grid.Location = new System.Drawing.Point(6, 6);
            this.pnl_Grid.Name = "pnl_Grid";
            this.pnl_Grid.Size = new System.Drawing.Size(288, 288);
            this.pnl_Grid.TabIndex = 0;
            this.pnl_Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Grid_Paint);
            this.pnl_Grid.Resize += new System.EventHandler(this.pnl_Grid_Resize);
            // 
            // Grid3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Grid);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Grid3";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Grid;
    }
}
