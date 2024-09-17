namespace QLBH_VANPHONGPHAM_JD
{
    partial class FormQuenMK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLayLaiMK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkDangNhap = new System.Windows.Forms.LinkLabel();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtTenDN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.linkDangNhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLayLaiMK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(94, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 421);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(114, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 61);
            this.label1.TabIndex = 85;
            this.label1.Text = "QUÊN MẬT KHẨU";
            // 
            // btnLayLaiMK
            // 
            this.btnLayLaiMK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLayLaiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLayLaiMK.Location = new System.Drawing.Point(87, 270);
            this.btnLayLaiMK.Name = "btnLayLaiMK";
            this.btnLayLaiMK.Size = new System.Drawing.Size(457, 49);
            this.btnLayLaiMK.TabIndex = 83;
            this.btnLayLaiMK.Text = "Lấy Lại Mật Khẩu";
            this.btnLayLaiMK.UseVisualStyleBackColor = false;
            this.btnLayLaiMK.Click += new System.EventHandler(this.btnLayLaiMK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 28);
            this.label3.TabIndex = 81;
            this.label3.Text = "Nhập email của bạn để nhận mã xác nhận lấy lại mật khẩu";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(268, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 34);
            this.txtEmail.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 79;
            this.label2.Text = "Nhập email:";
            // 
            // linkDangNhap
            // 
            this.linkDangNhap.AutoSize = true;
            this.linkDangNhap.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkDangNhap.Location = new System.Drawing.Point(206, 338);
            this.linkDangNhap.Name = "linkDangNhap";
            this.linkDangNhap.Size = new System.Drawing.Size(192, 28);
            this.linkDangNhap.TabIndex = 86;
            this.linkDangNhap.TabStop = true;
            this.linkDangNhap.Text = "Quay Lại Đăng Nhập";
            this.linkDangNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDangNhap_LinkClicked);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(268, 154);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(276, 34);
            this.txtTenDN.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 28);
            this.label4.TabIndex = 87;
            this.label4.Text = "Tên đăng nhập:";
            // 
            // FormQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuenMK";
            this.Text = "FormQuenMK";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLayLaiMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkDangNhap;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label4;
    }
}