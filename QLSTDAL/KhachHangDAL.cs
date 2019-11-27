using QLSTDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDAL
{
   public class KhachHangDAL
   {
        private string connectionString;
        public KhachHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool them(KhachHangDTO khachHangDto)
        {

            // câu lệnh insert sổ vào bảng
            string query = string.Empty;
            query += "INSERT INTO [tblKHACHHANG] ([MaKH], [HoTen], [Diem], [MaHang]) ";
            query += "VALUES (@MaKH, @HoTen, @Diem, @MaHang)";
            //----------------------------

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    //---------------------

                    //Tham số từ sổ tiết kiệm
                    cmd.Parameters.AddWithValue("@MaKH", khachHangDto.StrMaKH);
                    cmd.Parameters.AddWithValue("@HoTen", khachHangDto.StrHoTen);
                    cmd.Parameters.AddWithValue("@Diem", khachHangDto.DDiem);
                    cmd.Parameters.AddWithValue("@MaHang", khachHangDto.StrMaHang);

                    //---------------------------

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
        public bool xoa(KhachHangDTO khachHangDto)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblKHACHHANG WHERE MaKH = '" + khachHangDto.StrMaKH + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                return false;
            }
            return true;


        }

        public bool sua(KhachHangDTO khachHangDto)
        {
            string query = string.Empty;
            query += "UPDATE tblKHACHHANG SET HoTen = @HoTen, Diem = @Diem, MaHang = @MaHang WHERE MaKH = @MaKH ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaKH", khachHangDto.StrMaKH);
                    cmd.Parameters.AddWithValue("@HoTen", khachHangDto.StrHoTen);
                    cmd.Parameters.AddWithValue("@Diem", khachHangDto.DDiem);
                    cmd.Parameters.AddWithValue("@MaHang", khachHangDto.StrMaHang);
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
    }
}
