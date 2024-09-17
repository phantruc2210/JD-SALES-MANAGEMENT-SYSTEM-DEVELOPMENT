namespace QLBH_VANPHONGPHAM_JD
{
    partial class FormNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapHang));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelNH = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhậpHàngToolStripMenuItem,
            this.traCứuThôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNhậpHàngToolStripMenuItem
            // 
            this.quảnLýNhậpHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quảnLýNhậpHàngToolStripMenuItem.Name = "quảnLýNhậpHàngToolStripMenuItem";
            this.quảnLýNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.quảnLýNhậpHàngToolStripMenuItem.Text = "Quản Lý Nhập Hàng";
            this.quảnLýNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhậpHàngToolStripMenuItem_Click);
            // 
            // traCứuThôngTinToolStripMenuItem
            // 
            this.traCứuThôngTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.traCứuThôngTinToolStripMenuItem.Name = "traCứuThôngTinToolStripMenuItem";
            this.traCứuThôngTinToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.traCứuThôngTinToolStripMenuItem.Text = "Tra Cứu Thông Tin";
            this.traCứuThôngTinToolStripMenuItem.Click += new System.EventHandler(this.traCứuThôngTinToolStripMenuItem_Click);
            // 
            // panelNH
            // 
            this.panelNH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelNH.BackgroundImage")));
            this.panelNH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNH.Location = new System.Drawing.Point(0, 0);
            this.panelNH.Name = "panelNH";
            this.panelNH.Size = new System.Drawing.Size(1149, 632);
            this.panelNH.TabIndex = 3;
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 632);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelNH);
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuThôngTinToolStripMenuItem;
        private System.Windows.Forms.Panel panelNH;
    }
}