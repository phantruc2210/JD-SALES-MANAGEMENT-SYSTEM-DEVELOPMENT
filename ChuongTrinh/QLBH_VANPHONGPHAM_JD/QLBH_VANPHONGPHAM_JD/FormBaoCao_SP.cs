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
    public partial class FormBaoCao_SP : Form
    {
        KetNoi data = new KetNoi();
        public FormBaoCao_SP()
        {
            InitializeComponent();
        }

        private void FormBaoCao_SP_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBH_VANPHONGPHAM_JD.BaoCao.ReportSP.rdlc";
            ReportDataSource rpd = new ReportDataSource();
            rpd.Name = "DataSetJD";
            rpd.Value = data.Table("select * from ViewSP");
            reportViewer1.LocalReport.DataSources.Add(rpd);
            this.reportViewer1.RefreshReport();

        }
    }
}
