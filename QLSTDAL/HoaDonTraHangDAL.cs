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
    public class HoaDonTraHangDAL
    {
        private string connectionString;
        public HoaDonTraHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool them(HoaDonTraHangDTO hoaDonTraHangDto)
        {

            // câu lệnh insert sổ vào bảng
            string query = string.Empty;
            query += "INSERT INTO [tblHOADONTRAHANG] ([SoHoaDon], [MaNV], [NgayGio]) ";
            query += "VALUES (@SoHoaDon, @MaNV, @NgayGio)";
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
                    cmd.Parameters.AddWithValue("@SoHoaDon", hoaDonTraHangDto.StrSoHoaDon);
                    cmd.Parameters.AddWithValue("@MaNV", hoaDonTraHangDto.StrMaNV);
                    cmd.Parameters.AddWithValue("@NgayGio", hoaDonTraHangDto.StrNgayGio);

                    //---------------------------

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception )
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public bool xoa(HoaDonTraHangDTO hoaDonTraHangDto)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblHOADONTRAHANG WHERE SoHoaDon = '" + hoaDonTraHangDto.StrSoHoaDon + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException )
            {
                return false;
            }
            return true;


        }

        public bool sua(HoaDonTraHangDTO hoaDonTraHangDto)
        {
            string query = string.Empty;
            query += "UPDATE tblHOADONTRAHANG SET MaNV = @MaNV,  NgayGio = @NgayGio WHERE SoHoaDon = @SoHoaDon ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@SoHoaDon", hoaDonTraHangDto.StrSoHoaDon);
                    cmd.Parameters.AddWithValue("@MaNV", hoaDonTraHangDto.StrMaNV);
                    cmd.Parameters.AddWithValue("@NgayGio", hoaDonTraHangDto.StrNgayGio);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception )
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
