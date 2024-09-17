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
    public partial class FormThongTin : Form
    {
        //khái báo biến về form hiện tại là form trang chủ
        private Form currentFrch;
        KetNoi data = new KetNoi();
        public FormThongTin()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form currentFrch, Panel Panel_Body, Form frch)
        {
            if (currentFrch != null)
            {
                currentFrch.Close();
            }
            currentFrch = frch;
            frch.TopLevel = false;
            frch.FormBorderStyle = FormBorderStyle.None;
            frch.Dock = DockStyle.Fill;
            Panel_Body.Controls.Add(frch);
            Panel_Body.Tag = frch;
            frch.BringToFront();
            frch.Show();
        }


        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormDangNhap.LoggedInUser != null)
            {
                string dn = FormDangNhap.LoggedInUser.Username;
                string sql = "select * from TaiKhoan JOIN NhanVien ON TaiKhoan.MaNV = NhanVien.ManV where TenDN = N'" + dn + "'";
                SqlCommand cmd = new SqlCommand(sql, data.GetConnect());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    MessageBox.Show("Nhân Viên không có quyền truy cập!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FormThongTin_NhanVien formNV = new FormThongTin_NhanVien();
                    OpenChildForm(currentFrch, panelTT, formNV);
                }

            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTin_SanPham formSP = new FormThongTin_SanPham();
            OpenChildForm(currentFrch, panelTT, formSP);
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTin_LoaiSP formLSP = new FormThongTin_LoaiSP();
            OpenChildForm(currentFrch, panelTT, formLSP);
        }
    }
}
