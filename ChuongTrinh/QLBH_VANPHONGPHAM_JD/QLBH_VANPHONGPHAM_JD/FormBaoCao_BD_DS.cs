using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLBH_VANPHONGPHAM_JD
{
    public partial class FormBaoCao_BD_DS : Form
    {
        KetNoi data = new KetNoi();
        public FormBaoCao_BD_DS()
        {
            InitializeComponent();
        }

        // biểu đồ doanh số - hóa đơn
        void FillChart1()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Top5_BanChay_HD", data.GetConnect());
                da.Fill(dt);
                chartDoanhSo1.DataSource = dt;

                chartDoanhSo1.Series.Clear();
                Series series = new Series("DoanhSo");
                series.XValueMember = "TenSP";
                series.YValueMembers = "DoanhSo";
                series.ChartType = SeriesChartType.Column; // Hoặc ChartType khác tùy nhu cầu
                
                chartDoanhSo1.Series.Add(series);

                chartDoanhSo1.Titles.Clear();
                Title title = new Title("TOP 5 SẢN PHẨM BÁN CHẠY NHẤT - HÓA ĐƠN");
                title.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Đổi size cho title
                chartDoanhSo1.Titles.Add(title);

                // Thay đổi size cho x-axis và y-axis labels
                chartDoanhSo1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 12);
                chartDoanhSo1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 12);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }

        // biểu đồ doanh số - phiếu xuất
        void FillChart2()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Top5_BanChay_PX", data.GetConnect());
                da.Fill(dt);
                chartDoanhSo2.DataSource = dt;

                chartDoanhSo2.Series.Clear();
                Series series = new Series("DoanhSo");
                series.XValueMember = "TenSP";
                series.YValueMembers = "DoanhSo";
                series.ChartType = SeriesChartType.Column; // Hoặc ChartType khác tùy nhu cầu
                chartDoanhSo2.Series.Add(series);

                chartDoanhSo2.Titles.Clear();
                Title title = new Title("TOP 5 SẢN PHẨM BÁN CHẠY NHẤT - PHIẾU XUẤT");
                title.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Đổi size cho title
                chartDoanhSo2.Titles.Add(title);

                // Thay đổi size cho x-axis và y-axis labels
                chartDoanhSo2.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 12);
                chartDoanhSo2.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 12);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        

        private void FormBaoCao_BD_Load(object sender, EventArgs e)
        {
            FillChart1();
            FillChart2();

        }
    }
}
