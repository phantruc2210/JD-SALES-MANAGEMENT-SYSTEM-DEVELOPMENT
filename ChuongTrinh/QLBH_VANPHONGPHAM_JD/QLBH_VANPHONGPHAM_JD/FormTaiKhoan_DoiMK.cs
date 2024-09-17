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
    public partial class FormTaiKhoan_DoiMK : Form
    {
        KetNoi data = new KetNoi();
        public FormTaiKhoan_DoiMK()
        {
            InitializeComponent();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                string dn = txtTenDN.Text;
                string mk = txtMKCu.Text;

                string sql = "select * from TaiKhoan where TenDN = N'" + dn + "' and MatKhau ='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, data.GetConnect());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    if (txtMKMoi.Text == txtMKMoi.Text)
                    {
                        data.ExecuteNonQuery(@"update TaiKhoan set MatKhau ='" + txtMKMoi.Text + "'where TenDN = N'" + dn + "' and MatKhau = '" + txtMKCu.Text + "'");
                        MessageBox.Show(" Đổi mật khẩu thành công !", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại mật khẩu mới sai !", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Mật khẩu hoặc tên đăng nhập sai !", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đổi mật khẩu không thành công! Lỗi " + ex.Message, "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // yêu cầu người dùng quay về đăng nhập/ trang chủ
            DialogResult result = MessageBox.Show("Bạn muốn đăng nhập lại không ?", "Đổi Mật Khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Quay về trang đăng nhập!", "Đổi Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormDangNhap dn = new FormDangNhap();
                dn.ShowDialog();
            }
        }
    }
}
