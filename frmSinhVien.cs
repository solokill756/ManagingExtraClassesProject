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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien(string stt)
        {
            this.stt = stt;
            InitializeComponent();
        }
        private string stt;

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(stt))
            {
                this.Text = "Thêm mới học sinh";
            }
            else
            {
                this.Text = "Cập nhật thông tin học sinh";
                var r = new DataBase().Select(string.Format("selectHS '" + stt + "'"));
                ////MessageBox.Show(r[0].ToString());
                txtName.Text = r["name"].ToString();
                txtAddress.Text = r["address"].ToString();
                txtPhone.Text = r["phone"].ToString();
                if (r["gt"].ToString() == "Nam")
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }
                txtGmail.Text = r["email"].ToString();
                txtage.Text = r["age"].ToString();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.ToString().Trim()))
            {
                MessageBox.Show("Mời bạn nhập vào ô này !");
                txtName.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text.ToString().Trim()))
            {
                MessageBox.Show("Mời bạn nhập vào ô này !");
                txtPhone.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtage.Text.ToString().Trim()))
            {
                MessageBox.Show("Mời bạn nhập vào ô này !");
                txtage.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtGmail.Text.ToString().Trim()))
            {
                MessageBox.Show("Mời bạn nhập vào ô này !");
                txtGmail.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text.ToString().Trim()))
            {
                MessageBox.Show("Mời bạn nhập vào ô này !");
                txtAddress.Select();
                return;
            }
            if (!rbtNam.Checked && !rbtNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                return;
            }
            string sql = "";
            string name = txtName.Text;
            string address = txtAddress.Text;  
            string phone = txtPhone.Text;
            int age = int.Parse(txtage.Text);
            string gt = rbtNam.Checked? "1" : "0";
            string email = txtGmail.Text;

            List<SqlParameter> lstPara = new List<SqlParameter>();
            if (string.IsNullOrEmpty(stt))
            {
                sql = "ThemMoiHS";
            }
            else
            {
                lstPara.Add(new SqlParameter()
                {
                    ParameterName = "@id",
                    Value = stt,
                    SqlDbType = SqlDbType.Int // Đặt kiểu dữ liệu tương ứng với dữ liệu cần lưu trữ trong cơ sở dữ liệu
                });
                sql = "updateHS";
            }
            // Tiếp tục thêm các tham số với SqlParameter
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@address",
                Value = address,
                SqlDbType = SqlDbType.NVarChar
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@phone",
                Value = phone,
                SqlDbType = SqlDbType.NVarChar
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@email",
                Value = email,
                SqlDbType = SqlDbType.VarChar
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@name",
                Value = name,
                SqlDbType = SqlDbType.NVarChar
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@age",
                Value = age,
                SqlDbType = SqlDbType.Int // Đặt kiểu dữ liệu INT cho tham số @age
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@sex",
                Value = gt,
                SqlDbType = SqlDbType.NVarChar
            });
            var rs = new DataBase().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if(string.IsNullOrEmpty(stt))
                {
                    MessageBox.Show("Thêm mới học sinh thành công ");
                }else
                {
                    MessageBox.Show("Cập nhật thông tin học sinh thành công");
                }
                this.Dispose();

            }else
            {
                MessageBox.Show("Thực thi Thất bại");
            }
        }

        private void txtage_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "deleteHS";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@id",
                Value = stt,
                SqlDbType = SqlDbType.Int // Đặt kiểu dữ liệu tương ứng với dữ liệu cần lưu trữ trong cơ sở dữ liệu
            });
            var rs = new DataBase().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Xóa học sinh thành công");
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Thực thi Thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
