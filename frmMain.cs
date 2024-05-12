using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudentsProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitk;
        private void frmMain_Load(object sender, EventArgs e)
        {
            var fn = new frmDangNhap();
            fn.ShowDialog();
            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            if(loaitk.Equals("admin"))
            {
                NopBaiTapToolStripMenuItem.Visible = false;
                LopDaDangKyToolStripMenuItem.Visible = false;
                DangKiLopHocToolStripMenuItem.Visible = false;
                frmWelcome f = new frmWelcome();
                AddForm(f);
                return;

            }
            else if(loaitk.Equals("hs"))
            {
                quảnLíToolStripMenuItem.Visible = false;
                TroGiupTToolStripMenuItem.Visible = false;
                frmWelcome f = new frmWelcome();
                AddForm(f);
                return;
            }
            else
            {
                Application.Exit();
            }
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSClass f = new frmDSClass();
            AddForm(f);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            AddForm(f);
        }

        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void BaiTapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSHomeWork f = new frmDSHomeWork();
            AddForm(f);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void DangKiLopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDangKiLopHoc(taikhoan);
            AddForm(f);
        }

        private void LopDaDangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
        }
    }
}
