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

namespace QLBH_VANPHONGPHAM_JD
{
    public partial class FormXacNhanLayMK : Form
    {
        private string maXacMinh;
        private string tenDN;
        public FormXacNhanLayMK(string maXacMinh, string tenDN)
        {
            InitializeComponent();
            this.maXacMinh = maXacMinh;
            this.tenDN = tenDN;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            string nhapMaXacMinh = txtMaXacNhan.Text.Trim();

            if (nhapMaXacMinh.Equals(maXacMinh))
            {
                // Mã xác minh đúng, chuyển hướng đến trang FormLayLaiMK
                this.Hide();
                FormLayLaiMK frmLayLaiMK = new FormLayLaiMK(tenDN);
                frmLayLaiMK.Show();
            }
            else
            {
                // Hiển thị thông báo lỗi
                string errorMessage = "Mã xác minh không đúng. Vui lòng nhập lại!";
                MessageBox.Show(errorMessage, "Xác Minh Email Lấy Lại Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
