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
    public partial class frmDangNhap : Form
    {
        public string tendangnhap = "";
        public string loaitk = "";
      
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(cbbLoaiTaiKhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }

            if(string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                txtTenDangNhap.Select();
                return;
            }

            if(string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                txtMatKhau.Select();
                return;
            }
            tendangnhap = txtTenDangNhap.Text.ToString();
           
            switch(cbbLoaiTaiKhoan.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                        break;
                case "Học sinh":
                    loaitk = "hs";
                    break;

            }

            List<SqlParameter> lstPara = new List<SqlParameter>();

            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@loaitaikhoan",
                SqlValue = loaitk,
                SqlDbType = SqlDbType.VarChar
            }) ;

            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@taikhoan",
                SqlValue = txtTenDangNhap.Text,
                SqlDbType = SqlDbType.VarChar
            });

            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@matkhau",
                SqlValue = txtMatKhau.Text,
                SqlDbType = SqlDbType.VarChar
            });

            var rs = new DataBase().SelectData("dangnhap", lstPara);
            if(rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
            }

            //this.Hide();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
