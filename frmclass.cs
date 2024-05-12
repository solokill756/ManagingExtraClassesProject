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
    public partial class frmclass : Form
    {
        private string ClassId;
        public frmclass(string ClassId)
        {
            this.ClassId = ClassId;
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            if(string.IsNullOrEmpty(ClassId.ToString()))
            {
                sql = "InsertClass";
            }
            else
            {
                sql = "UpdateClass";
                lstPara.Add(new SqlParameter()
                {
                    ParameterName = "@id",
                    Value = ClassId,
                    SqlDbType = SqlDbType.Int
                });
            }
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@name",
                Value = txtLop.Text.ToString(),
                SqlDbType = SqlDbType.NVarChar
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@soluong",
                Value = int.Parse(txtSoluong.Text.ToString()),
                SqlDbType = SqlDbType.Int
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@status",
                Value = rbtControng.Checked? "1" : "0",
                SqlDbType = SqlDbType.Bit
            });

            var rs = new DataBase().ExeCute(sql, lstPara);
            if(rs == 1)
            {
                if(string.IsNullOrEmpty(ClassId.ToString()))
                {
                    MessageBox.Show("Thêm lớp thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật lớp thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Try vấn thất bại");
            }
        }

        private void frmclass_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ClassId.ToString()))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật Lớp học";
                var r = new DataBase().Select("selectClass '" + ClassId + "'");
                txtLop.Text = r["name"].ToString();
                txtSoluong.Text = r["soluong"].ToString();
                if (r["status"].ToString() == "Còn trống")
                {
                    rbtControng.Checked = true;
                }
                else
                {
                    rbtHetcho.Checked = true;
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "deleteClass";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@ClassId",
                Value = ClassId,
                SqlDbType = SqlDbType.Int // Đặt kiểu dữ liệu tương ứng với dữ liệu cần lưu trữ trong cơ sở dữ liệu
            });
            var rs = new DataBase().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Xóa Lớp học thành công");
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
