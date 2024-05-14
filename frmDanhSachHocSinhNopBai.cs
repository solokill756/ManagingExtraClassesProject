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
    public partial class frmDanhSachHocSinhNopBai : Form
    {
        private string hwId;
        public frmDanhSachHocSinhNopBai(string hwId)
        {
            InitializeComponent();
            this.hwId = hwId;
        }
        private void LoadDiem()
        {
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter()
            {
                ParameterName = "@maBaiTap",
                SqlValue = hwId,
                SqlDbType = SqlDbType.VarChar
            });

            dgvDsHocSinhNopBt.DataSource = new DataBase().SelectData("ChonHSDaNopBai", lst);
            dgvDsHocSinhNopBt.Columns["id"].HeaderText = "Mã nộp bài";
            dgvDsHocSinhNopBt.Columns["name_student"].HeaderText = "Tên học sinh";
            dgvDsHocSinhNopBt.Columns["name"].HeaderText = "Tên Bài tập";
            dgvDsHocSinhNopBt.Columns["name_class"].HeaderText = "Tên lớp học";
            dgvDsHocSinhNopBt.Columns["DateStart"].HeaderText = "Ngày bắt đầu";
            dgvDsHocSinhNopBt.Columns["DateEnd"].HeaderText = "Ngày kết thúc";
            dgvDsHocSinhNopBt.Columns["NgayNopBai"].HeaderText = "Ngày nộp bài";
            dgvDsHocSinhNopBt.Columns["Diem"].HeaderText = "Diểm";

        }

        private void dgvDsHocSinhNopBt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var hwId = dgvDsHocSinhNopBt.Rows[e.RowIndex].Cells["id"].Value.ToString();
                new frmChiTietBaiNopCuaHS(hwId).ShowDialog();
                ListStatus.SelectedIndex = -1;
                LoadDiem();
            }
        }

        private void frmDanhSachHocSinhNopBai_Load(object sender, EventArgs e)
        {
            LoadDiem();
        }

        private void ListStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int check;
            if (ListStatus.Text == "Đã Chấm")
            {
                check = 1;
                

            }
            else
            {
                check = 0;
                
            }

            List<SqlParameter> lstPara = new List<SqlParameter>(); // Khai báo List<SqlParameter> bên ngoài using statement

            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@maBaiTap",
                Value = hwId,
                SqlDbType = SqlDbType.NVarChar
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@Status",
                Value = check,
                SqlDbType = SqlDbType.Bit
            });

            dgvDsHocSinhNopBt.DataSource = new DataBase().SelectData("ChonHSDaNopBaiByStatus", lstPara);
            dgvDsHocSinhNopBt.Columns["id"].HeaderText = "Mã nộp bài";
            dgvDsHocSinhNopBt.Columns["name_student"].HeaderText = "Tên học sinh";
            dgvDsHocSinhNopBt.Columns["name"].HeaderText = "Tên Bài tập";
            dgvDsHocSinhNopBt.Columns["name_class"].HeaderText = "Tên lớp học";
            dgvDsHocSinhNopBt.Columns["DateStart"].HeaderText = "Ngày bắt đầu";
            dgvDsHocSinhNopBt.Columns["DateEnd"].HeaderText = "Ngày kết thúc";
            dgvDsHocSinhNopBt.Columns["NgayNopBai"].HeaderText = "Ngày nộp bài";
            dgvDsHocSinhNopBt.Columns["Diem"].HeaderText = "Diểm";
        }
    }
}
