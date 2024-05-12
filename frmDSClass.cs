using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudentsProject
{
    public partial class frmDSClass : Form
    {
        public frmDSClass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            loadDSClass();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSClass();
        }
        private string tukhoa = "";
        private void loadDSClass()
        {
            string sql = "selectAllClassByKey";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@tukhoa",
                Value = tukhoa,
                SqlDbType = SqlDbType.NVarChar
            });

            dgvDSClass.DataSource = new DataBase().SelectData(sql, lstPara);
            dgvDSClass.Columns["id"].HeaderText = "Mã Lớp học";
            dgvDSClass.Columns["name"].HeaderText = "Tên lớp học";
            dgvDSClass.Columns["status"].HeaderText = "Trạng thái";
            dgvDSClass.Columns["soluong"].HeaderText = "Số lượng";

        }

        private void dgvDSClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var ClassId = dgvDSClass.Rows[e.RowIndex].Cells["id"].Value.ToString();
                new frmclass(ClassId).ShowDialog();
                loadDSClass();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmclass("").ShowDialog();
            loadDSClass();
        }
    }
}
