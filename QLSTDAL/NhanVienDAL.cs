using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using QLSTDTO;
using System.Data.SqlClient;
using System.Data;

namespace QLSTDAL
{
    public class NhanVienDAL
    {

        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }


        //public string ConnectionString { get => connectionString; set => connectionString = value; }

        public NhanVienDAL()
        {
            connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool ThemNV(NhanVienDTO NhanVienDTO)
        {

            string query = @"INSERT INTO tblNHANVIEN( MaNV, HoTen,  MaCV,  SDT, DiaChi, Luong, TongCaLam)";
            query += "VALUES( @MANV , @HOTEN , @MACHUCVU , @SDT , @DIACHI , @LUONG , @TONGCALAM )";
           


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MANV", NhanVienDTO.StrMaNhanVien);
                    command.Parameters.AddWithValue("@HOTEN", NhanVienDTO.StrHoTen);
                    command.Parameters.AddWithValue("@MACHUCVU", NhanVienDTO.StrMaChucVu);
                    command.Parameters.AddWithValue("@SDT", NhanVienDTO.StrSoDT);
                    command.Parameters.AddWithValue("@DIACHI", NhanVienDTO.StrDiaChi);
                    command.Parameters.AddWithValue("@LUONG", NhanVienDTO.FlLuong);
                    command.Parameters.AddWithValue("@TONGCALAM", NhanVienDTO.IntTongCaLam);
                   
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

        public bool SuaNV(NhanVienDTO NhanVienDTO)
        {
            string query = string.Empty;

            query += "UPDATE [tblNHANVIEN] ";
            query += "SET [HoTen] = @HOTEN ,  [MaCV] = @MACHUCVU ,  ";
            query += "[SDT] = @SDT , [DiaChi] = @DIACHI , [Luong] = @LUONG , [TongCaLam] = @TONGCALAM ";
            query += "WHERE [MaNV] = @MANV";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = con;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = query;

                    command.Parameters.AddWithValue("@MANV", NhanVienDTO.StrMaNhanVien);
                    command.Parameters.AddWithValue("@HOTEN", NhanVienDTO.StrHoTen);
                    command.Parameters.AddWithValue("@MACHUCVU", NhanVienDTO.StrMaChucVu);
                    command.Parameters.AddWithValue("@DIACHI", NhanVienDTO.StrDiaChi);
                    command.Parameters.AddWithValue("@SDT", NhanVienDTO.StrSoDT);
                    command.Parameters.AddWithValue("@LUONG", NhanVienDTO.FlLuong);
                    command.Parameters.AddWithValue("@TONGCALAM", NhanVienDTO.IntTongCaLam);
                    try
                    {
                        con.Open();
                        command.ExecuteNonQuery();
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

        public bool XoaNV(NhanVienDTO NhanVienDTO)
        {
            string query = string.Empty;
            query += "DELETE FROM tblNHANVIEN WHERE MaNV = @MANV";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MANV", NhanVienDTO.StrMaNhanVien);
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


       
        public DataTable GetDanhSachNhanVien()
        {
            string query = string.Empty;
            query += "SELECT MaNV, HoTen , tblCHUCVU.TenChucVu, DiaChi, SDT, Luong, TongCaLam ";
            query += "FROM tblNHANVIEN ";
            query += "INNER JOIN tblCHUCVU ON  tblCHUCVU.MaCV = tblNHANVIEN.MaCV ";
            query += "ORDER BY MANV  ASC";

            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
         

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))

            {
                da.Fill(table);
            }
            return table;
        }

        public DataTable GetDanhSachNhanVienByKey(string sKey)
        {
            string query = string.Empty;

            query += "SELECT MaNV, HoTen , tblCHUCVU.TenChucVu, DiaChi, SDT, Luong, TongCaLam ";
            query += "FROM tblNHANVIEN ";
            query += " INNER JOIN tblCHUCVU ON  tblCHUCVU.MaCV = tblNHANVIEN.MaCV  ";
            query += " WHERE (MaNV LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(HoTen LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(TenChucVu LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(SDT LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(DiaChi LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(Luong LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(TongCaLam LIKE CONCAT('%', @sKey,'%'))";

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


        

        public int Select_IDENT_CURRENT(int IdentCurrent)
        {

            string query = string.Empty;
            query += " SELECT IDENT_CURRENT('NHANVIEN') as LastID ";

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
                                IdentCurrent = Int32.Parse(reader["LastID"].ToString());

                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception)
                    {
                        con.Close();

                    }
                }
            }
            return IdentCurrent;
        }

        public List<String> GetTblNhanVienID()
        {

            string query = string.Empty;
            query += "SELECT MaNV FROM tblNHANVIEN";

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
                               ID = (reader["MaNV"].ToString());
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

        public List<String> GetNhanVienInfoByMaNV(string MaNV)
        {

            string query = string.Empty;
            query += "SELECT HoTen FROM tblNHANVIEN Where MaNV = " + MaNV;

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
                                ID = (reader["HoTen"].ToString());
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