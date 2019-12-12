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
    public class NhaCungCapDAL
    {
        private string connectionString;
        public NhaCungCapDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool themNhaCungCap(NhaCungCapDTO nhaCungCap)
        {

            // câu lệnh insert sổ vào bảng
            string query = string.Empty;
            query += "INSERT INTO [tblNHACUNGCAP] ([MaNCC], [TenNCC]) ";
            query += "VALUES (@MaNCC, @TenNCC)";
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
                    cmd.Parameters.AddWithValue("@MaNCC", nhaCungCap.StrMaNhaCungCap);
                    cmd.Parameters.AddWithValue("@TenNCC", nhaCungCap.StrTenNhaCungCap);


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
        public bool xoaNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblNHACUNGCAP WHERE MaNCC = '" + nhaCungCap.StrMaNhaCungCap + "'", con))
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

        public bool suaNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            string query = string.Empty;
            query += "UPDATE tblNHACUNGCAP SET TenNCC = @TenNCC WHERE MaNCC = @MaNCC ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenNCC", nhaCungCap.StrTenNhaCungCap);
                    cmd.Parameters.AddWithValue("@MaNCC", nhaCungCap.StrMaNhaCungCap);


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


        public List<NhaCungCapDTO> Select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [tblNHACUNGCAP]";

            List<NhaCungCapDTO> listNhaCungCap = new List<NhaCungCapDTO>();

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
                                NhaCungCapDTO NhaCungCap = new NhaCungCapDTO();
                                NhaCungCap.StrMaNhaCungCap = (reader["MaNCC"].ToString());
                                NhaCungCap.StrTenNhaCungCap = reader["TenNCC"].ToString();

                                listNhaCungCap.Add(NhaCungCap);
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
            return listNhaCungCap;
        }

        public DataTable getDanhSachHang()
        {

            var table = new DataTable();
            using (var da = new SqlDataAdapter(" SELECT *FROM tblNHACUNGCAP ", connectionString))
            {
                da.Fill(table);
            }
            return table;
        }


        public DataTable getDanhSachNCCByKey(string sKey)
        {
            string query = string.Empty;

            query += " SELECT[MaNCC] ,[TenNCC]";
            query += " FROM[dbQLST].[dbo].[tblNHACUNGCAP] ";
            query += " WHERE(MaNCC LIKE CONCAT('%', @sKey,'%'))";
            query += " OR(TenNCC LIKE CONCAT('%', @sKey,'%'))";
           

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
