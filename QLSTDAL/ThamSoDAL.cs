using QLSTDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace QLSTDAL
{
    public class ThamSoDAL
    {
        private string connectionString;
        public ThamSoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool suaThamSo(ThamSoDTO ts)
        {
      
            string query = string.Empty;

            query += "UPDATE tblTHAMSO SET " +
                    "ChietKhauHangVang = @fChietKhauHangVang, " +
                    "ChietKhauHangBac = @fChietKhauHangBac, " +
                    "ChietKhauHangBachKim = @fChietKhauHangBachKim, " +
                    "LuongCa = @dLuongCa " +
                    "Where MaTS = '1'";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@fChietKhauHangVang", ts.FChietKhauVang);
                    cmd.Parameters.AddWithValue("@fChietKhauHangBac", ts.FChietKhauBac);
                    cmd.Parameters.AddWithValue("@fChietKhauHangBachKim", ts.FChietKhauBachKim);
                    cmd.Parameters.AddWithValue("@dLuongCa", ts.DLuongCa);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception )
                    {
                        XtraMessageBox.Show("LỖI TẦNG DAL!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public DataTable getThamSo()
        {

            var table = new DataTable();
            using (var da = new SqlDataAdapter("SELECT * FROM tblTHAMSO", connectionString))
            {
                da.Fill(table);
            }
            return table;
        }
        public List<ThamSoDTO> selectListThamSo()
        {

            return null;
        }
    }
}
