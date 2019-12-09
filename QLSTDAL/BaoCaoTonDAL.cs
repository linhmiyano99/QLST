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
        public DataTable getDanhSachChiTietByKey(int iThang, int iNam)
        {
            string query = string.Empty;

            query += " SELECT [MaMH] ,[Ton], [GiaVon], [GiaBan]";
            query += " FROM [dbQLST].[dbo].[tblCHITIETBAOCAOTON]";
            query += " WHERE MONTH(NgayGio) = @Thang";
            query += " AND YEAR(NgayGio) = @Nam";


            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Thang", iThang);
            cmd.Parameters.AddWithValue("@Nam", iNam);

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))

            {
                da.Fill(table);
            }
            return table;
        }
    }
}
