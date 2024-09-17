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
    public partial class FormNhapHang_CTPN : Form
    {
        private string sopn;
        KetNoi data = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private BindingSource bdsourceSP = new BindingSource();
        public FormNhapHang_CTPN(string sopn)
        {
            InitializeComponent();
            this.sopn = sopn;
        }
        private void LoadData()
        {
            // nạp dữ liệu cho 1 phiếu nhập
            string sql = "SELECT * FROM PhieuNhap WHERE SoPN = N'" + sopn + "'";
            SqlCommand cmd = new SqlCommand(sql, data.GetConnect());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtSoPN.Text = reader["SoPN"].ToString();
                dtpNgayNhap.Value = DateTime.Parse(reader["NgayNhap"].ToString());
                txtGhiChu.Text = reader["GhiChu"].ToString();
                txtPTTT.Text = reader["PTTT"].ToString();
                txtMaNV.Text = reader["MaNV"].ToString();
                txtMaNCC.Text = reader["MaNCC"].ToString();
            }
            reader.Close();
            // thông tin ctpn
            bdsource.DataSource = data.ThongTinCTPN(sopn);
            dgvCTPN.DataSource = bdsource;
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();
            // màu dòng
            //dgvHD.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            //dgvHD.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            //dgvHD.DefaultCellStyle.SelectionForeColor = Color.Black;
            //dgvHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // thay đổi độ rộng ô
            dgvCTPN.Columns[0].Width = 160;
            dgvCTPN.Columns[1].Width = 160;
            dgvCTPN.Columns[2].Width = 160;
            dgvCTPN.Columns[3].Width = 165;

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
            // tính tổng tiền trên mỗi phiếu nhập
            double tong = data.TienTrenPN(sopn);
            txtTongTien.Text = String.Format("{0:0,000 VND}", tong);

        }

        private void FormNhapHang_CTPN_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCTPN_SelectionChanged(object sender, EventArgs e)
        {
            txtSoPN2.Text = dgvCTPN.CurrentRow.Cells[0].Value.ToString();
            txtMaSP.Text = dgvCTPN.CurrentRow.Cells["MaSP"].Value.ToString();
            txtSoLuong.Text = dgvCTPN.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dgvCTPN.CurrentRow.Cells[3].Value.ToString();
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

        private void cboxMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = cboxTenSP.SelectedItem.ToString();
            string productCode = GetProductCode(selectedProductName);
            txtMaSP.Text = productCode;
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
