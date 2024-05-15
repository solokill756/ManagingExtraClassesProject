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

namespace ManageStudentsProject
{
    public partial class frmChiTietBaiNopCuaHS : Form
    {
        private string stt;
        private string linkNopBai;
        private string Mark = "";
        public frmChiTietBaiNopCuaHS(string stt)
        {
            InitializeComponent();
            this.stt = stt;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmChiTietBaiNopCuaHS_Load(object sender, EventArgs e)
        {
            this.Text = "Chi tiết nộp bài tập của học sinh";
            var r = new DataBase().Select("selectHomeWorkForMark'" + stt + "'");
            txtTenBaiTap.Text = r["name"].ToString();
            txtTenHocSinh.Text = r["name_student"].ToString();
            txtTenLop.Text = r["name_class"].ToString();
            ToolTip toolTip = new ToolTip();
            linkNopBai = r["linkNopBai"].ToString();
            toolTip.SetToolTip(txtLinkBaiTap, r["linkNopBai"].ToString());
            txtLinkBaiTap.Text = "Link bài tập của" + txtTenHocSinh.Text.ToString();
            txtDiem.Text = r["Diem"].ToString();
            Mark = r["Diem"].ToString(); 
            if (!string.IsNullOrEmpty(txtDiem.Text.ToString()))
            {
                btnGuiDiem.Text = "Sửa Điểm";
            }
        }

        private void txtLinkBaiTap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkNopBai);
        }

        private void btnGuiDiem_Click(object sender, EventArgs e)
        {
            List<SqlParameter> lstPara = new List<SqlParameter>();
            string sql = "UpdateDiem";
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@maNopBai",
                SqlValue = stt,
                SqlDbType = SqlDbType.VarChar,
            });
            

          
            decimal diem;
            if (!decimal.TryParse(txtDiem.Text, out diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là một số trong khoảng từ 0 đến 10.");
                txtDiem.Select();
                return;
            }
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@Diem",
                SqlValue = diem.ToString(),
                SqlDbType = SqlDbType.NVarChar,
            });
            if (string.IsNullOrEmpty(Mark))
            {

                var rs = new DataBase().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Gửi điểm thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Gửi điểm tập thất bại");
                }
            }
            else
            {
                var rs = new DataBase().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Sửa điểm tập thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa điểm tập thất bại");
                }
            }
        }

        private void btnXoaDiem_Click(object sender, EventArgs e)
        {
            string sql = "deleteDiem";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@maNopBai",
                Value = stt,
                SqlDbType = SqlDbType.VarChar // Đặt kiểu dữ liệu tương ứng với dữ liệu cần lưu trữ trong cơ sở dữ liệu
            });
            var rs = new DataBase().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Xóa Bài nộp thành công");
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Thực thi Thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
