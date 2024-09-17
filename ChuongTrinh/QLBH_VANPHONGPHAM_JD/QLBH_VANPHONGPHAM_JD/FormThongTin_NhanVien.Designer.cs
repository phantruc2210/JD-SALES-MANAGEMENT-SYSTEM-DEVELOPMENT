namespace QLBH_VANPHONGPHAM_JD
{
    partial class FormThongTin_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongTin_NhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTongTin = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHienHanh = new System.Windows.Forms.TextBox();
            this.btnKe = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.dgvNhanVien = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_TABLE = new QLBH_VANPHONGPHAM_JD.QLBH_TABLE();
            this.nhanVienTableAdapter = new QLBH_VANPHONGPHAM_JD.QLBH_TABLETableAdapters.NhanVienTableAdapter();
            this.bunifuGroupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_TABLE)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BackColor = System.Drawing.Color.Azure;
            this.bunifuGroupBox2.BorderColor = System.Drawing.SystemColors.Control;
            this.bunifuGroupBox2.BorderRadius = 1;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.button5);
            this.bunifuGroupBox2.Controls.Add(this.button6);
            this.bunifuGroupBox2.Controls.Add(this.comboBox1);
            this.bunifuGroupBox2.Controls.Add(this.label8);
            this.bunifuGroupBox2.Controls.Add(this.textBox2);
            this.bunifuGroupBox2.Controls.Add(this.label9);
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(43, 102);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(1413, 84);
            this.bunifuGroupBox2.TabIndex = 89;
            this.bunifuGroupBox2.TabStop = false;
            this.bunifuGroupBox2.Text = "Tìm Kiếm";
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(851, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 49);
            this.button5.TabIndex = 82;
            this.button5.Text = "Không Lọc";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(723, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 47);
            this.button6.TabIndex = 81;
            this.button6.Text = "Lọc";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 36);
            this.comboBox1.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 28);
            this.label8.TabIndex = 79;
            this.label8.Text = "Tên NV:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(486, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 34);
            this.textBox2.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 28);
            this.label9.TabIndex = 77;
            this.label9.Text = "Mã NV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(392, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 61);
            this.label1.TabIndex = 88;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
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
            this.groupBox1.Controls.Add(this.dgvNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(43, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 691);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            // 
            // lblTongTin
            // 
            this.lblTongTin.AutoSize = true;
            this.lblTongTin.Location = new System.Drawing.Point(878, 638);
            this.lblTongTin.Name = "lblTongTin";
            this.lblTongTin.Size = new System.Drawing.Size(65, 28);
            this.lblTongTin.TabIndex = 50;
            this.lblTongTin.Text = "label4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(851, 638);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 28);
            this.label12.TabIndex = 49;
            this.label12.Text = "of";
            // 
            // txtHienHanh
            // 
            this.txtHienHanh.Location = new System.Drawing.Point(641, 633);
            this.txtHienHanh.Name = "txtHienHanh";
            this.txtHienHanh.Size = new System.Drawing.Size(201, 34);
            this.txtHienHanh.TabIndex = 48;
            // 
            // btnKe
            // 
            this.btnKe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnKe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKe.Location = new System.Drawing.Point(488, 622);
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
            this.btnTruoc.Location = new System.Drawing.Point(424, 621);
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
            this.btnDau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDau.Location = new System.Drawing.Point(360, 621);
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
            this.btnCuoi.Location = new System.Drawing.Point(552, 621);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(58, 44);
            this.btnCuoi.TabIndex = 45;
            this.btnCuoi.Text = ">>";
            this.btnCuoi.UseVisualStyleBackColor = false;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.ColumnHeadersHeight = 40;
            this.dgvNhanVien.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNhanVien.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNhanVien.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvNhanVien.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvNhanVien.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.CurrentTheme.Name = null;
            this.dgvNhanVien.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNhanVien.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNhanVien.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.Location = new System.Drawing.Point(20, 34);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 40;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1371, 562);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLBH_TABLE;
            // 
            // qLBH_TABLE
            // 
            this.qLBH_TABLE.DataSetName = "QLBH_TABLE";
            this.qLBH_TABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // FormThongTin_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1563, 933);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuGroupBox2);
            this.Controls.Add(this.label1);
            this.Name = "FormThongTin_NhanVien";
            this.Text = "FormThongTin_NhanVien";
            this.Load += new System.EventHandler(this.FormThongTin_NhanVien_Load);
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_TABLE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvNhanVien;
        private QLBH_TABLE qLBH_TABLE;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLBH_TABLETableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.Label lblTongTin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHienHanh;
        private System.Windows.Forms.Button btnKe;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnCuoi;
    }
}