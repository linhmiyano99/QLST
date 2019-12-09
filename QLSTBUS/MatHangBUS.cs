using QLSTDAL;
using QLSTDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTBUS
{
    public class MatHangBUS
    {
        private MatHangDAL MatHangDAL;
        public MatHangBUS()
        {
            this.MatHangDAL = new MatHangDAL();
        }

        public bool sua(MatHangDTO ts)
        {
            bool re = this.MatHangDAL.sua(ts);
            return re;
        }

        public bool them(MatHangDTO ts)
        {
            bool re = this.MatHangDAL.them(ts);
            return re;
        }

        public bool xoa(MatHangDTO ts)
        {
            bool re = this.MatHangDAL.xoa(ts);
            return re;

        }

        public DataTable GetDataTableMatHang()
        {
            return MatHangDAL.getDanhSachMatHang();
        }

        public DataTable GetMatHangByMaMH(string sKey)
        {
            return MatHangDAL.GetMatHangByKey(sKey);
        }

    }
}
