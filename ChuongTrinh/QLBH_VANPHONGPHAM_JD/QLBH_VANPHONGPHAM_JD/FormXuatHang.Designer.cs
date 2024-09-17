namespace QLBH_VANPHONGPHAM_JD
{
    partial class FormXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXuatHang));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýXuấtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelXH = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýXuấtHàngToolStripMenuItem,
            this.traCứuThôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1195, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýXuấtHàngToolStripMenuItem
            // 
            this.quảnLýXuấtHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quảnLýXuấtHàngToolStripMenuItem.Name = "quảnLýXuấtHàngToolStripMenuItem";
            this.quảnLýXuấtHàngToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.quảnLýXuấtHàngToolStripMenuItem.Text = "Quản Lý Xuất Hàng";
            this.quảnLýXuấtHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýXuấtHàngToolStripMenuItem_Click);
            // 
            // traCứuThôngTinToolStripMenuItem
            // 
            this.traCứuThôngTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.traCứuThôngTinToolStripMenuItem.Name = "traCứuThôngTinToolStripMenuItem";
            this.traCứuThôngTinToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.traCứuThôngTinToolStripMenuItem.Text = "Tra Cứu Thông Tin";
            this.traCứuThôngTinToolStripMenuItem.Click += new System.EventHandler(this.traCứuThôngTinToolStripMenuItem_Click);
            // 
            // panelXH
            // 
            this.panelXH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelXH.BackgroundImage")));
            this.panelXH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelXH.Location = new System.Drawing.Point(0, 0);
            this.panelXH.Name = "panelXH";
            this.panelXH.Size = new System.Drawing.Size(1195, 650);
            this.panelXH.TabIndex = 3;
            // 
            // FormXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 650);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelXH);
            this.Name = "FormXuatHang";
            this.Text = "FormXuatHang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXuấtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuThôngTinToolStripMenuItem;
        private System.Windows.Forms.Panel panelXH;
    }
}