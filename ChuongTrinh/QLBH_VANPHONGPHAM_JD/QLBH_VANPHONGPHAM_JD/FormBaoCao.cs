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
    public partial class FormBaoCao : Form
    {
        //khái báo biến về form hiện tại là form trang chủ
        private Form currentFrch;
        public FormBaoCao()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form currentFrch, Panel Panel_Body, Form frch)
        {
            if (currentFrch != null)
            {
                currentFrch.Close();
            }
            currentFrch = frch;
            frch.TopLevel = false;
            frch.FormBorderStyle = FormBorderStyle.None;
            frch.Dock = DockStyle.Fill;
            Panel_Body.Controls.Add(frch);
            Panel_Body.Tag = frch;
            frch.BringToFront();
            frch.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCao_BD_DT formBD = new FormBaoCao_BD_DT();
            OpenChildForm(currentFrch, panelBC, formBD);
        }

        private void doanhSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCao_BD_DS formBD = new FormBaoCao_BD_DS();
            OpenChildForm(currentFrch, panelBC, formBD);
        }

        private void danhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCao_SP formSP = new FormBaoCao_SP();
            OpenChildForm(currentFrch, panelBC, formSP);
        }

        private void bCKQHĐKDHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCao_KQHDKD_HD formHD = new FormBaoCao_KQHDKD_HD();
            OpenChildForm(currentFrch, panelBC, formHD);
        }

        private void danhSáchPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCao_PN formPN = new FormBaoCao_PN();
            OpenChildForm(currentFrch, panelBC, formPN);
        }

        private void hoạtĐộngKinhDoanhPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCao_KQHDKD_PX formPX = new FormBaoCao_KQHDKD_PX();
            OpenChildForm(currentFrch, panelBC, formPX);
        }
    }
}
