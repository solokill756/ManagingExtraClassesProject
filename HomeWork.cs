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
    public partial class HomeWork : Form
    {
        private string hwId;
        public HomeWork(string hwId)
        {
            InitializeComponent();
            this.hwId = hwId;
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


            lstClass.DisplayMember = "name";

            lstClass.ValueMember = "id";
            lstClass.DataSource = new DataBase().SelectData("SelectAllClass", lstPara);
            lstClass.SelectedIndex = -1;
        }

        private void HomeWork_Load(object sender, EventArgs e)
        {
            loadClassType();
            if (string.IsNullOrEmpty(hwId.ToString()))
            {
                this.Text = "Thêm mới bài tập";
               
            }
            else
            {
                this.Text = "Cập nhật Bài tập";
                var r = new DataBase().Select("selectHomeWork '" + hwId + "'");
                txtTenBt.Text = r["name"].ToString();
                txtTacGia.Text = r["author"].ToString();
                txtNgayBatDau.Text = r["dateStart"].ToString();
                txtNgayKetThuc.Text = r["dateEnd"].ToString();
                txtLinkBaiTap.Text = r["link"].ToString();
                lstClass.SelectedValue = r["class_id"].ToString();
            }

            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            DateTime ngayBatDau, ngayKetThuc;
            try
            {
                ngayBatDau = DateTime.ParseExact(txtNgayBatDau.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            } catch  (Exception ex)
            {
                MessageBox.Show("Ngày bắt đầu không hợp lệ");
                txtNgayBatDau.Select();
                return;
            }

            try
            {
                ngayKetThuc = DateTime.ParseExact(txtNgayKetThuc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày kết thúc không hợp lệ");
                txtNgayKetThuc.Select();
                return;
            }
            if(lstClass.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học");
                return;
            }

            if (string.IsNullOrEmpty(hwId.ToString()))
            {
                sql = "ThemMoiHomeWork";
            }
            else
            {
                sql = "updateHomeWork";
                lstPara.Add(new SqlParameter()
                {
                    ParameterName = "@id",
                    Value = hwId,
                    SqlDbType = SqlDbType.Int
                });
            }
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@name",
                Value = txtTenBt.Text.ToString(),
                SqlDbType = SqlDbType.NVarChar
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@dateStart",
                Value = ngayBatDau,
                SqlDbType = SqlDbType.DateTime
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@author",
                Value = txtTacGia.Text.ToString(),
                SqlDbType = SqlDbType.NVarChar
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@link",
                Value = txtLinkBaiTap.Text.ToString(),
                SqlDbType = SqlDbType.VarChar
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@dateEnd",
                Value = ngayKetThuc,
                SqlDbType = SqlDbType.DateTime
            });
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@class_id",
                Value = lstClass.SelectedValue,
                SqlDbType = SqlDbType.Int
            });
            var rs = new DataBase().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(hwId.ToString()))
                {
                    MessageBox.Show("Thêm bài tập thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật bài tập thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Try vấn thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "deleteHomeWork";
            List<SqlParameter> lstPara = new List<SqlParameter>();
            lstPara.Add(new SqlParameter()
            {
                ParameterName = "@id",
                Value = hwId,
                SqlDbType = SqlDbType.Int // Đặt kiểu dữ liệu tương ứng với dữ liệu cần lưu trữ trong cơ sở dữ liệu
            });
            var rs = new DataBase().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Xóa Bài tập thành công");
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Thực thi Thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
