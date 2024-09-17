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
    public partial class FormLayLaiMK : Form
    {
        private string tenDN;
        KetNoi data = new KetNoi();
        public FormLayLaiMK(string tenDN)
        {
            InitializeComponent();
            this.tenDN = tenDN;
        }

        private void linkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormDangNhap dn = new FormDangNhap();
            dn.Show();
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();

            if (matKhauMoi.Equals(xacNhanMatKhau))
            {
                // Cập nhật mật khẩu mới vào cơ sở dữ liệu
                data.ExecuteNonQuery(@"update TaiKhoan set MatKhau ='" +matKhauMoi + "'where TenDN = N'" + tenDN + "'");
                MessageBox.Show(" Đổi mật khẩu thành công !", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
