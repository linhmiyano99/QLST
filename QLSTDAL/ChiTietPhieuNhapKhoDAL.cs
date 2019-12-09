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
    class ChiTietPhieuNhapKhoDAL
    {
        private string connectionString;
        public ChiTietPhieuNhapKhoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

    }
}
