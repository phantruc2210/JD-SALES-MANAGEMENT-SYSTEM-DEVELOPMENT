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
    public partial class FormNhapHang_QL : Form
    {
        KetNoi data = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private BindingSource bdsourceCTPN = new BindingSource();
        private BindingSource bdsourceNV = new BindingSource();
        private BindingSource bdsourceNCC = new BindingSource();
        private BindingSource bdsourceSP = new BindingSource();
        public FormNhapHang_QL()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            bdsource.DataSource = data.ThongTinPN();
            dgvPN.DataSource = bdsource;
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();
            // màu dòng
            //dgvPN.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            //dgvPN.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            //dgvPN.DefaultCellStyle.SelectionForeColor = Color.Black;
            //dgvPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // thay đổi độ rộng ô
            dgvPN.Columns[0].Width = 100;
            dgvPN.Columns[1].Width = 100;
            dgvPN.Columns[2].Width = 70;
            dgvPN.Columns[3].Width = 125;
            dgvPN.Columns[4].Width = 120;
            dgvPN.Columns[5].Width = 120;
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
            // nạp dữ liệu combo box mã nhà cung cấp
            bdsourceNCC.DataSource = data.ThongTinNCC();
            cboxMaNCC.Items.Clear();
            foreach (DataRowView row in bdsourceNCC)
            {
                string idncc = row["MaNCC"].ToString();
                if (!cboxMaNCC.Items.Contains(idncc))
                {
                    cboxMaNCC.Items.Add(idncc);
                }

            }
            

        }

        private void FormNhapHang_QL_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPN_SelectionChanged(object sender, EventArgs e)
        {
            txtSoPN.Text = dgvPN.CurrentRow.Cells[0].Value.ToString();
            dtpNgayNhap.Value = (DateTime)dgvPN.CurrentRow.Cells[1].Value;
            txtGhiChu.Text = dgvPN.CurrentRow.Cells[2].Value.ToString();
            txtPTTT.Text = dgvPN.CurrentRow.Cells[3].Value.ToString();
            cboxMaNV.SelectedItem = dgvPN.CurrentRow.Cells["MaNV"].Value.ToString();
            cboxMaNCC.SelectedItem = dgvPN.CurrentRow.Cells["MaNCC"].Value.ToString();

            
            // tính tổng tiền trên mỗi phiếu nhập
            //double tong = data.TienTrenPN(txtSoPN.Text);
            //txtTongTien.Text = String.Format("{0:0,000 VND}", tong);
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

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            string pn = dgvPN.CurrentRow.Cells[0].Value.ToString();
            FormNhapHang_CTPN ctpn = new FormNhapHang_CTPN(pn);
            ctpn.Show();
        }
    }
}
