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
    public class ChiTietPhieuNhapKhoDAL
    {
        private string connectionString;
        public ChiTietPhieuNhapKhoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool them(ChiTietPhieuNhapKhoDTO chiTietPhieuNhapKhoDTO)
        {

            // câu lệnh insert sổ vào bảng
            string query = string.Empty;
            query += "INSERT INTO [tblCHITIETPHIEUNHAPKHO] ([MaSoPhieu] ,[MaMH], [SoLuongTheoChungTu], [SoLuongThucNhap], [DonGia] ,[ThanhTien]) ";
            query += "VALUES (@MaSoPhieu, @MaMH, @SoLuongTheoChungTu, @SoLuongThucNhap,@DonGia, @ThanhTien)";
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
                    cmd.Parameters.AddWithValue("@MaSoPhieu", chiTietPhieuNhapKhoDTO.StrMaSoPhieu);
                    cmd.Parameters.AddWithValue("@MaMH", chiTietPhieuNhapKhoDTO.StrMaMH);
                    cmd.Parameters.AddWithValue("@SoLuongTheoChungTu", chiTietPhieuNhapKhoDTO.ISoLuongTheoChungTu);
                    cmd.Parameters.AddWithValue("@SoLuongThucNhap", chiTietPhieuNhapKhoDTO.ISoLuongThucNhap);
                    cmd.Parameters.AddWithValue("@DonGia", chiTietPhieuNhapKhoDTO.DDonGia);
                    cmd.Parameters.AddWithValue("@ThanhTien", chiTietPhieuNhapKhoDTO.DThanhTien);

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
        public bool xoa(ChiTietPhieuNhapKhoDTO chiTietPhieuNhapKhoDTO)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblCHITIETPHIEUNHAPKHO WHERE MaSoPhieu = '" + chiTietPhieuNhapKhoDTO.StrMaSoPhieu + "'", con))
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

        public bool sua(ChiTietPhieuNhapKhoDTO chiTietPhieuNhapKhoDTO)
        {
           
        string query = string.Empty;
        query += "UPDATE tblCHITIETPHIEUNHAPKHO SET MaMH = @MaMH, SoLuongTheoChungTu = @SoLuongTheoChungTu, DonGia = @DonGia , ThanhTien = @ThanhTien , SoLuongThucNhap = @SoLuongThucNhap  " +
                " WHERE MaSoPhieu = @MaSoPhieu ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSoPhieu", chiTietPhieuNhapKhoDTO.StrMaSoPhieu);
                    cmd.Parameters.AddWithValue("@MaMH", chiTietPhieuNhapKhoDTO.StrMaMH);
                    cmd.Parameters.AddWithValue("@SoLuongTheoChungTu", chiTietPhieuNhapKhoDTO.ISoLuongTheoChungTu);
                    cmd.Parameters.AddWithValue("@DonGia", chiTietPhieuNhapKhoDTO.DDonGia);
                    cmd.Parameters.AddWithValue("@ThanhTien", chiTietPhieuNhapKhoDTO.DThanhTien);
                    cmd.Parameters.AddWithValue("@SoLuongThucNhap", chiTietPhieuNhapKhoDTO.ISoLuongThucNhap);
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



    }
}
