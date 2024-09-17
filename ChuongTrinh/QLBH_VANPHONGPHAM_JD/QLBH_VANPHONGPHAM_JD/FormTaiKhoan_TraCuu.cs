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
    public partial class FormTaiKhoan_TraCuu : Form
    {
        KetNoi data = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private BindingSource bdsourceNV = new BindingSource();
        public FormTaiKhoan_TraCuu()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            bdsource.DataSource = data.ThongTinTK();
            dgvTaiKhoan.DataSource = bdsource;
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();
            // thay đổi độ rộng ô
            dgvTaiKhoan.Columns[0].Width = 150;
            dgvTaiKhoan.Columns[1].Width = 150;
            dgvTaiKhoan.Columns[2].Width = 150;
            dgvTaiKhoan.Columns[3].Width = 180;
 

            // màu dòng
            dgvTaiKhoan.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvTaiKhoan.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvTaiKhoan.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // nạp dữ liệu combo box mã nhân viên
            cboxMaNV.Items.Clear();
            bdsourceNV.DataSource = data.ThongTinNV();
            foreach (DataRowView row in bdsourceNV)
            {
                string idnv = row["MaNV"].ToString();
                if (!cboxMaNV.Items.Contains(idnv))
                {
                    cboxMaNV.Items.Add(idnv);
                }
            }

            // nạp dữ liệu combo box chức vụ
            cboxChucVu.Items.Clear();
            foreach (DataRowView row in bdsource)
            {
                string cv = row["ChucVu"].ToString();
                if (!cboxChucVu.Items.Contains(cv))
                {
                    cboxChucVu.Items.Add(cv);
                }

            }

        }

        private void btnKoLoc_Click(object sender, EventArgs e)
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string manv = cboxMaNV.Text;
            string chucvu = cboxChucVu.Text;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TaiKhoan where MaNV = '" + manv + "' or ChucVu = '" + chucvu + "'", data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                bdsource.DataSource = dt;
                dgvTaiKhoan.DataSource = bdsource;
                txtHienHanh.Text = (bdsource.Position + 1).ToString();
                lblTongTin.Text = bdsource.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy nhân viên ! " + ex.Message, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTaiKhoan_TraCuu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
