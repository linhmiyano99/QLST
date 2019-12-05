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
    public class HangDAL
    {
        private string connectionString;
        public HangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool them(HangDTO hangDto)
        {

            // câu lệnh insert sổ vào bảng
            string query = string.Empty;
            query += "INSERT INTO [tblHANG] ([MaHang], [TenHang], [ChietKhau], [Diem]) ";
            query += "VALUES (@MaHang, @TenHang, @ChietKhau, @Diem)";
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
                    cmd.Parameters.AddWithValue("@MaHang", hangDto.StrMaHang);
                    cmd.Parameters.AddWithValue("@TenHang", hangDto.StrTenHang);
                    cmd.Parameters.AddWithValue("@ChietKhau", hangDto.FChietKhau);
                    cmd.Parameters.AddWithValue("@Diem", hangDto.DDiem);

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
        public bool xoa(HangDTO hangDto)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblHANG WHERE MaHang = '" + hangDto.StrMaHang + "'", con))
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

        public bool sua(HangDTO hangDto)
        {
            string query = string.Empty;
            query += "UPDATE tblHANG SET TenHang = @TenHang, ChietKhau = @ChietKhau, Diem = @Diem WHERE MaHang = @MaHang ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenHang", hangDto.StrTenHang);
                    cmd.Parameters.AddWithValue("@ChietKhau", hangDto.FChietKhau);
                    cmd.Parameters.AddWithValue("@Diem", hangDto.DDiem);
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


        public List<HangDTO> Select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [tblHANG]";

            List<HangDTO> listhang = new List<HangDTO>();

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
                                HangDTO hang = new HangDTO();
                                hang.StrMaHang = (reader["MaHang"].ToString());
                                hang.StrTenHang = reader["TenHang"].ToString();
                                double diem = double.Parse( reader["Diem"].ToString());
                                hang.DDiem = diem;
                                float chietkhau = float.Parse(reader["ChietKhau"].ToString());
                                hang.FChietKhau = chietkhau;
                                listhang.Add(hang);
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
            return listhang;
        }

    }
}
