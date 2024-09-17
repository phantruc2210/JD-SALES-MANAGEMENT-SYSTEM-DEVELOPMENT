namespace QLBH_VANPHONGPHAM_JD
{
    partial class FormTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTK = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngKýTàiKhoảnToolStripMenuItem,
            this.quảnLýThôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(221, 32);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngKýTàiKhoảnToolStripMenuItem
            // 
            this.đăngKýTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.đăngKýTàiKhoảnToolStripMenuItem.Name = "đăngKýTàiKhoảnToolStripMenuItem";
            this.đăngKýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.đăngKýTàiKhoảnToolStripMenuItem.Text = "Đăng Ký Tài Khoản";
            this.đăngKýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.đăngKýTàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLýThôngTinToolStripMenuItem
            // 
            this.quảnLýThôngTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quảnLýThôngTinToolStripMenuItem.Name = "quảnLýThôngTinToolStripMenuItem";
            this.quảnLýThôngTinToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.quảnLýThôngTinToolStripMenuItem.Text = "Quản Lý Thông Tin";
            this.quảnLýThôngTinToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThôngTinToolStripMenuItem_Click);
            // 
            // panelTK
            // 
            this.panelTK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTK.BackgroundImage")));
            this.panelTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTK.Location = new System.Drawing.Point(0, 0);
            this.panelTK.Name = "panelTK";
            this.panelTK.Size = new System.Drawing.Size(1289, 736);
            this.panelTK.TabIndex = 3;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 736);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelTK);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuThôngTinToolStripMenuItem;
        private System.Windows.Forms.Panel panelTK;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThôngTinToolStripMenuItem;
    }
}