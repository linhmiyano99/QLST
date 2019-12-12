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
    public class PhieuNhapKhoDAL
    {
        private string connectionString;
        public PhieuNhapKhoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool themPhieuNhap(PhieuNhapKhoDTO PhieuNhapKhoDTO)
        {

            // câu lệnh insert sổ vào bảng
            string query = string.Empty;
            query += "INSERT INTO [tblPHIEUNHAPKHO] ([MaSoPhieu], [Ngay], [MaNCC], [MaNV]) ";
            query += "VALUES (@MaSoPhieu, @Ngay, @MaNCC, @MaNV)";
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
                    cmd.Parameters.AddWithValue("@MaSoPhieu", PhieuNhapKhoDTO.StrMaSoPhieu);
                    cmd.Parameters.AddWithValue("@Ngay", PhieuNhapKhoDTO.StrNgay);
                    cmd.Parameters.AddWithValue("@MaNCC", PhieuNhapKhoDTO.StrMaNCC);
                    cmd.Parameters.AddWithValue("@MaNV", PhieuNhapKhoDTO.StrMaNV);

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
        public bool xoaPhieuNhap(PhieuNhapKhoDTO PhieuNhapKhoDTO)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblPHIEUNHAPKHO WHERE MaSoPhieu = '" + PhieuNhapKhoDTO.StrMaSoPhieu + "'", con))
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

        public bool suaPhieuNhap(PhieuNhapKhoDTO PhieuNhapKhoDTO)
        {
            string query = string.Empty;
            query += "UPDATE [tblPHIEUNHAPKHO] SET Ngay = @Ngay, MaNCC = @MaNCC, MaNV = @MaNV, " +
                " WHERE MaSoPhieu = @MaSoPhieu ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSoPhieu", PhieuNhapKhoDTO.StrMaSoPhieu);
                    cmd.Parameters.AddWithValue("@Ngay", PhieuNhapKhoDTO.StrNgay);
                    cmd.Parameters.AddWithValue("@MaNCC", PhieuNhapKhoDTO.StrMaNCC);
                    cmd.Parameters.AddWithValue("@MaNV", PhieuNhapKhoDTO.StrMaNV);

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

        public List<String> GetSoPhieuID()
        {

            string query = string.Empty;
            query += "SELECT MaSoPhieu FROM [tblPHIEUNHAPKHO]";

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
                                ID = (reader["MaSoPhieu"].ToString());
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

        public DataTable GetDataDanhSachPhieuNhap()
        {

            var table = new DataTable();
            using (var da = new SqlDataAdapter(" SELECT [MaSoPhieu] ,[Ngay], tblNHACUNGCAP.[TenNCC], [tblNHANVIEN].[HoTen] " +
            "FROM[tblPHIEUNHAPKHO] INNER JOIN tblNHACUNGCAP ON  tblNHACUNGCAP.[MaNCC] = tblPHIEUNHAPKHO.MaNCC " +
            "INNER JOIN tblNHANVIEN ON  tblNHANVIEN.MaNV = tblPHIEUNHAPKHO.MaNV", connectionString))
            {
                da.Fill(table);
            }
            return table;
        }

        public DataTable GetDataDanhSachPhieuNhapByKey(string sKey)
        {
            string query = string.Empty;

            query += " SELECT [MaSoPhieu] ,[Ngay], tblNHACUNGCAP.[TenNCC], [tblNHANVIEN].[HoTen] " +
            "FROM[tblPHIEUNHAPKHO] INNER JOIN tblNHACUNGCAP ON  tblNHACUNGCAP.[MaNCC] = tblPHIEUNHAPKHO.MaNCC " +
            "INNER JOIN tblNHANVIEN ON  tblNHANVIEN.MaNV = tblPHIEUNHAPKHO.MaNV";
            query += " WHERE(MaSoPhieu LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(Ngay LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(tblNHACUNGCAP.[TenNCC] LIKE CONCAT('%', @sKey,'%'))";
            query += " OR([tblNHANVIEN].[HoTen] LIKE CONCAT('%', @sKey,'%'))";

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

        public List<string> GetListMaPhieuNhap()
        {

            string query = string.Empty;
            query += "SELECT MaSoPhieu FROM [tblPHIEUNHAPKHO]";

            List<String> ListMa = new List<string>();
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
                                ID = (reader["MaSoPhieu"].ToString());
                                ListMa.Add(ID);
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

            return ListMa;
        }

    }
}
