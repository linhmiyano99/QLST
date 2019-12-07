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
        private MatHangDAL matHangDAL;
        public MatHangBUS()
        {
            this.matHangDAL = new MatHangDAL();
        }

        public bool sua(MatHangDTO ts)
        {
            bool re = this.matHangDAL.sua(ts);
            return re;
        }

        public bool them(MatHangDTO ts)
        {
            bool re = this.matHangDAL.them(ts);
            return re;
        }

        public bool xoa(MatHangDTO ts)
        {
            bool re = this.matHangDAL.xoa(ts);
            return re;

        }

        public DataTable GetDataTableHang()
        {
            return matHangDAL.getDanhSachMatHang();
        }

    }
}
