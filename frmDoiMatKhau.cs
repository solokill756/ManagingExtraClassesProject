using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudentsProject
{
    public partial class frmDoiMatKhau : Form
    {
        private string tk;
        public frmDoiMatKhau(string tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void txtMkHienTai_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMkHienTai.Text))
            {
                MessageBox.Show("Mời bạn nhập mật khẩu hiện tại");
                txtMkHienTai.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMkMoi.Text))
            {
                MessageBox.Show("Mời bạn nhập mật khẩu mới");
                txtMkMoi.Select();
                return;
            }

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtMkHienTai.Text);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte b in hasData)
            {
                hasPass += b;
            }
            var r = new DataBase().Select(string.Format("FindAcc'" + tk + "'"));
            if (!r["password"].ToString().Trim().Equals(hasPass)) {
                MessageBox.Show("Mật khẩu bạn nhập không khớp mời bạn nhập lại !");
                txtMkHienTai.Select();
                return;
            }

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter()
            {
                ParameterName = "@tk",
                SqlValue = tk,
                SqlDbType = SqlDbType.VarChar
            });

            temp = ASCIIEncoding.ASCII.GetBytes(txtMkMoi.Text);
            hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            hasPass = "";
            foreach (byte b in hasData)
            {
                hasPass += b;
            }
            lst.Add(new SqlParameter()
            {
                ParameterName = "@newPw",
                SqlValue = hasPass,
                SqlDbType = SqlDbType.VarChar
            });
            var rs = new DataBase().ExeCute("UppdateMk", lst);

            if (rs == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công !");
                txtMkHienTai.Text = "";
                txtMkMoi.Text = "";

            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại !");
            }

        }
    }
}
