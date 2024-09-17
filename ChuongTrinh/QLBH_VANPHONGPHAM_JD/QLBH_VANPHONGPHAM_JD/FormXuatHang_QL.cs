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
    public partial class FormXuatHang_QL : Form
    {
        KetNoi data = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private BindingSource bdsourceNV = new BindingSource();
        private BindingSource bdsourceCH = new BindingSource();
        public FormXuatHang_QL()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            bdsource.DataSource = data.ThongTinPX();
            dgvPX.DataSource = bdsource;
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();
            // màu dòng
            //dgvPX.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            //dgvPX.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            //dgvPX.DefaultCellStyle.SelectionForeColor = Color.Black;
            //dgvPX.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // thay đổi độ rộng ô
            dgvPX.Columns[0].Width = 120;
            dgvPX.Columns[1].Width = 120;
            dgvPX.Columns[2].Width = 150;
            dgvPX.Columns[3].Width = 125;
            dgvPX.Columns[4].Width = 120;
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
            // nạp dữ liệu combo box mã cửa hàng
            bdsourceCH.DataSource = data.ThongTinCH();
            cboxMaCH.Items.Clear();
            foreach (DataRowView row in bdsourceCH)
            {
                string idch = row["MaCH"].ToString();
                if (!cboxMaCH.Items.Contains(idch))
                {
                    cboxMaCH.Items.Add(idch);
                }

            }
           

        }

        private void FormXuatHang_QL_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPX_SelectionChanged(object sender, EventArgs e)
        {
            txtSoPX.Text = dgvPX.CurrentRow.Cells[0].Value.ToString();
            dtpNgayXuat.Value = (DateTime)dgvPX.CurrentRow.Cells[1].Value;
            txtPTTT.Text = dgvPX.CurrentRow.Cells[2].Value.ToString();
            cboxMaNV.SelectedItem = dgvPX.CurrentRow.Cells["MaNV"].Value.ToString();
            cboxMaCH.SelectedItem = dgvPX.CurrentRow.Cells["MaCH"].Value.ToString();
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

        private void btnTaoPX_Click(object sender, EventArgs e)
        {
            string px = dgvPX.CurrentRow.Cells[0].Value.ToString();
            FormXuatHang_CTPX ctpx = new FormXuatHang_CTPX(px);
            ctpx.Show();
        }
    }
}
