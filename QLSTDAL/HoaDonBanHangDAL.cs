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
    public class HoaDonBanHangDAL
    {
        private string connectionString;
        public HoaDonBanHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool them(HoaDonBanHangDTO hoaDonBanHangDto)
        {

            // câu lệnh insert sổ vào bảng
            string query = string.Empty;
            query += "INSERT INTO [tblHOADONBANHANG] ([SoHoaDon], [TongSo], [TongCong], [TienKhachTra], [MaNV], [DiemMuaHang], [MaKH], [DiemSauMuaHang], [NgayGio]) ";
            query += "VALUES (@SoHoaDon, @TongSo, @TongCong, @TienKhachTra, @MaNV, @DiemMuaHang, @MaKH, @DiemSauMuaHang, @NgayGio)";
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
                    cmd.Parameters.AddWithValue("@SoHoaDon", hoaDonBanHangDto.StrSoHoaDon);
                    cmd.Parameters.AddWithValue("@TongSo", hoaDonBanHangDto.ITongSo);
                    cmd.Parameters.AddWithValue("@TongCong", hoaDonBanHangDto.DTongCong);
                    cmd.Parameters.AddWithValue("@TienKhachTra", hoaDonBanHangDto.DTienKhachTra);
                    cmd.Parameters.AddWithValue("@MaNV", hoaDonBanHangDto.StrMaNV);
                    cmd.Parameters.AddWithValue("@DiemMuaHang", hoaDonBanHangDto.IDiemMuaHang);
                    cmd.Parameters.AddWithValue("@MaKH", hoaDonBanHangDto.StrMaKH);
                    cmd.Parameters.AddWithValue("@DiemSauMuaHang", hoaDonBanHangDto.IDiemSauMuaHang);
                    cmd.Parameters.AddWithValue("@NgayGio", hoaDonBanHangDto.StrNgayGio);

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
        public bool xoa(HoaDonBanHangDTO hoaDonBanHangDto)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblHOADONBANHANG WHERE SoHoaDon = '" + hoaDonBanHangDto.StrSoHoaDon + "'", con))
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

        public bool sua(HoaDonBanHangDTO hoaDonBanHangDto)
        {
            string query = string.Empty;
            query += "UPDATE tblHOADONBANHANG SET TongSo = @TongSo, TongCong = @TongCong, TienKhachTra = @TienKhachTra, " +
                " MaNV = @MaNV, DiemMuaHang = @DiemMuaHang, MaKH = @MaKH, DiemSauMuaHang = @DiemSauMuaHang, NgayGio = @NgayGio " +
                " WHERE SoHoaDon = @SoHoaDon ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@SoHoaDon", hoaDonBanHangDto.StrSoHoaDon);
                    cmd.Parameters.AddWithValue("@TongSo", hoaDonBanHangDto.ITongSo);
                    cmd.Parameters.AddWithValue("@TongCong", hoaDonBanHangDto.DTongCong);
                    cmd.Parameters.AddWithValue("@TienKhachTra", hoaDonBanHangDto.DTienKhachTra);
                    cmd.Parameters.AddWithValue("@MaNV", hoaDonBanHangDto.StrMaNV);
                    cmd.Parameters.AddWithValue("@DiemMuaHang", hoaDonBanHangDto.IDiemMuaHang);
                    cmd.Parameters.AddWithValue("@MaKH", hoaDonBanHangDto.StrMaKH);
                    cmd.Parameters.AddWithValue("@DiemSauMuaHang", hoaDonBanHangDto.IDiemSauMuaHang);
                    cmd.Parameters.AddWithValue("@NgayGio", hoaDonBanHangDto.StrNgayGio);
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

        public List<String> GetHoaDonID()
        {

            string query = string.Empty;
            query += "SELECT SoHoaDon FROM [tblHOADONBANHANG]";

            List<String> ListHD = new List<string>();
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
                                ID = (reader["SoHoaDon"].ToString());
                                ListHD.Add(ID);
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

            return ListHD;
        }
    }
}
