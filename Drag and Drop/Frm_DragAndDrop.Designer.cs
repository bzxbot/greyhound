namespace Drag_and_Drop
{
    partial class Frm_DragAndDrop
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
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_Dock = new System.Windows.Forms.Panel();
            this.pic_Source = new System.Windows.Forms.PictureBox();
            this.pic_Target = new System.Windows.Forms.PictureBox();
            this.pnl_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Target)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Controls.Add(this.pic_Source);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 171);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(687, 100);
            this.pnl_Bottom.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 168);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(687, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnl_Dock
            // 
            this.pnl_Dock.AllowDrop = true;
            this.pnl_Dock.Location = new System.Drawing.Point(12, 12);
            this.pnl_Dock.Name = "pnl_Dock";
            this.pnl_Dock.Size = new System.Drawing.Size(200, 100);
            this.pnl_Dock.TabIndex = 2;
            // 
            // pic_Source
            // 
            this.pic_Source.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Source.Image = global::Drag_and_Drop.Properties.Resources.Chrysanthemum;
            this.pic_Source.Location = new System.Drawing.Point(12, 6);
            this.pic_Source.Name = "pic_Source";
            this.pic_Source.Size = new System.Drawing.Size(109, 82);
            this.pic_Source.TabIndex = 0;
            this.pic_Source.TabStop = false;
            this.pic_Source.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_Source_MouseMove);
            //this.pic_Source.DragLeave += new System.EventHandler(this.pic_Source_DragLeave);
            // 
            // pic_Target
            // 
            this.pic_Target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Target.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Target.Location = new System.Drawing.Point(233, 12);
            this.pic_Target.Name = "pic_Target";
            this.pic_Target.Size = new System.Drawing.Size(109, 100);
            this.pic_Target.TabIndex = 0;
            this.pic_Target.TabStop = false;
            this.pic_Target.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic_Target_DragDrop);
            this.pic_Target.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic_Target_DragEnter);
            // 
            // Frm_DragAndDrop
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 271);
            this.Controls.Add(this.pic_Target);
            this.Controls.Add(this.pnl_Dock);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnl_Bottom);
            this.Name = "Frm_DragAndDrop";
            this.Text = "Frm_DragAndDrop";
            this.Load += new System.EventHandler(this.Frm_DragAndDrop_Load);
            this.pnl_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Target)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnl_Dock;
        private System.Windows.Forms.PictureBox pic_Source;
        private System.Windows.Forms.PictureBox pic_Target;
    }
}