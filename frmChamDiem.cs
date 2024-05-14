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
    public partial class frmChamDiem : Form
    {
        private string tukhoa = "";
        public frmChamDiem()
        {
            InitializeComponent();
        }

        private void loadClassType()

        {



            List<SqlParameter> lstPara = new List<SqlParameter>();

            lstPara.Add(new SqlParameter()

            {

                ParameterName = "@tukhoa",

                Value = "",
                SqlDbType = SqlDbType.VarChar

            });



            // Thiết lập các thuộc tính DisplayMember, ValueMember, DataSource cho ComboBox


            ListClass.DisplayMember = "name";

            ListClass.ValueMember = "id";
            ListClass.DataSource = new DataBase().SelectData("SelectAllClass", lstPara);
            ListClass.SelectedIndex = -1;
        }

        private void loadDSHomeWork()
        {
            string sql = "selectAllHomeWorkByForMark";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@tukhoa",
                Value = tukhoa,
                SqlDbType = SqlDbType.NVarChar
            });

            dgvDanhSachChamDiem.DataSource = new DataBase().SelectData(sql, lstPara);
            dgvDanhSachChamDiem.Columns["id"].HeaderText = "Mã Bài tập";
            dgvDanhSachChamDiem.Columns["name"].HeaderText = "Tên Bài tập";
            dgvDanhSachChamDiem.Columns["dateStart"].HeaderText = "Ngày bắt đầu";
            dgvDanhSachChamDiem.Columns["author"].HeaderText = "Tác giả";
            dgvDanhSachChamDiem.Columns["link"].HeaderText = "Link tải";
            dgvDanhSachChamDiem.Columns["dateEnd"].HeaderText = "Ngày kết thúc";
            dgvDanhSachChamDiem.Columns["SubmittedCount"].HeaderText = "Số lượng nộp bài";
        }
        private void dgvDanhSachChamDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var hwId = dgvDanhSachChamDiem.Rows[e.RowIndex].Cells["id"].Value.ToString();
                new frmDanhSachHocSinhNopBai(hwId).ShowDialog();
                ListClass.SelectedIndex = -1;
                loadDSHomeWork();
            }
        }

        private void frmChamDiem_Load(object sender, EventArgs e)
        {
            loadClassType();
            loadDSHomeWork();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            if (ListClass.SelectedValue != null)
            {
                int classId;
                if (int.TryParse(ListClass.SelectedValue.ToString(), out classId))
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
                    if (dgvDanhSachChamDiem.DataSource != null)
                    {
                        (dgvDanhSachChamDiem.DataSource as IDisposable)?.Dispose();
                    }
                    dgvDanhSachChamDiem.DataSource = new DataBase().SelectData("SelectHomeWorkAFTERSELECTCLASSForMark", lstPara);
                    dgvDanhSachChamDiem.Columns["id"].HeaderText = "Mã Bài tập";
                    dgvDanhSachChamDiem.Columns["name"].HeaderText = "Tên Bài tập";
                    dgvDanhSachChamDiem.Columns["dateStart"].HeaderText = "Ngày bắt đầu";
                    dgvDanhSachChamDiem.Columns["author"].HeaderText = "Tác giả";
                    dgvDanhSachChamDiem.Columns["link"].HeaderText = "Link tải";
                    dgvDanhSachChamDiem.Columns["dateEnd"].HeaderText = "Ngày kết thúc";
                    dgvDanhSachChamDiem.Columns["SubmittedCount"].HeaderText = "Số lượng nộp bài";

                }

            }
            else
            {

                loadDSHomeWork();
            }
        }
    }
}
