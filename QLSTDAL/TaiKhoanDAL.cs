using QLSTDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDAL
{
    public class TaiKhoanDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }


        //public string ConnectionString { get => connectionString; set => connectionString = value; }

        public TaiKhoanDAL()
        {
            connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool ThemTK(TaiKhoanDTO TaiKhoanDTO)
        {


            string query = @"INSERT INTO tblTAIKHOANNV (TenTK, MatKhau, MaChucVu, MaNV) ";
            query += "VALUES( @TenTK , @MatKhau , @MaChucVu , @MaNV)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@MANV", NhanVienDTO.StrMaNhanVien);
                    command.Parameters.AddWithValue("@TenTK", TaiKhoanDTO.StrTenTk);
                    command.Parameters.AddWithValue("@MatKhau", TaiKhoanDTO.StrMatKhau);
                    command.Parameters.AddWithValue("@MaChucVu", TaiKhoanDTO.IntMaChucVu);
                    command.Parameters.AddWithValue("@MaNV", TaiKhoanDTO.IntMaNV);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        connection.Dispose();
                    }
                    catch (Exception)
                    {
                        connection.Close();
                        return false;
                    }
                }

            }

            return true;

        }

        

        public bool XoaTK(TaiKhoanDTO TaiKhoanDTO)
        {
            string query = string.Empty;
            query += "DELETE FROM tblTAIKHOANNV WHERE MaNV = @MANV";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MANV", TaiKhoanDTO.IntMaNV);
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



        public List<TaiKhoanDTO> SelectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += "SELECT TenTK, MatKhau, MaTK, MaNV, MaChucVu ";
            query += "FROM tblTAIKHOANNV ";
            query += " WHERE MaNV = @sKeyword";


            List<TaiKhoanDTO> ListTaiKhoan = new List<TaiKhoanDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKeyword", sKeyword);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                TaiKhoanDTO taiKhoan = new TaiKhoanDTO();
                                taiKhoan.IntMaTk = Int32.Parse(reader["MaTK"].ToString());
                                taiKhoan.StrTenTk = reader["TenTK"].ToString();
                                taiKhoan.StrMatKhau = reader["MatKhau"].ToString();
                                taiKhoan.IntMaChucVu = Int32.Parse(reader["MaChucVu"].ToString());
                                taiKhoan.IntMaNV = Int32.Parse(reader["MaNV"].ToString());
                                //Add to List
                                ListTaiKhoan.Add(taiKhoan);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception )
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return ListTaiKhoan;
        }

        public List<String> GetTaiKhoanID()
        {

            string query = string.Empty;
            query += "SELECT MaTK FROM tblTAIKHOANNV";

            List<String> ListNhanVienID = new List<string>();
            string ID = string.Empty;

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
                                ID = (reader["MaTK"].ToString());
                                ListNhanVienID.Add(ID);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SELECT ID ERROR -> " + ex.ToString());
                        con.Close();
                        return null;
                    }
                }
            }

            return ListNhanVienID;
        }
    }
}
