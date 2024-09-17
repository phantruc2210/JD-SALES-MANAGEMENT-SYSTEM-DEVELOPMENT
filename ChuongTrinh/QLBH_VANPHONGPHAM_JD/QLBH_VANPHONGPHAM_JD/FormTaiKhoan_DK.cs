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
    public partial class FormTaiKhoan_DK : Form
    {
        KetNoi data = new KetNoi();
        private BindingSource bdsourceTK = new BindingSource();
        public FormTaiKhoan_DK()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            // nạp dữ liệu combo box chức vụ
            bdsourceTK.DataSource = data.ThongTinTK();
            cboxChucVu.Items.Clear();
            foreach (DataRowView row in bdsourceTK)
            {
                string cv = row["ChucVu"].ToString();
                if (!cboxChucVu.Items.Contains(cv))
                {
                    cboxChucVu.Items.Add(cv);
                }

            }
        }

        private void FormTaiKhoan_DK_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string dangNhap = txtTenDN.Text;
                string matKhau = txtMatKhau.Text;
                string nhapmatKhau = txtNhapMK.Text;
                string chucVu = cboxChucVu.Text;
                string manv = txtMaNV.Text;

                string slq = "select * from TaiKhoan where TenDN = '" + dangNhap + "'";
                SqlCommand cmd = new SqlCommand(slq, data.GetConnect());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == false)
                {
                    if (matKhau == nhapmatKhau)
                    {
                        data.ExecuteNonQuery("insert into TaiKhoan(TenDN, MatKhau, ChucVu, MaNV) values ( N'" + dangNhap + "', N'"
                            + matKhau + "', N'" + chucVu + "', '" + manv + "')");
                        MessageBox.Show("Đăng kí thành công", "Đăng kí", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // yêu cầu người dùng quay về đăng nhập/ trang chủ
                        DialogResult result = MessageBox.Show("Bạn muốn đăng nhập bằng tài khoản mới không ?", "Đăng Ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Quay về trang đăng nhập!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            FormDangNhap dn = new FormDangNhap();
                            dn.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại mật khẩu. Mật khẩu không trùng nhau !", "Đăng kí", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập bị trùng !", "Đăng kí", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng kí không thành công ! Lỗi " + ex.Message, "Đăng kí", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap dn = new FormDangNhap();
            dn.Show();
        }
    }
}
