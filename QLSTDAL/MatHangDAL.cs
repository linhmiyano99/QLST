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

   public class MatHangDAL
    {
        private string connectionString;
        public MatHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool them(MatHangDTO matHangDto)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblMATHANG] ([MaMH],[Barcode] [TenMH], [GiaNhap], [GiaBan], [TonToiDa], [TonToiThieu]) ";
            query += "VALUES (@MaMH, @Barcode, @TenMH, @GiaNhap, @GiaBan, @TonToiDa, @TonToiThieu)";
            //----------------------------

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaMH", matHangDto.StrMaMH);
                    cmd.Parameters.AddWithValue("@Barcode", matHangDto.StrBarcode);
                    cmd.Parameters.AddWithValue("@TenMH", matHangDto.StrTenMH);
                    cmd.Parameters.AddWithValue("@GiaNhap", matHangDto.DGiaNhap);
                    cmd.Parameters.AddWithValue("@GiaBan", matHangDto.StrDonGia);
                    cmd.Parameters.AddWithValue("@TonToiDa", matHangDto.ITonToiDa);
                    cmd.Parameters.AddWithValue("@TonToiThieu", matHangDto.ITonToiThieu);
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
        public bool xoa(MatHangDTO matHangDto)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblMATHANG WHERE MaMH = '" + matHangDto.StrMaMH + "'", con))
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

        public bool sua(MatHangDTO matHangDto)
        {
            string query = string.Empty;
            query += "UPDATE tblMATHANG SET" +
                " Barcode = @Barcode, TenMH = @TenMH, GiaNhap = @GiaNhap," +
                " GiaBan = @GiaBan, TonToiDa = @TonToiDa, TonToiThieu = @TonToiThieu " +
                " WHERE MaMH = @MaMH ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaMH", matHangDto.StrMaMH);
                    cmd.Parameters.AddWithValue("@Barcode", matHangDto.StrBarcode);
                    cmd.Parameters.AddWithValue("@TenMH", matHangDto.StrTenMH);
                    cmd.Parameters.AddWithValue("@GiaNhap", matHangDto.DGiaNhap);
                    cmd.Parameters.AddWithValue("@GiaBan", matHangDto.StrDonGia);
                    cmd.Parameters.AddWithValue("@TonToiDa", matHangDto.ITonToiDa);
                    cmd.Parameters.AddWithValue("@TonToiThieu", matHangDto.ITonToiThieu);

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

        public DataTable getDanhSachMatHang()
        {
            var table = new DataTable();
            using (var da = new SqlDataAdapter(" SELECT * "+"FROM tblMATHANG ", connectionString))
            {
                da.Fill(table);
            }
            return table;
        }

        public DataTable GetMatHangByKey(string sKey)
        {
            string query = string.Empty;

            query += "SELECT MaMH, TenMH, GiaBan ";
            query += "FROM tblMATHANG ";
            query += " WHERE (MaMH = @sKey)";
        

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

        public bool capNhatSoLuong( string MaMH, string SoLuong)
        {
            string query = string.Empty;
            query += "UPDATE tblMATHANG SET" +
                " TonToiDa = @SoLuong,  " +
                " WHERE MaMH = @MaMH ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaMH", MaMH);
                    cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
                  

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
