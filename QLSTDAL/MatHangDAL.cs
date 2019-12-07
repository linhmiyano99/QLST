using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDAL
{
   public class MatHangDAL
    {

        private string connectionString;
        public MatHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DataTable getDanhSachMatHang()
        {

            var table = new DataTable();
            using (var da = new SqlDataAdapter(" SELECT * " +
                "FROM tblMATHANG "
                , connectionString))

            {


                da.Fill(table);
            }
            return table;
        }

        public DataTable GetMatHangByKey(string sKey)
        {
            string query = string.Empty;

            query += "SELECT MaMH, TenMH, GiaBan ";
            query += "FROM tblMATHANG ";
            query += " WHERE (MaMH = @sKey)";
        

            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@sKey", sKey);

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))

            {
                da.Fill(table);
            }
            return table;
        }

    }
}
