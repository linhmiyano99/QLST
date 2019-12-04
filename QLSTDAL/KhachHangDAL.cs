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
                    catch (Exception)
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
            catch (SystemException)
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
                    catch (Exception)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public DataTable getDanhSachKhachHang()
        {

            var table = new DataTable();
            using (var da = new SqlDataAdapter(" SELECT * " +
                "FROM tblKHACHHANG "
                , connectionString))

            // using (var da = new SqlDataAdapter(" SELECT MaKH, HoTen, tblKHACHHANG.Diem, tblHang.TenHang " +
            //"FROM tblKHACHHANG " +
            //"INNER JOIN tblHANG ON tblKHACHHANG.MaHang = tblHANG.MaHang", connectionString))
            {


                da.Fill(table);
            }
            return table;
        }

        //Get Danh Sach Khach Hang theo List
        public List<KhachHangDTO> getListDanhSachKhachHang()
        {
            string query = string.Empty;
            query += "SELECT  MaKH, HoTen, Diem, tblHang.TenHang FROM tblKHACHHANG";
            query += " INNER JOIN tblHANG ON tblKHACHHANG.MaHang = tblHANG.MaHang";


            List<KhachHangDTO> listKhachHang = new List<KhachHangDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                KhachHangDTO khachHangDTO = new KhachHangDTO();
                                khachHangDTO.StrMaKH = (reader["MaKH"].ToString());
                                khachHangDTO.StrHoTen = reader["HoTen"].ToString();

                                string DDiem = reader["Diem"].ToString();
                                khachHangDTO.DDiem = double.Parse(DDiem.ToString());

                                khachHangDTO.StrMaHang = reader["MaHang"].ToString();
                                listKhachHang.Add(khachHangDTO);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("KHAC_HANG_DAL_ERROR-> " + ex.ToString());
                        con.Close();
                        return null;
                    }
                }
            }
            return listKhachHang;
        }

        public List<KhachHangDTO> getListKhachHangByKey(string sKey)
        {
            string query = string.Empty;

            query += " SELECT[MaKH] ,[HoTen], [Diem], [MaHang]";
            query += " FROM[dbQLST].[dbo].[tblKHACHHANG] ";
            query += " WHERE(MaKH LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(HoTen LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(Diem LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(MaHang LIKE CONCAT('%', @sKey,'%'))";


            List<KhachHangDTO> listKhachHang = new List<KhachHangDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKey", sKey);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                KhachHangDTO khachHangDTO = new KhachHangDTO();
                                khachHangDTO.StrMaKH = (reader["MaKH"].ToString());
                                khachHangDTO.StrHoTen = reader["HoTen"].ToString();

                                string DDiem = reader["Diem"].ToString();
                                khachHangDTO.DDiem = double.Parse(DDiem.ToString());

                                khachHangDTO.StrMaHang = reader["MaHang"].ToString();
                                listKhachHang.Add(khachHangDTO);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("KHAC_HANG_DAL_ERROR-> " + ex.ToString());
                        con.Close();
                        return null;
                    }
                }
            }
            return listKhachHang;
        }

        // LIKE CONCAT('%', @sKeyword,'%')

    }
}
