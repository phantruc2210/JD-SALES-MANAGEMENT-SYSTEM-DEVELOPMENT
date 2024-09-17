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
    public partial class FormTaiKhoan_TTin : Form
    {
        KetNoi data = new KetNoi();
        private BindingSource bdsourceNV = new BindingSource();
        private BindingSource bdsourceTK = new BindingSource();
        public FormTaiKhoan_TTin()
        {
            InitializeComponent();
        }
        private void LoadData()
        {

            // nạp dữ liệu combo box mã nhân viên
            bdsourceNV.DataSource = data.ThongTinNV();
            cboxMaNV.Items.Clear();
            foreach (DataRowView row in bdsourceNV)
            {
                string idnv = row["MaNV"].ToString();
                if (!cboxMaNV.Items.Contains(idnv))
                {
                    cboxMaNV.Items.Add(idnv);
                }
            }
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
            if (FormDangNhap.LoggedInUser != null)
            {
                string dn = FormDangNhap.LoggedInUser.Username;
                string sql = "select * from TaiKhoan where TenDN = N'" + dn + "'";
                SqlCommand cmd = new SqlCommand(sql, data.GetConnect());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    txtTenDN.Text = reader["TenDN"].ToString();
                    txtMatKhau.Text = reader["MatKhau"].ToString();
                    cboxChucVu.SelectedItem = reader["ChucVu"].ToString();
                    cboxMaNV.SelectedItem = reader["MaNV"].ToString();

                }

            }
            else
            {
                MessageBox.Show("Không có thông tin tài khoản để hiển thị!");
            }
        }

        private void FormTaiKhoan_TTin_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
