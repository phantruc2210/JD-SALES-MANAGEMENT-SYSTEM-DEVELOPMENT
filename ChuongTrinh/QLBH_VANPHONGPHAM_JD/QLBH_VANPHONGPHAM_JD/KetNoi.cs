using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_VANPHONGPHAM_JD
{
    internal class KetNoi
    {
        private string strcon = "Data Source = MSI\\SQLEXPRESS; Initial Catalog = QLBH_VPP_JD; Integrated Security = True";
        public SqlConnection GetConnect()
        {
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            return conn;
        }

        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                data = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }
        // thông tin tài khoản
        public DataTable ThongTinTK()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TaiKhoan", GetConnect());
            da.Fill(dt);
            return dt;
        }

        // thông tin cửa hàng
        public DataTable ThongTinCH()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from CuaHang", GetConnect());
            da.Fill(dt);
            return dt;
        }
        // thông tin nhân viên
        public DataTable ThongTinNV()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien", GetConnect());
            da.Fill(dt);
            return dt;
        }
        // thông tin khách hàng
        public DataTable ThongTinKH()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang", GetConnect());
            da.Fill(dt);
            return dt;
        }
        // thông tin nhà cung cấp
        public DataTable ThongTinNCC()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from NhaCungCap", GetConnect());
            da.Fill(dt);
            return dt;
        }
        // thông tin loại sản phẩm
        public DataTable ThongTinLSP()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from LoaiSanPham", GetConnect());
            da.Fill(dt);
            return dt;
        }
        // thông tin sản phẩm
        public DataTable ThongTinSP()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from SanPham", GetConnect());
            da.Fill(dt);
            return dt;
        }
        // thông tin phiếu nhập
        public DataTable ThongTinPN()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from PhieuNhap", GetConnect());
            da.Fill(dt);
            return dt;
        }
        // thông tin chi tiết phiếu nhập
        public DataTable ThongTinCTPN(string sopn)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from CTPhieuNhap where SoPN = '" + sopn + "'", GetConnect());
            da.Fill(dt);
            return dt;
        }
        public double TienTrenPN(string sopn)
        {
            double tien = 0; double sl = 0; double gia = 0;
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT SoLuong, DonGia FROM CTPhieuNhap where SoPN = '" + sopn + "'", conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sl = Convert.ToDouble(reader["SoLuong"].ToString());
                    gia = Convert.ToDouble(reader["DonGia"].ToString());
                    tien += sl * gia;  // Cộng dồn vào tổng tiền
                }
                conn.Close();
            }
            return tien;
        }
        // thông tin phiếu xuất
        public DataTable ThongTinPX()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from PhieuXuat", GetConnect());
            da.Fill(dt);
            return dt;
        }

        // thông tin chi tiết phiếu xuất
        public DataTable ThongTinCTPX(string sopx)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from CTPhieuXuat where SoPX = '" + sopx + "'", GetConnect());
            da.Fill(dt);
            return dt;
        }
        public double TienTrenPX(string sopx)
        {
            double tien = 0; double sl = 0; double gia = 0;
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT SoLuong, DonGiaXuat FROM CTPhieuXuat where SoPX = '" + sopx + "'", conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sl = Convert.ToDouble(reader["SoLuong"].ToString());
                    gia = Convert.ToDouble(reader["DonGiaXuat"].ToString());
                    tien += sl * gia;  // Cộng dồn vào tổng tiền
                }
                conn.Close();
            }
            return tien;
        }
        // thông tin hóa đơn
        public DataTable ThongTinHD()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon", GetConnect());
            da.Fill(dt);
            return dt;
        }
        // thông tin chi tiết hóa đơn
        public DataTable ThongTinCTHD(string mahd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from CTHoaDon where MaHD = '" + mahd + "'", GetConnect());
            da.Fill(dt);
            return dt;
        }
        public double TienTrenHD(string mahd)
        {
            double tien = 0; double sl = 0; double gia = 0;
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT SoLuong, DonGiaBan FROM CTHoaDon where MaHD = '" + mahd + "'", conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sl = Convert.ToDouble(reader["SoLuong"].ToString());
                    gia = Convert.ToDouble(reader["DonGiaBan"].ToString());
                    tien += sl * gia;  // Cộng dồn vào tổng tiền
                }
                conn.Close();
            }
            return tien;
        }
        // table hiển thị trong báo cáo
        public DataTable Table(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }
    }
}
