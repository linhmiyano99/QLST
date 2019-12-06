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
    public class ChiTietHoaDonBanHangDAL
    {
        private string connectionString;
        public ChiTietHoaDonBanHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool them(ChiTietHoaDonBanHangDTO chiTietHoaDonBanHangDto)
        {

            // câu lệnh insert sổ vào bảng
            string query = string.Empty;
            query += "INSERT INTO [tblCHITIETHOADONBANHANG] ([SoHoaDon], [MaMH], [SoLuong], [DonGia], [ThanhTien]) ";
            query += "VALUES (@SoHoaDon, @MaMH, @SoLuong, @DonGia, @ThanhTien)";
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
                    cmd.Parameters.AddWithValue("@SoHoaDon", chiTietHoaDonBanHangDto.StrSoHoaDon);
                    cmd.Parameters.AddWithValue("@MaMH", chiTietHoaDonBanHangDto.StrMaMH);
                    cmd.Parameters.AddWithValue("@SoLuong", chiTietHoaDonBanHangDto.ISoLuong);
                    cmd.Parameters.AddWithValue("@DonGia", chiTietHoaDonBanHangDto.DDonGia);
                    cmd.Parameters.AddWithValue("@ThanhTien", chiTietHoaDonBanHangDto.DThanhTien);

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
        public bool xoa(ChiTietHoaDonBanHangDTO chiTietHoaDonBanHangDto)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblCHITIETHOADONBANHANG WHERE SoHoaDon = '" + chiTietHoaDonBanHangDto.StrSoHoaDon + "'", con))
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

        public bool sua(ChiTietHoaDonBanHangDTO chiTietHoaDonBanHangDto)
        {
            string query = string.Empty;
            query += "UPDATE tblHOADONBANHANG SET MaMH = @MaMH, SoLuong = @SoLuong, DonGia = @DonGia , ThanhTien = @ThanhTien  " +
                " WHERE SoHoaDon = @SoHoaDon ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@SoHoaDon", chiTietHoaDonBanHangDto.StrSoHoaDon);
                    cmd.Parameters.AddWithValue("@MaMH", chiTietHoaDonBanHangDto.StrMaMH);
                    cmd.Parameters.AddWithValue("@SoLuong", chiTietHoaDonBanHangDto.ISoLuong);
                    cmd.Parameters.AddWithValue("@DonGia", chiTietHoaDonBanHangDto.DDonGia);
                    cmd.Parameters.AddWithValue("@ThanhTien", chiTietHoaDonBanHangDto.DThanhTien);
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
