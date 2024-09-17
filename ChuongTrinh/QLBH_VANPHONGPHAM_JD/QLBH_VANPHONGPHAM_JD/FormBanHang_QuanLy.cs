using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_VANPHONGPHAM_JD
{
    public partial class FormBanHang_QuanLy : Form
    {
        KetNoi data = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private BindingSource bdsourceNV = new BindingSource();
        private BindingSource bdsourceKH = new BindingSource();
        public FormBanHang_QuanLy()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            bdsource.DataSource = data.ThongTinHD();
            dgvHD.DataSource = bdsource;
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();
            // màu dòng
            //dgvHD.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            //dgvHD.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            //dgvHD.DefaultCellStyle.SelectionForeColor = Color.Black;
            //dgvHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // thay đổi độ rộng ô
            dgvHD.Columns[0].Width = 120;
            dgvHD.Columns[1].Width = 120;
            dgvHD.Columns[2].Width = 150;
            dgvHD.Columns[3].Width = 125;
            dgvHD.Columns[4].Width = 120;
            // nạp dữ liệu combo box mã nhân viên
            bdsourceNV.DataSource = data.ThongTinNV();
            cboxMaNV.Items.Clear();
            foreach (DataRowView row in bdsourceNV)
            {
                string idnv = row["MaNV"].ToString();
                if (!cboxMaNV.Items.Contains(idnv))
                {
                    cboxMaNV.Items.Add(idnv);
                }

            }
            // nạp dữ liệu combo box mã khách hàng
            bdsourceKH.DataSource = data.ThongTinKH();
            cboxMaKH.Items.Clear();
            foreach (DataRowView row in bdsourceKH)
            {
                string idkh = row["MaKH"].ToString();
                if (!cboxMaKH.Items.Contains(idkh))
                {
                    cboxMaKH.Items.Add(idkh);
                }

            }

        }

        private void FormBanHang_QuanLy_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();

            btnTruoc.Enabled = false;
            btnDau.Enabled = false;
            btnKe.Enabled = true;
            btnCuoi.Enabled = true;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            bdsource.Position -= 1;
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();

            if (bdsource.Position == 0)
            {
                btnTruoc.Enabled = false;
                btnDau.Enabled = false;
            }
            btnKe.Enabled = true;
            btnCuoi.Enabled = true;
        }

        private void btnKe_Click(object sender, EventArgs e)
        {
            bdsource.Position += 1;
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();

            if (bdsource.Position == bdsource.Count - 1)
            {
                btnKe.Enabled = false;
                btnCuoi.Enabled = false;
            }
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bdsource.Position = bdsource.Count - 1;
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();

            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
            btnKe.Enabled = false;
            btnCuoi.Enabled = false;
        }

        private void dgvCTHD_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvHD_SelectionChanged(object sender, EventArgs e)
        {
            txtMaHD.Text = dgvHD.CurrentRow.Cells[0].Value.ToString();
            dtpNgayDH.Value = (DateTime)dgvHD.CurrentRow.Cells[1].Value;
            txtPTTT.Text = dgvHD.CurrentRow.Cells[2].Value.ToString();
            cboxMaNV.SelectedItem = dgvHD.CurrentRow.Cells["MaNV"].Value.ToString();
            cboxMaKH.SelectedItem = dgvHD.CurrentRow.Cells["MaKH"].Value.ToString();
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            string mahd = dgvHD.CurrentRow.Cells[0].Value.ToString();
            FormBanHang_CTHD cthd = new FormBanHang_CTHD(mahd);
            cthd.Show();

        }
    }
}
