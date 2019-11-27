using QLSTDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


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
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    query += "UPDATE tblTHAMSO SET " +
                    "ChietKhauHangVang = @fChietKhauHangVang, " +
                    "ChietKhauHangBac = @fChietKhauHangBac, " +
                    "ChietKhauHangBachKim = @fChietKhauHangBachKim, " +
                    "LuongCa = @dLuongCa " +
                    "Where MaTS = '1'";
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
                    catch (Exception ex)
                    {
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
