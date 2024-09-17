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
using System.Windows.Forms.DataVisualization.Charting;

namespace QLBH_VANPHONGPHAM_JD
{
    public partial class FormBaoCao_BD_DT : Form
    {
        KetNoi data = new KetNoi();
        public FormBaoCao_BD_DT()
        {
            InitializeComponent();
        }
        // biểu đồ doanh thu - hóa đơn
        void FillChart3()
        { 
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Top5_DoanhThu_HD", data.GetConnect());
                da.Fill(dt);
                chartDoanhThu1.DataSource = dt;

                chartDoanhThu1.Series.Clear();
                Series series = new Series("DoanhThu");
                series.XValueMember = "TenSP";
                series.YValueMembers = "DoanhThu";
                series.ChartType = SeriesChartType.Line; // Hoặc ChartType khác tùy nhu cầu
                chartDoanhThu1.Series.Add(series);

                chartDoanhThu1.Titles.Clear();
                Title title = new Title("TOP 5 SẢN PHẨM ĐẠT DOANH THU CAO NHẤT - HÓA ĐƠN");
                title.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Đổi size cho title
                chartDoanhThu1.Titles.Add(title);

                // Thay đổi size cho x-axis và y-axis labels
                chartDoanhThu1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 12);
                chartDoanhThu1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 12);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // biểu đồ doanh thu - phiếu xuất
        void FillChart4()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Top5_DoanhThu_PX", data.GetConnect());
                da.Fill(dt);
                chartDoanhThu2.DataSource = dt;

                chartDoanhThu2.Series.Clear();
                Series series = new Series("DoanhThu");
                series.XValueMember = "TenSP";
                series.YValueMembers = "DoanhThu";
                series.ChartType = SeriesChartType.Line; // Hoặc ChartType khác tùy nhu cầu
                chartDoanhThu2.Series.Add(series);

                chartDoanhThu2.Titles.Clear();
                Title title = new Title("TOP 5 SẢN PHẨM ĐẠT DOANH THU CAO NHẤT - PHIẾU XUẤT");
                title.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Đổi size cho title
                chartDoanhThu2.Titles.Add(title);

                // Thay đổi size cho x-axis và y-axis labels
                chartDoanhThu2.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 12);
                chartDoanhThu2.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 12);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void FormBaoCao_BD_DT_Load(object sender, EventArgs e)
        {
            FillChart4();
            FillChart3();
        }
    }
}
