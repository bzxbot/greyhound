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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.grid2 = new Greyhound.Grid();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(420, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // grid2
            // 
            this.grid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid2.Location = new System.Drawing.Point(12, 28);
            this.grid2.MaximumSize = new System.Drawing.Size(300, 300);
            this.grid2.MinimumSize = new System.Drawing.Size(300, 300);
            this.grid2.Name = "grid2";
            this.grid2.Size = new System.Drawing.Size(300, 300);
            this.grid2.TabIndex = 2;
            this.grid2.Text = "grid2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 378);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.Text = "Tileset Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid grid1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Grid grid2;
    }
}

