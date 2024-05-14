using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ManageStudentsProject
{
    public partial class NopBaiTap : Form
    {
        private string stt;
        private string mahs;
        private string linkBaiTap;
        private string sql = "";
        public NopBaiTap(string stt , string mahs , string linkBaiTap)
        {
            InitializeComponent();
            this.stt = stt;
            this.mahs = mahs;
            this.linkBaiTap = linkBaiTap;
        }

        private void NopBaiTap_Load(object sender, EventArgs e)
        {
            this.Text = "Phiếu nộp bài tập";
            var r = new DataBase().Select("selectHomeWork '" + stt + "'");
            txtMaBaiTap.Text = r["id"].ToString();
            txtTenBaiTap.Text = r["name"].ToString();
            txtNgayBatDau.Text = r["dateStart"].ToString();
            TxtNgayKetThuc.Text = r["dateEnd"].ToString();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(LinkBaiTap, linkBaiTap);
            LinkBaiTap.Text = r["name"].ToString();
            txtLinkNopBai.Text = r["linkNopBaiTap"].ToString();
            if(!string.IsNullOrEmpty(txtLinkNopBai.Text.ToString()))
            {
                sql = "UpdateHW_ST";
                btnNopBai.Text = "Sửa bài";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaBaiTap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            var r = new DataBase().Select("selectHomeWork '" + stt + "'");
            try
            {
                // Assuming dgvBaiTap is your DataGridView and e is your DataGridViewCellEventArgs
                string dateEndString = r["DateEnd"].ToString();
                DateTime dateEnd = DateTime.ParseExact(dateEndString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (DateTime.Now > dateEnd)
                {
                    MessageBox.Show("Đã quá ngày để nộp bài");
                    return;
                }
            }
            catch (FormatException ex)
            {
                // Handle the case where the string cannot be parsed to a DateTime
                MessageBox.Show("Invalid date format: " + ex.Message);
            }
            try
            {
                // Assuming dgvBaiTap is your DataGridView and e is your DataGridViewCellEventArgs
                string dateStartString = r["DateStart"].ToString();
                DateTime dateStart = DateTime.ParseExact(dateStartString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dateStart > DateTime.Now)
                {
                    MessageBox.Show("Bài tập [ " + r["name"].ToString() + " ] chưa mở");
                    return;
                }
            }
            catch (FormatException ex)
            {
                // Handle the case where the string cannot be parsed to a DateTime
                MessageBox.Show("Invalid date format: " + ex.Message);
            }
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@HomeWork_id",
                SqlValue = txtMaBaiTap.Text,
                SqlDbType = SqlDbType.Int,
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@Student_id",
                SqlValue = mahs,
                SqlDbType = SqlDbType.Int,
            });

            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@Link",
                SqlValue = txtLinkNopBai.Text,
                SqlDbType = SqlDbType.VarChar,
            });
            if (string.IsNullOrEmpty(txtMaBaiTap.Text))
            {
                MessageBox.Show("Mời bạn nhập link bài tập");
                txtLinkNopBai.Select();
                return;
            }
            if (string.IsNullOrEmpty(sql))
            {
                sql = "InsertIntoHW_ST";
                
                var rs = new DataBase().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Nộp bài tập thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Nộp bài tập thất bại");
                }
            }
            else
            {
                var rs = new DataBase().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Sửa bài tập thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa bài tập thất bại");
                }
            }
           

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LinkBaiTap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkBaiTap);

        }
    }
}
