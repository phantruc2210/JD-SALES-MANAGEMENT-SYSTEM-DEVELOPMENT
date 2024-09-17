namespace QLBH_VANPHONGPHAM_JD
{
    partial class FormTroGiup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTroGiup));
            this.panelTG = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhữngCâuHỏiThườngGặpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trungTâmHỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTG
            // 
            this.panelTG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTG.BackgroundImage")));
            this.panelTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTG.Location = new System.Drawing.Point(0, 36);
            this.panelTG.Name = "panelTG";
            this.panelTG.Size = new System.Drawing.Size(1161, 559);
            this.panelTG.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhữngCâuHỏiThườngGặpToolStripMenuItem,
            this.trungTâmHỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhữngCâuHỏiThườngGặpToolStripMenuItem
            // 
            this.nhữngCâuHỏiThườngGặpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nhữngCâuHỏiThườngGặpToolStripMenuItem.Name = "nhữngCâuHỏiThườngGặpToolStripMenuItem";
            this.nhữngCâuHỏiThườngGặpToolStripMenuItem.Size = new System.Drawing.Size(294, 32);
            this.nhữngCâuHỏiThườngGặpToolStripMenuItem.Text = "Những Câu Hỏi Thường Gặp";
            this.nhữngCâuHỏiThườngGặpToolStripMenuItem.Click += new System.EventHandler(this.nhữngCâuHỏiThườngGặpToolStripMenuItem_Click);
            // 
            // trungTâmHỗTrợToolStripMenuItem
            // 
            this.trungTâmHỗTrợToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.trungTâmHỗTrợToolStripMenuItem.Name = "trungTâmHỗTrợToolStripMenuItem";
            this.trungTâmHỗTrợToolStripMenuItem.Size = new System.Drawing.Size(195, 32);
            this.trungTâmHỗTrợToolStripMenuItem.Text = "Trung Tâm Hỗ Trợ";
            this.trungTâmHỗTrợToolStripMenuItem.Click += new System.EventHandler(this.trungTâmHỗTrợToolStripMenuItem_Click);
            // 
            // FormTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 595);
            this.Controls.Add(this.panelTG);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormTroGiup";
            this.Text = "FormTroGiup";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhữngCâuHỏiThườngGặpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trungTâmHỗTrợToolStripMenuItem;
    }
}