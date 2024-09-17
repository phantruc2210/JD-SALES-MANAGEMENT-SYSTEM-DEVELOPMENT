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
    public partial class FormTrangChu : Form
    {
        FormDangNhap form = new FormDangNhap();

        //khái báo biến về form hiện tại là form trang chủ
        private Form currentFrch;
        KetNoi data = new KetNoi();
        public FormTrangChu(FormDangNhap formdn)
        {
            InitializeComponent();
            this.form = formdn;
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            
            if (FormDangNhap.LoggedInUser != null)
            {
                string dn = FormDangNhap.LoggedInUser.Username;
                string sql = "select * from TaiKhoan JOIN NhanVien ON TaiKhoan.MaNV = NhanVien.ManV where TenDN = N'" + dn + "'";
                SqlCommand cmd = new SqlCommand(sql, data.GetConnect());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {

                        labelUser.Text = (reader["HoNV"].ToString() + " " + reader["TenNV"].ToString()).ToUpper();  
                }
                else
                {
                    labelUser.Text = "QUẢN LÝ";
                }    

            }

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

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FormTaiKhoan formTK = new FormTaiKhoan();
            OpenChildForm(currentFrch, panelBody, formTK);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            FormThongTin formTT = new FormThongTin();
            OpenChildForm(currentFrch, panelBody, formTT);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapHang formNH = new FormNhapHang();
            OpenChildForm(currentFrch, panelBody, formNH);
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            FormXuatHang formXH = new FormXuatHang();
            OpenChildForm(currentFrch, panelBody, formXH);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            FormBanHang formBH = new FormBanHang();
            OpenChildForm(currentFrch, panelBody, formBH);
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            FormTroGiup formTG = new FormTroGiup();
            OpenChildForm(currentFrch, panelBody, formTG);
        }

        private void FormTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            this.form.Dispose();
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất ?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap dn = new FormDangNhap();
                dn.ShowDialog();

            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FormBaoCao formBC = new FormBaoCao();
            OpenChildForm(currentFrch, panelBody, formBC);
        }
    }
}
