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
    public partial class FormThongTin_NhanVien : Form
    {
        KetNoi data = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        public FormThongTin_NhanVien()
        {
            InitializeComponent();
        }

        private void FormThongTin_NhanVien_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = data.ThongTinNV();
            dgvNhanVien.DataSource = bdsource;
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();
            UpdateNavigationStatus();
        }
        private void UpdateBindingSource()
        {
            UpdateNavigationStatus();
            dgvNhanVien.DataSource = bdsource;
            dgvNhanVien.Refresh();
        }

        private void UpdateNavigationStatus()
        {
            txtHienHanh.Text = (bdsource.Position + 1).ToString();
            lblTongTin.Text = bdsource.Count.ToString();

            btnTruoc.Enabled = bdsource.Position > 0;
            btnDau.Enabled = bdsource.Position > 0;
            btnKe.Enabled = bdsource.Position < bdsource.Count - 1;
            btnCuoi.Enabled = bdsource.Position < bdsource.Count - 1;

        }


        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            UpdateNavigationStatus();
            UpdateBindingSource();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            bdsource.Position--;
            UpdateNavigationStatus();
            UpdateBindingSource();
        }

        private void btnKe_Click(object sender, EventArgs e)
        {
            bdsource.Position++;
            UpdateNavigationStatus();
            UpdateBindingSource();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bdsource.Position = bdsource.Count - 1;
            UpdateNavigationStatus();
            UpdateBindingSource();
        }



    }
}
