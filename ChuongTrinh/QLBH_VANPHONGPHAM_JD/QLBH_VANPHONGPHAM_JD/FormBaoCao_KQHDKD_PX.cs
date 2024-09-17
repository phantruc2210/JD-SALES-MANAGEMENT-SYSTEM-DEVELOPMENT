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
    public partial class FormBaoCao_KQHDKD_PX : Form
    {
        KetNoi data = new KetNoi();
        public FormBaoCao_KQHDKD_PX()
        {
            InitializeComponent();
        }

        private void FormBaoCao_KQHDKD_PX_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBH_VANPHONGPHAM_JD.BaoCao.ReportBCKQHDKD_PX.rdlc";
            ReportDataSource rpd = new ReportDataSource();
            rpd.Name = "DataSetJD";
            rpd.Value = data.Table("select * from ViewBCKQHD_PX");
            reportViewer1.LocalReport.DataSources.Add(rpd);
            this.reportViewer1.RefreshReport();
        }
    }
}
