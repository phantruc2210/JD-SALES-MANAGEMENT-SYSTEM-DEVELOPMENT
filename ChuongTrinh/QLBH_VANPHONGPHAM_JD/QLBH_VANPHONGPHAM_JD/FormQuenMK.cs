using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH_VANPHONGPHAM_JD
{
    public partial class FormQuenMK : Form
    {
        private string maXacMinh, tenDN;
        KetNoi data = new KetNoi();
        public FormQuenMK()
        {
            InitializeComponent();
        }

        private void linkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormDangNhap dn = new FormDangNhap();
            dn.Show();
        }
        
        private string TaoMaXacMinh()
        {
            Random random = new Random();
            int ma = random.Next(100000, 1000000); // Tạo mã số ngẫu nhiên từ 100000 đến 999999 (6 chữ số)
            return ma.ToString();
        }

        private bool GuiEmailXacMinh(string email, string maXacMinh)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.To.Add(email);
                mail.From = new MailAddress("2121005137@sv.ufm.edu.vn");
                mail.Subject = "Gởi từ HTQLBH Văn Phòng Phẩm JD. Xác minh địa chỉ email lấy lại mật khẩu";
                string body = "Mã xác minh lấy lại mật khẩu của bạn là: " + maXacMinh +
                    ". Không chia sẻ mã này với bất cứ ai. Xin cảm ơn!";
                mail.Body = body;
                SmtpClient client = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("2121005137@sv.ufm.edu.vn", "Oin11469")
                };
                try
                {
                    client.Send(mail);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        private bool KiemTraTenDangNhap(string tenDN)
        {
            string sql = "SELECT * FROM TaiKhoan WHERE TenDN = @TenDN";
            SqlCommand cmd = new SqlCommand(sql, data.GetConnect());
            cmd.Parameters.AddWithValue("@TenDN", tenDN);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLayLaiMK_Click(object sender, EventArgs e)
        {
            tenDN = txtTenDN.Text.Trim();
            if (KiemTraTenDangNhap(tenDN))
            {
                maXacMinh = TaoMaXacMinh();
                bool result = GuiEmailXacMinh(txtEmail.Text, maXacMinh);
                if (result)
                {
                    this.Hide();
                    FormXacNhanLayMK xn = new FormXacNhanLayMK(maXacMinh, tenDN);
                    xn.Show();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi gửi email xác minh!", "Xác Minh Email Lấy Lại Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
