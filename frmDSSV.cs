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
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDSSV_Load(object sender, EventArgs e)
        {

            loadDSSV();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();
            loadDSSV();
        }

        private void loadDSSV()
        {
            List<SqlParameter> lstPara  = new List<SqlParameter>();
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@tukhoa",
                Value = tukhoa
            }) ;
            dgvSinhVien.DataSource = new DataBase().SelectData("SelectAllSinhVien" , lstPara);

            dgvSinhVien.Columns["id"].HeaderText = "Mã Học Sinh";
            dgvSinhVien.Columns["name"].HeaderText = "Họ Và tên";
            dgvSinhVien.Columns["address"].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns["phone"].HeaderText = "Số điện thoại";
            dgvSinhVien.Columns["gt"].HeaderText = "Giới tính";
            dgvSinhVien.Columns["email"].HeaderText = "Gmail";
            dgvSinhVien.Columns["age"].HeaderText = "Tuổi";

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
            

            classType.DisplayMember = "name";

            classType.ValueMember = "id";
            classType.DataSource = new DataBase().SelectData("SelectAllClass", lstPara);


        }
        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var mhs = dgvSinhVien.Rows[e.RowIndex].Cells["id"].Value.ToString();
                new frmSinhVien(mhs).ShowDialog();
                loadDSSV();

            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            if (classType.SelectedValue != null)
            {
                int classId;
                if (int.TryParse(classType.SelectedValue.ToString(), out classId))
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
                    if (dgvSinhVien.DataSource != null)
                    {
                        (dgvSinhVien.DataSource as IDisposable)?.Dispose();
                    }
                    dgvSinhVien.DataSource = new DataBase().SelectData("SelectHSAFTERSELECTCLASS", lstPara);
                    dgvSinhVien.Columns["id"].HeaderText = "Mã Học Sinh";
                    dgvSinhVien.Columns["name"].HeaderText = "Họ và Tên";
                    dgvSinhVien.Columns["address"].HeaderText = "Địa chỉ";
                    dgvSinhVien.Columns["phone"].HeaderText = "Số Điện Thoại";
                    dgvSinhVien.Columns["gt"].HeaderText = "Giới Tính";
                    dgvSinhVien.Columns["email"].HeaderText = "Gmail";
                    dgvSinhVien.Columns["age"].HeaderText = "Tuổi";
                }
            } else
            {
                
                loadDSSV();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void classType_MouseClick(object sender, MouseEventArgs e)
        {


            loadClassType();
           
        }

       private void classType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadClassType();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
