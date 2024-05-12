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
    public partial class DSLopChuaDangKy : Form
    {
        private string mahs;
        public DSLopChuaDangKy(string mahs)
        {
            InitializeComponent();
            this.mahs = mahs;
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

            dgvDSLopChuaDangKy.DataSource = new DataBase().SelectData("LopChuaDangKy", lst);
            dgvDSLopChuaDangKy.Columns["id"].HeaderText = "Mã Lớp học";
            dgvDSLopChuaDangKy.Columns["name"].HeaderText = "Tên lớp học";
            dgvDSLopChuaDangKy.Columns["status"].HeaderText = "Trạng thái";
            dgvDSLopChuaDangKy.Columns["TyLeDangKy"].HeaderText = "Số lượng";

        }
        private void dgvDSLopChuaDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLopChuaDangKy.Rows[e.RowIndex].Index >= 0)
            {
                if (dgvDSLopChuaDangKy.Rows[e.RowIndex].Cells["status"].Value.ToString().Equals("Đóng"))
                {
                    MessageBox.Show("Lớp này chưa mở đăng ký vui lòng quay lại sau");
                    return;
                }
                if (int.Parse(dgvDSLopChuaDangKy.Rows[e.RowIndex].Cells["TyLeDangKy"].Value.ToString().Split('/')[0]) >= int.Parse(dgvDSLopChuaDangKy.Rows[e.RowIndex].Cells["TyLeDangKy"].Value.ToString().Split('/')[1]))
                {
                    MessageBox.Show("Lớp này đã đầy nên không thể đăng kí thêm");
                    return;
                }
                if(DialogResult.Yes == MessageBox.Show("Bạn có muốn đăng ký lớp học [ " + dgvDSLopChuaDangKy.Rows[e.RowIndex].Cells["name"].Value.ToString() + " ] ?",
                    "Xác nhận đăng ký",
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
                        SqlValue = dgvDSLopChuaDangKy.Rows[e.RowIndex].Cells["id"].Value.ToString(),
                        SqlDbType = SqlDbType.VarChar
                    });
                    if(new DataBase().ExeCute("DangKyLopHoc" , lst) == 1)
                    {
                        MessageBox.Show("Đăng ký lớp học thành công , Success !");
                        LoadLopHoc();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký lớp học thất bại , Fail !");
                        return;
                    }
                }
            }
        }

        private void DSLopChuaDangKy_Load(object sender, EventArgs e)
        {
            LoadLopHoc();
        }
    }
}
