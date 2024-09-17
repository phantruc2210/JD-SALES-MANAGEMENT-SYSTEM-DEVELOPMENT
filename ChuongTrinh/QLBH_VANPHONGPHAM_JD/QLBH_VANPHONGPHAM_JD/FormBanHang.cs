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
    public partial class FormBanHang : Form
    {
        //khái báo biến về form hiện tại là form trang chủ
        private Form currentFrch;
        public FormBanHang()
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
        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBanHang_QuanLy formQL = new FormBanHang_QuanLy();
            OpenChildForm(currentFrch, panelBH, formQL);
        }

        private void traCứuThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBanHang_TraCuu formTC = new FormBanHang_TraCuu();
            OpenChildForm(currentFrch, panelBH, formTC);
        }
    }
}
