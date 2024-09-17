namespace QLBH_VANPHONGPHAM_JD
{
    partial class FormThongTin_LoaiSP
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiSanPham = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.loaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_TABLE = new QLBH_VANPHONGPHAM_JD.QLBH_TABLE();
            this.lblTongTin = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHienHanh = new System.Windows.Forms.TextBox();
            this.btnKe = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.loaiSanPhamTableAdapter = new QLBH_VANPHONGPHAM_JD.QLBH_TABLETableAdapters.LoaiSanPhamTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_TABLE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(363, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 67);
            this.label1.TabIndex = 101;
            this.label1.Text = "QUẢN LÝ LOẠI SẢN PHẨM";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Azure;
            this.groupBox3.Controls.Add(this.dgvLoaiSanPham);
            this.groupBox3.Controls.Add(this.lblTongTin);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtHienHanh);
            this.groupBox3.Controls.Add(this.btnKe);
            this.groupBox3.Controls.Add(this.btnTruoc);
            this.groupBox3.Controls.Add(this.btnDau);
            this.groupBox3.Controls.Add(this.btnCuoi);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(312, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(739, 539);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            // 
            // dgvLoaiSanPham
            // 
            this.dgvLoaiSanPham.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvLoaiSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoaiSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiSanPham.ColumnHeadersHeight = 40;
            this.dgvLoaiSanPham.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvLoaiSanPham.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvLoaiSanPham.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLoaiSanPham.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvLoaiSanPham.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLoaiSanPham.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvLoaiSanPham.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvLoaiSanPham.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvLoaiSanPham.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvLoaiSanPham.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLoaiSanPham.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvLoaiSanPham.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLoaiSanPham.CurrentTheme.Name = null;
            this.dgvLoaiSanPham.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoaiSanPham.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvLoaiSanPham.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLoaiSanPham.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvLoaiSanPham.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiSanPham.EnableHeadersVisualStyles = false;
            this.dgvLoaiSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvLoaiSanPham.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvLoaiSanPham.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvLoaiSanPham.HeaderForeColor = System.Drawing.Color.White;
            this.dgvLoaiSanPham.Location = new System.Drawing.Point(23, 33);
            this.dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            this.dgvLoaiSanPham.RowHeadersVisible = false;
            this.dgvLoaiSanPham.RowHeadersWidth = 51;
            this.dgvLoaiSanPham.RowTemplate.Height = 40;
            this.dgvLoaiSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiSanPham.Size = new System.Drawing.Size(685, 407);
            this.dgvLoaiSanPham.TabIndex = 44;
            this.dgvLoaiSanPham.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // loaiSanPhamBindingSource
            // 
            this.loaiSanPhamBindingSource.DataMember = "LoaiSanPham";
            this.loaiSanPhamBindingSource.DataSource = this.qLBH_TABLE;
            // 
            // qLBH_TABLE
            // 
            this.qLBH_TABLE.DataSetName = "QLBH_TABLE";
            this.qLBH_TABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTongTin
            // 
            this.lblTongTin.AutoSize = true;
            this.lblTongTin.Location = new System.Drawing.Point(593, 481);
            this.lblTongTin.Name = "lblTongTin";
            this.lblTongTin.Size = new System.Drawing.Size(65, 28);
            this.lblTongTin.TabIndex = 43;
            this.lblTongTin.Text = "label4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(566, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 28);
            this.label12.TabIndex = 42;
            this.label12.Text = "of";
            // 
            // txtHienHanh
            // 
            this.txtHienHanh.Location = new System.Drawing.Point(356, 476);
            this.txtHienHanh.Name = "txtHienHanh";
            this.txtHienHanh.Size = new System.Drawing.Size(201, 34);
            this.txtHienHanh.TabIndex = 41;
            // 
            // btnKe
            // 
            this.btnKe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnKe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKe.Location = new System.Drawing.Point(203, 465);
            this.btnKe.Name = "btnKe";
            this.btnKe.Size = new System.Drawing.Size(58, 44);
            this.btnKe.TabIndex = 39;
            this.btnKe.Text = ">";
            this.btnKe.UseVisualStyleBackColor = false;
            this.btnKe.Click += new System.EventHandler(this.btnKe_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTruoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTruoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTruoc.Location = new System.Drawing.Point(139, 464);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(58, 44);
            this.btnTruoc.TabIndex = 40;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDau
            // 
            this.btnDau.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDau.Location = new System.Drawing.Point(75, 464);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(58, 44);
            this.btnDau.TabIndex = 37;
            this.btnDau.Text = "<<";
            this.btnDau.UseVisualStyleBackColor = false;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCuoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCuoi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCuoi.Location = new System.Drawing.Point(267, 464);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(58, 44);
            this.btnCuoi.TabIndex = 38;
            this.btnCuoi.Text = ">>";
            this.btnCuoi.UseVisualStyleBackColor = false;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // loaiSanPhamTableAdapter
            // 
            this.loaiSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // FormThongTin_LoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1738, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormThongTin_LoaiSP";
            this.Text = "FormThongTin_LoaiSP";
            this.Load += new System.EventHandler(this.FormThongTin_LoaiSP_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_TABLE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvLoaiSanPham;
        private System.Windows.Forms.Label lblTongTin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHienHanh;
        private System.Windows.Forms.Button btnKe;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnCuoi;
        private QLBH_TABLE qLBH_TABLE;
        private System.Windows.Forms.BindingSource loaiSanPhamBindingSource;
        private QLBH_TABLETableAdapters.LoaiSanPhamTableAdapter loaiSanPhamTableAdapter;
    }
}