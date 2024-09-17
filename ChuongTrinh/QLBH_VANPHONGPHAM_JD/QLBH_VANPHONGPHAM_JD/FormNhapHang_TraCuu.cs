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
    public partial class FormNhapHang_TraCuu : Form
    {
        KetNoi data = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private BindingSource bdsourceCTPN = new BindingSource();
        private BindingSource bdsourceNV = new BindingSource();
        double tong, thue, chietkhau, tongtien;

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

        private void dgvPN_SelectionChanged(object sender, EventArgs e)
        {
            string sopn = dgvPN.CurrentRow.Cells[0].Value.ToString();
            // HIỂN THỊ CHI TIẾT PHIẾU NHẬP
            bdsourceCTPN.DataSource = data.ThongTinCTPN(sopn);
            dgvCTPN.DataSource = bdsourceCTPN;
            dgvCTPN.Columns[0].Width = 110;
            dgvCTPN.Columns[1].Width = 110;
            dgvCTPN.Columns[2].Width = 110;
            dgvCTPN.Columns[3].Width = 110;

            // tính tổng tiền trên mỗi phiếu nhập
            tong = data.TienTrenPN(sopn);
            //txtTongTienPN.Text = tong.ToString();
            txtTongTienPN.Text = String.Format("{0:0,000 VND}", tong);
            txtThue.Text = String.Format("{0:0,000 VND}", 1000);
            txtChietKhau.Text = String.Format("{0:0,000 VND}", 0);
            txtTongTien.Text = String.Format("{0:0,000 VND}", (tong - 1000 - 0));
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            /*
            string sopn = txtSoPN.Text;
            if (sopn != "")
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from PhieuNhap where SoPN = '" + sopn + "'", data.GetConnect());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bdsource.DataSource = dt;
                    dgvPN.DataSource = bdsource;
                    // thay đổi độ rộng ô
                    dgvPN.Columns[0].Width = 120;
                    dgvPN.Columns[1].Width = 220;
                    dgvPN.Columns[2].Width = 220;
                    dgvPN.Columns[3].Width = 225;
                    dgvPN.Columns[4].Width = 220;
                    dgvPN.Columns[5].Width = 220;

                    labelKQ.Text = "TÌM THẤY PHIẾU NHẬP " + sopn + " ";
                }
                catch (Exception ex)
                {
                    labelKQ.Text = "KHÔNG TÌM THẤY PHIẾU NHẬP";
                    MessageBox.Show("Không tìm thấy phiếu nhập ! " + ex.Message, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            string tungay = dtpTuNgay.Value.ToString("MM/dd/yyyy");
            string denngay = dtpDenNgay.Value.ToString("MM/dd/yyyy");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PhieuNhap where NgayNhap between '" + tungay + "' and '" + denngay + "'", data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                bdsource.DataSource = dt;
                dgvPN.DataSource = bdsource;
                // thay đổi độ rộng ô
                dgvPN.Columns[0].Width = 120;
                dgvPN.Columns[1].Width = 220;
                dgvPN.Columns[2].Width = 220;
                dgvPN.Columns[3].Width = 225;
                dgvPN.Columns[4].Width = 220;
                dgvPN.Columns[5].Width = 220;

                labelKQ.Text = "ĐÃ TÌM THẤY PHIẾU NHẬP ! ";
            }
            catch (Exception ex)
            {
                labelKQ.Text = "KHÔNG TÌM THẤY PHIẾU NHẬP ! ";
                MessageBox.Show("Không tìm thấy phiếu nhập ! " + ex.Message, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNhapHang_TraCuu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnKoLoc_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public FormNhapHang_TraCuu()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            bdsource.DataSource = data.ThongTinPN();
            dgvPN.DataSource = bdsource;

            // màu dòng
            //dgvPN.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            //dgvPN.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            //dgvPN.DefaultCellStyle.SelectionForeColor = Color.Black;
            //dgvPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // thay đổi độ rộng ô
            dgvPN.Columns[0].Width = 120;
            dgvPN.Columns[1].Width = 220;
            dgvPN.Columns[2].Width = 220;
            dgvPN.Columns[3].Width = 225;
            dgvPN.Columns[4].Width = 220;
            dgvPN.Columns[5].Width = 220;
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
    }
}
