namespace QLBH_VANPHONGPHAM_JD
{
    partial class FormBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBH = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.traCứuThôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản Lý Bán Hàng";
            this.quảnLýHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHóaĐơnToolStripMenuItem_Click);
            // 
            // traCứuThôngTinToolStripMenuItem
            // 
            this.traCứuThôngTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.traCứuThôngTinToolStripMenuItem.Name = "traCứuThôngTinToolStripMenuItem";
            this.traCứuThôngTinToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.traCứuThôngTinToolStripMenuItem.Text = "Tra Cứu Thông Tin";
            this.traCứuThôngTinToolStripMenuItem.Click += new System.EventHandler(this.traCứuThôngTinToolStripMenuItem_Click);
            // 
            // panelBH
            // 
            this.panelBH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBH.BackgroundImage")));
            this.panelBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBH.Location = new System.Drawing.Point(0, 0);
            this.panelBH.Name = "panelBH";
            this.panelBH.Size = new System.Drawing.Size(800, 450);
            this.panelBH.TabIndex = 3;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelBH);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuThôngTinToolStripMenuItem;
        private System.Windows.Forms.Panel panelBH;
    }
}