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
    public partial class frmDSHomeWork : Form
    {
        private string tukhoa = "";
        public frmDSHomeWork()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadDSHomeWork()
        {
            string sql = "selectAllHomeWorkByKey";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@tukhoa",
                Value = tukhoa,
                SqlDbType = SqlDbType.NVarChar
            });

            dgvDSHomework.DataSource = new DataBase().SelectData(sql, lstPara);
            dgvDSHomework.Columns["id"].HeaderText = "Mã Bài tập";
            dgvDSHomework.Columns["name"].HeaderText = "Tên Bài tập";
            dgvDSHomework.Columns["dateStart"].HeaderText = "Ngày bắt đầu";
            dgvDSHomework.Columns["author"].HeaderText = "Tác giả";
            dgvDSHomework.Columns["link"].HeaderText = "Link tải";
            dgvDSHomework.Columns["dateEnd"].HeaderText = "Ngày kết thúc";


        }

        private void frmHomeWork_Load(object sender, EventArgs e)
        {
            loadDSHomeWork();
        }

        private void dgvDSHomework_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var hwId = dgvDSHomework.Rows[e.RowIndex].Cells["id"].Value.ToString();
                new HomeWork(hwId).ShowDialog();
                listClass.SelectedIndex = -1;
                loadDSHomeWork();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new HomeWork("").ShowDialog();
            listClass.SelectedIndex = -1;
            loadDSHomeWork();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            if (listClass.SelectedValue != null)
            {
                int classId;
                if (int.TryParse(listClass.SelectedValue.ToString(), out classId))
                {
                    List<SqlParameter> lstPara = new List<SqlParameter>(); // Khai báo List<SqlParameter> bên ngoài using statement

                    lstPara.Add(new SqlParameter()
                    {
                        ParameterName = "@tukhoa",
                        Value = tukhoa,
                        SqlDbType = SqlDbType.NVarChar
                    });
                    lstPara.Add(new SqlParameter()
                    {
                        ParameterName = "@ClassId",
                        Value = classId,
                        SqlDbType = SqlDbType.Int
                    });



                    // It's a good practice to dispose previous DataSource if needed.
                    if (dgvDSHomework.DataSource != null)
                    {
                        (dgvDSHomework.DataSource as IDisposable)?.Dispose();
                    }
                    dgvDSHomework.DataSource = new DataBase().SelectData("SelectHomeWorkAFTERSELECTCLASS", lstPara);
                    dgvDSHomework.Columns["id"].HeaderText = "Mã Bài tập";
                    dgvDSHomework.Columns["name"].HeaderText = "Tên Bài tập";
                    dgvDSHomework.Columns["dateStart"].HeaderText = "Ngày bắt đầu";
                    dgvDSHomework.Columns["author"].HeaderText = "Tác giả";
                    dgvDSHomework.Columns["link"].HeaderText = "Link tải";
                    dgvDSHomework.Columns["dateEnd"].HeaderText = "Ngày kết thúc";

                }
                
            }
            else
            {

                loadDSHomeWork();
            }
        }
        public void loadClassType()

        {



            List<SqlParameter> lstPara = new List<SqlParameter>();

            lstPara.Add(new SqlParameter()

            {

                ParameterName = "@tukhoa",

                Value = "",
                SqlDbType = SqlDbType.VarChar

            });



            // Thiết lập các thuộc tính DisplayMember, ValueMember, DataSource cho ComboBox


            listClass.DisplayMember = "name";

            listClass.ValueMember = "id";
            listClass.DataSource = new DataBase().SelectData("SelectAllClass", lstPara);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            loadClassType();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
