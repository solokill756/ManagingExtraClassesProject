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
    public partial class XemDiem : Form
    {
        private string mahs;
        public XemDiem(string mahs)
        {
            InitializeComponent();
            this.mahs = mahs;
        }

        private void dgvXemDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDiem()
        {
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter()
            {
                ParameterName = "@mahs",
                SqlValue = mahs,
                SqlDbType = SqlDbType.VarChar
            });

            dgvXemDiem.DataSource = new DataBase().SelectData("SelectAllDiem", lst);
            dgvXemDiem.Columns["id"].HeaderText = "Mã Bài tập";
            dgvXemDiem.Columns["name"].HeaderText = "Tên Bài tập";
            dgvXemDiem.Columns["name_class"].HeaderText = "Tên lớp học";
            dgvXemDiem.Columns["DateStart"].HeaderText = "Ngày bắt đầu";
            dgvXemDiem.Columns["DateEnd"].HeaderText = "Ngày kết thúc";
            dgvXemDiem.Columns["NgayNopBai"].HeaderText = "Ngày nộp bài";
            dgvXemDiem.Columns["Diem"].HeaderText = "Diểm";

        }
        private void XemDiem_Load(object sender, EventArgs e)
        {
            LoadDiem();
        }
    }
}
