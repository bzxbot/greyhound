namespace Greyhound
{
    partial class Grid
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
            this.pnl_Grig = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_Grig
            // 
            this.pnl_Grig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Grig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Grig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Grig.Location = new System.Drawing.Point(0, 0);
            this.pnl_Grig.Name = "pnl_Grig";
            this.pnl_Grig.Size = new System.Drawing.Size(200, 100);
            this.pnl_Grig.TabIndex = 0;
            this.pnl_Grig.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Grid_Paint);
            this.pnl_Grig.Resize += new System.EventHandler(this.pnl_Grig_Resize);
            // 
            // Grid
            // 
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseClick);
            this.Resize += new System.EventHandler(this.Grid_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Grig;

    }
}
