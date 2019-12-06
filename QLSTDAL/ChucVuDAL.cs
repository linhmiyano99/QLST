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
    public class ChucVuDAL
    {
        private string connectionString;
        public ChucVuDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool them(ChucVuDTO ChucVuDTO)
        {

            // câu lệnh insert sổ vào bảng
            string query = string.Empty;
            query += "INSERT INTO [tblCHUCVU] ([MaCV], [TenChucVu], [LuongCa]) ";
            query += "VALUES (@MaCV, @TenCV, @LuongCa)";
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
                    cmd.Parameters.AddWithValue("@MaCV", ChucVuDTO.StrMaCV);
                    cmd.Parameters.AddWithValue("@TenCV", ChucVuDTO.StrTenCV);
                    cmd.Parameters.AddWithValue("@LuongCa", ChucVuDTO.FLuongCa);
                   

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
        public bool xoa(ChucVuDTO chucVuDTO)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblCHUCVU WHERE MaCv = '" + chucVuDTO.StrMaCV + "'", con))
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

        public bool sua(ChucVuDTO chucVuDTO)
        {
            string query = string.Empty;
            query += "UPDATE tblCHUCVU SET TenChucVu = @TenCV, LuongCa = @LuongCa WHERE MaCV = @MaCV ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenCV", chucVuDTO.StrTenCV);
                    cmd.Parameters.AddWithValue("@LuongCa", chucVuDTO.FLuongCa);
                    cmd.Parameters.AddWithValue("@MaCv", chucVuDTO.StrMaCV);
                    

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


        public List<ChucVuDTO> Select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [tblCHUCVU]";

            List<ChucVuDTO> ListChucVu = new List<ChucVuDTO>();

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
                                ChucVuDTO chucVuDTO = new ChucVuDTO();
                                chucVuDTO.StrMaCV = (reader["MaCV"].ToString());
                                chucVuDTO.StrTenCV = reader["TenChucVu"].ToString();
                                float LuongCa = float.Parse(reader["LuongCa"].ToString());
                                chucVuDTO.FLuongCa = LuongCa;
                                ListChucVu.Add(chucVuDTO);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return ListChucVu;
        }

        public DataTable getDanhSachCV()
        {

            var table = new DataTable();
            using (var da = new SqlDataAdapter(" SELECT * " +
                "FROM tblCHUCVU "
                , connectionString))

            // using (var da = new SqlDataAdapter(" SELECT MaKH, HoTen, tblKHACHHANG.Diem, tblHang.TenHang " +
            //"FROM tblKHACHHANG " +
            //"INNER JOIN tblHANG ON tblKHACHHANG.MaHang = tblHANG.MaHang", connectionString))
            {


                da.Fill(table);
            }
            return table;
        }


        public DataTable getDanhSachChucVuByKey(string sKey)
        {
            string query = string.Empty;

            query += " SELECT[MaCV] ,[TenChucVu], [LuongCa]";
            query += " FROM[dbQLST].[dbo].[tblCHUCVU] ";
            query += " WHERE(MaCV LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(TenChucVu LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(LuongCa LIKE CONCAT('%', @sKey,'%'))";
          

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
