using QLBH_VANPHONGPHAM_JD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_VANPHONGPHAM_JD
{
    public partial class FormBanHang_CTHD : Form
    {
        private string mahd;
        KetNoi data = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private BindingSource bdsourceSP = new BindingSource();
        public FormBanHang_CTHD(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }
        private void LoadData()
        {
            // nạp dữ liệu cho 1 hóa đơn
            string sql = "SELECT * FROM HoaDon WHERE MaHD = N'" + mahd + "'";
            SqlCommand cmd = new SqlCommand(sql, data.GetConnect());
            SqlDataReader reader = cmd.ExecuteReader();
           if (reader.Read())
           {
                txtMaHD.Text = reader["MaHD"].ToString();
                dtpNgayDH.Value = DateTime.Parse(reader["NgayDH"].ToString());
                txtPTTT.Text = reader["PTTT"].ToString();
                txtMaNV.Text = reader["MaNV"].ToString();
                txtMaKH.Text = reader["MaKH"].ToString();
            }
            reader.Close();
            // thông tin cthd
            bdsource.DataSource = data.ThongTinCTHD(mahd);
            dgvCTHD.DataSource = bdsource;
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();
            // màu dòng
            //dgvHD.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            //dgvHD.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            //dgvHD.DefaultCellStyle.SelectionForeColor = Color.Black;
            //dgvHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // thay đổi độ rộng ô
            dgvCTHD.Columns[0].Width = 120;
            dgvCTHD.Columns[1].Width = 120;
            dgvCTHD.Columns[2].Width = 150;
            dgvCTHD.Columns[3].Width = 125;

            // nạp dữ liệu cho combo box mã sản phẩm
            bdsourceSP.DataSource = data.ThongTinSP();
            cboxTenSP.Items.Clear();
            foreach (DataRowView row in bdsourceSP)
            {
                string namesp = row["TenSP"].ToString();
                if (!cboxTenSP.Items.Contains(namesp))
                {
                    cboxTenSP.Items.Add(namesp);
                }

            }

            // Thiết lập giá trị mặc định cho ComboBox dựa trên giá trị của txtMaSP
            string currentProductCode = txtMaSP.Text;
            if (!string.IsNullOrEmpty(currentProductCode))
            {
                string currentProductName = GetProductName(currentProductCode);
                if (!string.IsNullOrEmpty(currentProductName))
                {
                    cboxTenSP.SelectedItem = currentProductName;
                }
            }
            // tính tổng tiền trên mỗi hóa đơn
            double tong = data.TienTrenHD(mahd);
            txtTongTien.Text = String.Format("{0:0,000 VND}", tong);

        }

        private void FormBanHang_CTHD_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCTHD_SelectionChanged(object sender, EventArgs e)
        {
            txtMaHD2.Text = dgvCTHD.CurrentRow.Cells[0].Value.ToString();
            txtMaSP.Text = dgvCTHD.CurrentRow.Cells["MaSP"].Value.ToString();
            txtSoLuong.Text = dgvCTHD.CurrentRow.Cells[2].Value.ToString();
            txtDonGiaBan.Text = dgvCTHD.CurrentRow.Cells[3].Value.ToString();
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

        private void cboxTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = cboxTenSP.SelectedItem.ToString();
            string productCode = GetProductCode(selectedProductName);
            txtMaSP.Text = productCode;
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            // Cập nhật ComboBox tên sản phẩm khi mã sản phẩm thay đổi
            string productCode = txtMaSP.Text;
            string productName = GetProductName(productCode);
            if (!string.IsNullOrEmpty(productName))
            {
                cboxTenSP.SelectedItem = productName;
            }
        }

        public string GetProductCode(string productName)
        {
            string sql = "SELECT MaSP FROM SanPham WHERE TenSP = N'" + productName + "'";

            SqlCommand cmd = new SqlCommand(sql, data.GetConnect());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return reader["MaSP"].ToString();
            }
            else
            {
                return "";
            }
        }

        public string GetProductName(string productCode)
        {
            string sql = "SELECT TenSP FROM SanPham WHERE MaSP = N'" + productCode + "'";
            SqlCommand cmd = new SqlCommand(sql, data.GetConnect());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return reader["TenSP"].ToString();
            }
            else
            {
                return "";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
