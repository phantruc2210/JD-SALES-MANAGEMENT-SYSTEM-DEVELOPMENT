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
    public partial class FormTaiKhoan : Form
    {
        //khái báo biến về form hiện tại là form trang chủ
        private Form currentFrch;
        KetNoi data = new KetNoi();
        public FormTaiKhoan()
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

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaiKhoan_TTin formTTin = new FormTaiKhoan_TTin();
            OpenChildForm(currentFrch, panelTK, formTTin);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaiKhoan_DoiMK formdoiMK = new FormTaiKhoan_DoiMK();
            OpenChildForm(currentFrch, panelTK, formdoiMK);
        }

        private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaiKhoan_DK formDK = new FormTaiKhoan_DK();
            OpenChildForm(currentFrch, panelTK, formDK);
        }


        private void quảnLýThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormDangNhap.LoggedInUser != null)
            {
                string dn = FormDangNhap.LoggedInUser.Username;
                string sql = "select * from TaiKhoan JOIN NhanVien ON TaiKhoan.MaNV = NhanVien.ManV where TenDN = N'" + dn + "'";
                SqlCommand cmd = new SqlCommand(sql, data.GetConnect());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    MessageBox.Show("Nhân Viên không có quyền truy cập!", "Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FormTaiKhoan_QLTT formQLTT = new FormTaiKhoan_QLTT();
                    OpenChildForm(currentFrch, panelTK, formQLTT);
                }

            }
        }
    }
}
