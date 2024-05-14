using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudentsProject
{
    public partial class frmHomeWorkOfStudent : Form
    {
        private string mahs;
        private string tukhoa= "";
        public frmHomeWorkOfStudent(string mahs)
        {
            InitializeComponent();
            this.mahs = mahs;
        }

        private void loadDSHomeWork()
        {
            string sql = "SelectHomeWorkFromStudent";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@tukhoa",
                Value = tukhoa,
                SqlDbType = SqlDbType.NVarChar
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@mahs",
                Value = mahs,
                SqlDbType = SqlDbType.VarChar
            });
            dgvBaiTap.DataSource = new DataBase().SelectData(sql, lstPara);
            dgvBaiTap.Columns["id"].HeaderText = "Mã Bài tập";
            dgvBaiTap.Columns["name"].HeaderText = "Tên Bài tập";
            dgvBaiTap.Columns["dateStart"].HeaderText = "Ngày bắt đầu";
            dgvBaiTap.Columns["author"].HeaderText = "Tác giả";
            dgvBaiTap.Columns["link"].HeaderText = "Link tải bài tập";
            dgvBaiTap.Columns["dateEnd"].HeaderText = "Ngày kết thúc";
            dgvBaiTap.Columns["TrangThai"].HeaderText = "Tình trạng";


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


            listClass.DisplayMember = "name";

            listClass.ValueMember = "id";
            listClass.DataSource = new DataBase().SelectData("SelectAllClass", lstPara);
            listClass.SelectedIndex = -1;


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void frmHomeWorkOfStudent_Load(object sender, EventArgs e)
        {
            loadDSHomeWork();
            loadClassType();
            
        }

        private void dgvBaiTap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var hwId = dgvBaiTap.Rows[e.RowIndex].Cells["id"].Value.ToString();
                try
                {
                    // Assuming dgvBaiTap is your DataGridView and e is your DataGridViewCellEventArgs
                    string dateEndString = dgvBaiTap.Rows[e.RowIndex].Cells["DateEnd"].Value.ToString();
                    DateTime dateEnd = DateTime.ParseExact(dateEndString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    if (DateTime.Now > dateEnd)
                    {
                        MessageBox.Show("Đã quá ngày để nộp bài");
                        return;
                    }
                }
                catch (FormatException ex)
                {
                    // Handle the case where the string cannot be parsed to a DateTime
                    MessageBox.Show("Invalid date format: " + ex.Message);
                }
                try
                {
                    // Assuming dgvBaiTap is your DataGridView and e is your DataGridViewCellEventArgs
                    string dateStartString = dgvBaiTap.Rows[e.RowIndex].Cells["DateStart"].Value.ToString();
                    DateTime dateStart = DateTime.ParseExact(dateStartString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    if (dateStart > DateTime.Now)
                    {
                        MessageBox.Show("Bài tập [ " + dgvBaiTap.Rows[e.RowIndex].Cells["name"].Value.ToString() + " ] chưa mở");
                        return;
                    }
                }
                catch (FormatException ex)
                {
                    // Handle the case where the string cannot be parsed to a DateTime
                    MessageBox.Show("Invalid date format: " + ex.Message);
                }
                new NopBaiTap(hwId , mahs , dgvBaiTap.Rows[e.RowIndex].Cells["link"].Value.ToString()).ShowDialog();
                listClass.SelectedIndex = -1;
                loadDSHomeWork();
            }
        }

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    lstPara.Add(new SqlParameter()
                    {
                        ParameterName = "@mahs",
                        Value = mahs,
                        SqlDbType = SqlDbType.VarChar
                    });


                    // It's a good practice to dispose previous DataSource if needed.
                    if (dgvBaiTap.DataSource != null)
                    {
                        (dgvBaiTap.DataSource as IDisposable)?.Dispose();
                    }
                    dgvBaiTap.DataSource = new DataBase().SelectData("SelectHomeWorkAFTERSELECTCLASSForST", lstPara);
                    dgvBaiTap.Columns["id"].HeaderText = "Mã Bài tập";
                    dgvBaiTap.Columns["name"].HeaderText = "Tên Bài tập";
                    dgvBaiTap.Columns["dateStart"].HeaderText = "Ngày bắt đầu";
                    dgvBaiTap.Columns["author"].HeaderText = "Tác giả";
                    dgvBaiTap.Columns["link"].HeaderText = "Link tải bài tập";                        
                    dgvBaiTap.Columns["dateEnd"].HeaderText = "Ngày kết thúc";
                    dgvBaiTap.Columns["TrangThai"].HeaderText = "Tình trạng";
                }
            }
            else
            {

                loadDSHomeWork();
            }

        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            new XemDiem(mahs).ShowDialog();

        }
    }
}
