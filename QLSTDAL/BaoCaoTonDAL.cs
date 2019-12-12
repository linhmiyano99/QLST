using QLSTDTO;
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
    public class BaoCaoTonDAL
    {
        private string connectionString;
        public BaoCaoTonDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public DataTable getDanhSachChiTietByKey()
        {
            string query = string.Empty;

            query += " SELECT [MaMH] ,[TenMH], [GiaNhap], [GiaBan], [TonToiDa], [TonToiThieu] ";
            query += " FROM [dbQLST].[dbo].[tblMatHang]";


            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))

            {
                da.Fill(table);
            }
            return table;
        }
        public DataTable getDanhSachChiTietByKey(string MaMH)
        {
            string query = string.Empty;

            query += " SELECT [MaMH] ,[TenMH], [GiaNhap], [GiaBan], [TonToiDa], [TonToiThieu] ";
            query += " FROM [dbQLST].[dbo].[tblMatHang]";
            query += " WHERE MaMH = @sKey";


            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@sKey", MaMH);

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))

            {
                da.Fill(table);
            }
            return table;
        }
    }
}
