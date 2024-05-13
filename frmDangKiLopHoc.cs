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
    public partial class frmDangKiLopHoc : Form
    {
        private string mahs;
        private string tukhoa;
        public frmDangKiLopHoc(string mahs)
        {
            InitializeComponent();
            this.mahs = mahs;
        }

        private void dvgDangkiLophoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgDangkiLophoc.Rows[e.RowIndex].Index >= 0)
            {
                
               
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn Hủy lớp học [ " + dvgDangkiLophoc.Rows[e.RowIndex].Cells["name"].Value.ToString() + " ] ?",
                    "Xác nhận hủy lớp học",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                {
                    List<SqlParameter> lst = new List<SqlParameter>();
                    lst.Add(new SqlParameter()
                    {
                        ParameterName = "@mahs",
                        SqlValue = mahs,
                        SqlDbType = SqlDbType.VarChar
                    });
                    lst.Add(new SqlParameter()
                    {
                        ParameterName = "@malop",
                        SqlValue = dvgDangkiLophoc.Rows[e.RowIndex].Cells["id"].Value.ToString(),
                        SqlDbType = SqlDbType.VarChar
                    });
                    if (new DataBase().ExeCute("HuyLopHoc", lst) == 1)
                    {
                        MessageBox.Show("Hủy lớp học thành công , Success !");
                        LoadLopHoc();
                    }
                    else
                    {
                        MessageBox.Show("Hủy lớp học thất bại , Fail !");
                        return;
                    }
                }
            }
        }

        private void frmDangKiLopHoc_Load(object sender, EventArgs e)
        {
            LoadLopHoc();
        }

        private void LoadLopHoc()
        {
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter()
            {
                ParameterName = "@mahs",
                SqlValue = mahs,
                SqlDbType = SqlDbType.VarChar
            });

            dvgDangkiLophoc.DataSource = new DataBase().SelectData("LopDaDangKy" , lst);
            dvgDangkiLophoc.Columns["id"].HeaderText = "Mã Lớp học";
            dvgDangkiLophoc.Columns["name"].HeaderText = "Tên lớp học";
            dvgDangkiLophoc.Columns["status"].HeaderText = "Trạng thái";
            dvgDangkiLophoc.Columns["TyLeDangKy"].HeaderText = "Số lượng";
            dvgDangkiLophoc.Columns["NgayDangKy"].HeaderText = "Ngày đăng ký";

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            new DSLopChuaDangKy(mahs).ShowDialog();
            LoadLopHoc();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text.ToString();
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter()
            {
                ParameterName = "@tukhoa",
                SqlValue = tukhoa,
                SqlDbType = SqlDbType.NVarChar,
            });
            lst.Add(new SqlParameter()
            {
                ParameterName = "@mahs",
                SqlValue = mahs,
                SqlDbType = SqlDbType.VarChar,
            });

            dvgDangkiLophoc.DataSource = new DataBase().SelectData("SelectNewClass", lst);
            dvgDangkiLophoc.Columns["id"].HeaderText = "Mã Lớp học";
            dvgDangkiLophoc.Columns["name"].HeaderText = "Tên lớp học";
            dvgDangkiLophoc.Columns["status"].HeaderText = "Trạng thái";
            dvgDangkiLophoc.Columns["soLuong"].HeaderText = "Số lượng";
            dvgDangkiLophoc.Columns["NgayDangKy"].HeaderText = "Ngày đăng ký";
        }
    }
}
