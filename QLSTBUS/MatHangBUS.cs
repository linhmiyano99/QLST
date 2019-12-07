using QLSTDAL;
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
