using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
﻿using QLSTDTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDAL
{
    public class BaoCaoDoanhSoDAL
    {
        private string connectionString;
        public BaoCaoDoanhSoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public DataTable getDanhSachChiTietByKey()
        {
            string query = string.Empty;

            query += " SELECT [SoHoaDon] ,[TongCong], [MaKH]";
            query += " FROM [dbQLST].[dbo].[tblHOADONBANHANG]";


            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))

            {
                da.Fill(table);
            }
            return table;
        }

        public DataTable getDanhSachChiTietByKey(DateTime dt1, DateTime dt2)
        {
            string query = string.Empty;

            query += " SELECT [SoHoaDon] ,[TongCong], [MaKH]";
            query += " FROM [dbQLST].[dbo].[tblHOADONBANHANG]";
            query += " WHERE CONVERT(date, NgayGio) >= CONVERT(date, @NgayBCDS1)";
            query += " AND CONVERT(date, NgayGio) <= CONVERT(date, @NgayBCDS2)";


            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NgayBCDS1", dt1.ToString());
            cmd.Parameters.AddWithValue("@NgayBCDS2", dt2.ToString());

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))

            {
                da.Fill(table);
            }
            return table;
        }
        public DataTable GetTongDoanhSo(DateTime dt1, DateTime dt2)
        {
            string query = string.Empty;

            query += " SELECT SUM([TongCong]) as [Tong]";
            query += " FROM [dbQLST].[dbo].[tblHOADONBANHANG]";
            query += " WHERE CONVERT(date, NgayGio) >= CONVERT(date, @NgayBCDS1)";
            query += " AND CONVERT(date, NgayGio) <= CONVERT(date, @NgayBCDS2)";


            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NgayBCDS1", dt1.ToString());
            cmd.Parameters.AddWithValue("@NgayBCDS2", dt2.ToString());

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))

            {
                da.Fill(table);
            }
            return table;
        }
    }
}