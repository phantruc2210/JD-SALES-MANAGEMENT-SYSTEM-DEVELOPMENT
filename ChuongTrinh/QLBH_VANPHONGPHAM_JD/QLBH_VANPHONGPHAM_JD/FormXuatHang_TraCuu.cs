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
    public partial class FormXuatHang_TraCuu : Form
    {
        KetNoi data = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private BindingSource bdsourceCTPX = new BindingSource();
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
        private void LoadData()
        {
            bdsource.DataSource = data.ThongTinPX();
            dgvPX.DataSource = bdsource;

            // màu dòng
            //dgvPX.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            //dgvPX.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            //dgvPX.DefaultCellStyle.SelectionForeColor = Color.Black;
            //dgvPX.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // thay đổi độ rộng ô
            dgvPX.Columns[0].Width = 120;
            dgvPX.Columns[1].Width = 220;
            dgvPX.Columns[2].Width = 220;
            dgvPX.Columns[3].Width = 225;
            dgvPX.Columns[4].Width = 220;
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

        private void dgvPX_SelectionChanged(object sender, EventArgs e)
        {
            string sopx = dgvPX.CurrentRow.Cells[0].Value.ToString();
            // HIỂN THỊ CHI TIẾT PHIẾU XUẤT
            bdsourceCTPX.DataSource = data.ThongTinCTPX(sopx);
            dgvCTPX.DataSource = bdsourceCTPX;
            dgvCTPX.Columns[0].Width = 110;
            dgvCTPX.Columns[1].Width = 110;
            dgvCTPX.Columns[2].Width = 110;
            dgvCTPX.Columns[3].Width = 110;

            // tính tổng tiền trên mỗi phiếu xuất
            tong = data.TienTrenPX(sopx);
            txtTongTienPX.Text = String.Format("{0:0,000 VND}", tong);
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
                SqlDataAdapter da = new SqlDataAdapter("select * from PhieuXuat where NgayXuat between '" + tungay + "' and '" + denngay + "'", data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                bdsource.DataSource = dt;
                dgvPX.DataSource = bdsource;
                // thay đổi độ rộng ô
                dgvPX.Columns[0].Width = 120;
                dgvPX.Columns[1].Width = 220;
                dgvPX.Columns[2].Width = 220;
                dgvPX.Columns[3].Width = 225;
                dgvPX.Columns[4].Width = 220;

                labelKQ.Text = "ĐÃ TÌM THẤY PHIẾU XUẤT ! ";
            }
            catch (Exception ex)
            {
                labelKQ.Text = "KHÔNG TÌM THẤY PHIẾU XUẤT ! ";
                MessageBox.Show("Không tìm thấy phiếu xuất ! " + ex.Message, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKoLoc_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FormXuatHang_TraCuu_Load(object sender, EventArgs e)
        {
            LoadData();
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

        public FormXuatHang_TraCuu()
        {
            InitializeComponent();
        }
    }
}
