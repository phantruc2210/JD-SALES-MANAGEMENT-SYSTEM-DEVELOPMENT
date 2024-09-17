using QLBH_VANPHONGPHAM_JD.Models;
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
    public partial class FormDangNhap : Form
    {
        KetNoi data = new KetNoi();
        private BindingSource bdsourceTK = new BindingSource();
        public static User LoggedInUser { get; private set; }
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            // nạp dữ liệu combo box chức vụ
            /*bdsourceTK.DataSource = data.ThongTinTK();
            cboxChucVu.Items.Clear();
            foreach (DataRowView row in bdsourceTK)
            {
                string cv = row["ChucVu"].ToString();
                if (!cboxChucVu.Items.Contains(cv))
                {
                    cboxChucVu.Items.Add(cv);
                }

            }*/
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string dn = txtTenDN.Text;
                string mk = txtMatKhau.Text;
                //string cv = cboxChucVu.Text; // Lấy giá trị của combo box

                string sql = "SELECT * FROM TaiKhoan WHERE TenDN = N'" + dn + "' AND MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, data.GetConnect());
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //MessageBox.Show("Đăng nhập thành công với chức vụ: " + cv, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string cv = reader["ChucVu"].ToString();
                    // Xử lý dựa vào chức vụ
                    if (cv == "Quản Lý")
                    {
                        // Gán LoggedInUser với thông tin từ CSDL
                        LoggedInUser = new User
                        {
                            Username = dn,
                        };
                        this.Hide();
                        FormTrangChu quanLyForm = new FormTrangChu(this);
                        quanLyForm.Show();
                    }
                    else if (cv == "Nhân Viên")
                    {
                        // Gán LoggedInUser với thông tin từ CSDL
                        LoggedInUser = new User
                        {
                            Username = dn,
                        };
                        this.Hide();
                        FormTrangChu_NV nhanVienForm = new FormTrangChu_NV(this);
                        nhanVienForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Chức vụ không hợp lệ", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai. Đăng nhập không thành công !", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập không thành công ! Lỗi " + ex.Message, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormTaiKhoan_DK dk = new FormTaiKhoan_DK();
            dk.Show();
        }

        private void linkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormQuenMK quenMK = new FormQuenMK();
            quenMK.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
