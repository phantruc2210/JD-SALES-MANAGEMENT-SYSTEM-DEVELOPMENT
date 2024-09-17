using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_VANPHONGPHAM_JD
{
    public partial class FormBaoCao_PN : Form
    {
        KetNoi  data = new KetNoi();
        public FormBaoCao_PN()
        {
            InitializeComponent();
        }

        private void FormBaoCao_PN_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBH_VANPHONGPHAM_JD.BaoCao.ReportPN.rdlc";
            ReportDataSource rpd = new ReportDataSource();
            rpd.Name = "DataSetJD";
            rpd.Value = data.Table("select * from ViewBaoCaoPhieuNhap");
            reportViewer1.LocalReport.DataSources.Add(rpd);
            this.reportViewer1.RefreshReport();
        }
    }
}
