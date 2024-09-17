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
    public partial class FormBanHang_TraCuu : Form
    {
        KetNoi data = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private BindingSource bdsourceCTHD = new BindingSource();
        private BindingSource bdsourceNV = new BindingSource();
        double tong, thue, chietkhau, tongtien;

        private void btnKe_Click(object sender, EventArgs e)
        {
            bdsource.Position += 1;
            //txtHienHanh.Text = (bdsource.Position + 1).ToString();
            //lblTongTin.Text = bdsource.Count.ToString();

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
            //txtHienHanh.Text = (bdsource.Position + 1).ToString();
            //lblTongTin.Text = bdsource.Count.ToString();

            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
            btnKe.Enabled = false;
            btnCuoi.Enabled = false;
        }

        private void dgvHD_SelectionChanged(object sender, EventArgs e)
        {
            string mahd = dgvHD.CurrentRow.Cells[0].Value.ToString();
            // HIỂN THỊ CHI TIẾT HÓA ĐƠN
            bdsourceCTHD.DataSource = data.ThongTinCTHD(mahd);
            dgvCTHD.DataSource = bdsourceCTHD;
            dgvCTHD.Columns[0].Width = 110;
            dgvCTHD.Columns[1].Width = 110;
            dgvCTHD.Columns[2].Width = 110;
            dgvCTHD.Columns[3].Width = 110;

            // tính tổng tiền trên mỗi hóa đơn
            tong = data.TienTrenHD(mahd);
            txtTongTienHD.Text = String.Format("{0:0,000 VND}", tong);
            txtThue.Text = String.Format("{0:0,000 VND}", 1000);
            txtChietKhau.Text = String.Format("{0:0,000 VND}", 0);
            txtTongTien.Text = String.Format("{0:0,000 VND}", (tong - 1000 - 0));
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string tungay = dtpTuNgay.Value.ToString("MM/dd/yyyy");
            string denngay = dtpDenNgay.Value.ToString("MM/dd/yyyy");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon where NgayDH between '" + tungay + "' and '" + denngay + "'", data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                bdsource.DataSource = dt;
                dgvHD.DataSource = bdsource;
                // thay đổi độ rộng ô
                dgvHD.Columns[0].Width = 120;
                dgvHD.Columns[1].Width = 220;
                dgvHD.Columns[2].Width = 220;
                dgvHD.Columns[3].Width = 225;
                dgvHD.Columns[4].Width = 220;

                labelKQ.Text = "ĐÃ TÌM THẤY HÓA ĐƠN ! ";
            }
            catch (Exception ex)
            {
                labelKQ.Text = "KHÔNG TÌM THẤY HÓA ĐƠN ! ";
                MessageBox.Show("Không tìm thấy hóa đơn ! " + ex.Message, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            bdsource.DataSource = data.ThongTinHD();
            dgvHD.DataSource = bdsource;

            // màu dòng
            //dgvHD.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            //dgvHD.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            //dgvHD.DefaultCellStyle.SelectionForeColor = Color.Black;
            //dgvHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // thay đổi độ rộng ô
            dgvHD.Columns[0].Width = 120;
            dgvHD.Columns[1].Width = 220;
            dgvHD.Columns[2].Width = 220;
            dgvHD.Columns[3].Width = 225;
            dgvHD.Columns[4].Width = 220;
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


        }

        private void FormBanHang_TraCuu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnKoLoc_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvHD_SelectionChanged_1(object sender, EventArgs e)
        {

        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            bdsource.Position -= 1;
            //txtHienHanh.Text = (bdsource.Position + 1).ToString();
            //lblTongTin.Text = bdsource.Count.ToString();

            if (bdsource.Position == 0)
            {
                btnTruoc.Enabled = false;
                btnDau.Enabled = false;
            }
            btnKe.Enabled = true;
            btnCuoi.Enabled = true;
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            //txtHienHanh.Text = (bdsource.Position + 1).ToString();
            //lblTongTin.Text = bdsource.Count.ToString();

            btnTruoc.Enabled = false;
            btnDau.Enabled = false;
            btnKe.Enabled = true;
            btnCuoi.Enabled = true;
        }

        public FormBanHang_TraCuu()
        {
            InitializeComponent();
        }
    }
}
