namespace QLBH_VANPHONGPHAM_JD
{
    partial class FormTaiKhoan_QLTT
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan_QLTT));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTongTin = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHienHanh = new System.Windows.Forms.TextBox();
            this.btnKe = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_TABLE = new QLBH_VANPHONGPHAM_JD.QLBH_TABLE();
            this.taiKhoanTableAdapter = new QLBH_VANPHONGPHAM_JD.QLBH_TABLETableAdapters.TaiKhoanTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxMaNV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKoLoc = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cboxChucVu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_TABLE)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(196, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(828, 67);
            this.label1.TabIndex = 85;
            this.label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.lblTongTin);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtHienHanh);
            this.groupBox1.Controls.Add(this.btnKe);
            this.groupBox1.Controls.Add(this.btnTruoc);
            this.groupBox1.Controls.Add(this.btnDau);
            this.groupBox1.Controls.Add(this.btnCuoi);
            this.groupBox1.Controls.Add(this.dgvTaiKhoan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(78, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 613);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            // 
            // lblTongTin
            // 
            this.lblTongTin.AutoSize = true;
            this.lblTongTin.Location = new System.Drawing.Point(727, 556);
            this.lblTongTin.Name = "lblTongTin";
            this.lblTongTin.Size = new System.Drawing.Size(65, 28);
            this.lblTongTin.TabIndex = 50;
            this.lblTongTin.Text = "label4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(700, 556);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 28);
            this.label12.TabIndex = 49;
            this.label12.Text = "of";
            // 
            // txtHienHanh
            // 
            this.txtHienHanh.Location = new System.Drawing.Point(490, 551);
            this.txtHienHanh.Name = "txtHienHanh";
            this.txtHienHanh.Size = new System.Drawing.Size(201, 34);
            this.txtHienHanh.TabIndex = 48;
            // 
            // btnKe
            // 
            this.btnKe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnKe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKe.Location = new System.Drawing.Point(337, 540);
            this.btnKe.Name = "btnKe";
            this.btnKe.Size = new System.Drawing.Size(58, 44);
            this.btnKe.TabIndex = 46;
            this.btnKe.Text = ">";
            this.btnKe.UseVisualStyleBackColor = false;
            this.btnKe.Click += new System.EventHandler(this.btnKe_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTruoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTruoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTruoc.Location = new System.Drawing.Point(273, 539);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(58, 44);
            this.btnTruoc.TabIndex = 47;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDau
            // 
            this.btnDau.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDau.Location = new System.Drawing.Point(209, 539);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(58, 44);
            this.btnDau.TabIndex = 44;
            this.btnDau.Text = "<<";
            this.btnDau.UseVisualStyleBackColor = false;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCuoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCuoi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCuoi.Location = new System.Drawing.Point(401, 539);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(58, 44);
            this.btnCuoi.TabIndex = 45;
            this.btnCuoi.Text = ">>";
            this.btnCuoi.UseVisualStyleBackColor = false;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowCustomTheming = false;
            this.dgvTaiKhoan.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaiKhoan.ColumnHeadersHeight = 40;
            this.dgvTaiKhoan.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvTaiKhoan.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTaiKhoan.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTaiKhoan.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTaiKhoan.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTaiKhoan.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTaiKhoan.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTaiKhoan.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvTaiKhoan.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvTaiKhoan.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.CurrentTheme.Name = null;
            this.dgvTaiKhoan.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTaiKhoan.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTaiKhoan.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTaiKhoan.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTaiKhoan.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTaiKhoan.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvTaiKhoan.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(36, 34);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 40;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(976, 468);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.qLBH_TABLE;
            // 
            // qLBH_TABLE
            // 
            this.qLBH_TABLE.DataSetName = "QLBH_TABLE";
            this.qLBH_TABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.cboxMaNV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnKoLoc);
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.cboxChucVu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(78, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1042, 92);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // cboxMaNV
            // 
            this.cboxMaNV.FormattingEnabled = true;
            this.cboxMaNV.Location = new System.Drawing.Point(158, 34);
            this.cboxMaNV.Name = "cboxMaNV";
            this.cboxMaNV.Size = new System.Drawing.Size(206, 36);
            this.cboxMaNV.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 77;
            this.label2.Text = "Mã NV:";
            // 
            // btnKoLoc
            // 
            this.btnKoLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKoLoc.Location = new System.Drawing.Point(890, 24);
            this.btnKoLoc.Name = "btnKoLoc";
            this.btnKoLoc.Size = new System.Drawing.Size(122, 49);
            this.btnKoLoc.TabIndex = 76;
            this.btnKoLoc.Text = "Không Lọc";
            this.btnKoLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKoLoc.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(762, 26);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(122, 47);
            this.btnLoc.TabIndex = 75;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // cboxChucVu
            // 
            this.cboxChucVu.FormattingEnabled = true;
            this.cboxChucVu.Location = new System.Drawing.Point(514, 34);
            this.cboxChucVu.Name = "cboxChucVu";
            this.cboxChucVu.Size = new System.Drawing.Size(206, 36);
            this.cboxChucVu.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 28);
            this.label7.TabIndex = 73;
            this.label7.Text = "Chức vụ:";
            // 
            // FormTaiKhoan_QLTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1219, 907);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormTaiKhoan_QLTT";
            this.Text = "FormTaiKhoan_QLTT";
            this.Load += new System.EventHandler(this.FormTaiKhoan_PQ_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_TABLE)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvTaiKhoan;
        private System.Windows.Forms.Label lblTongTin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHienHanh;
        private System.Windows.Forms.Button btnKe;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnCuoi;
        private QLBH_TABLE qLBH_TABLE;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private QLBH_TABLETableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboxMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKoLoc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cboxChucVu;
        private System.Windows.Forms.Label label7;
    }
}