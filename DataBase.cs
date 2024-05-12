using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudentsProject
{
    public class DataBase
    {
        private string connetionString = "Data Source=LAPTOP-NG0LH2VR\\SQLEXPRESS; Initial Catalog = THUCLASS; User ID = sa; Password = 0838664246";
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        public DataBase() {
            try
            {
                conn  = new SqlConnection(connetionString);
               
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Connected failed:" + ex.Message);
            }
        }

        public DataTable SelectData(string sql , List<SqlParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.ParameterName , para.Value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        } 

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public int ExeCute(string sql , List<SqlParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in  lstPara)
                {
                    cmd.Parameters.AddWithValue(p.ParameterName , p.Value);

                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
