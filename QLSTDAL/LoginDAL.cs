using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDAL
{
    public class LoginDAL
    {
        private string connectionString;
        public LoginDAL()
        {
            connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
        }


        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DataTable CheckAccount(string accountID, string password)
        {
            string query = "SELECT MaTK FROM tblTAIKHOANNV WHERE TenTK='" + accountID + "' and MatKhau='" + password + "'";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))

            {
                da.Fill(table);
            }
            return table;

        }



        public DataTable GetAccountType(string accountID)
        {
            string query = "select MaChucVu, MaNV from tblTAIKHOANNV where TenTK='" + accountID + "'";

            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))

            {
                da.Fill(table);
            }
            return table;
        }
    }
}
