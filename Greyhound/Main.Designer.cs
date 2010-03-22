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
            this.pnl_Fill = new System.Windows.Forms.Panel();
            this.grid31 = new Greyhound.Grid3();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_Fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(441, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnl_Fill
            // 
            this.pnl_Fill.Controls.Add(this.grid31);
            this.pnl_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fill.Location = new System.Drawing.Point(0, 25);
            this.pnl_Fill.Name = "pnl_Fill";
            this.pnl_Fill.Size = new System.Drawing.Size(441, 280);
            this.pnl_Fill.TabIndex = 2;
            // 
            // grid31
            // 
            this.grid31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid31.Location = new System.Drawing.Point(0, 0);
            this.grid31.MinimumSize = new System.Drawing.Size(300, 300);
            this.grid31.Name = "grid31";
            this.grid31.Size = new System.Drawing.Size(441, 300);
            this.grid31.TabIndex = 0;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 308);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(441, 100);
            this.pnl_Bottom.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 305);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(441, 3);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 408);
            this.Controls.Add(this.pnl_Fill);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.Text = "Tileset Editor";
            this.pnl_Fill.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid grid1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel pnl_Fill;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Splitter splitter1;
        private Grid3 grid31;
    }
}

