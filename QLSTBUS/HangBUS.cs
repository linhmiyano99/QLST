using QLSTDAL;
using QLSTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLSTBUS
{
    public class HangBUS
    {
        private HangDAL HangDAL;
        public HangBUS()
        {
            this.HangDAL = new HangDAL();
        }

        public bool sua(HangDTO ts)
        {
            bool re = this.HangDAL.sua(ts);
            return re;
        }

        public bool them(HangDTO ts)
        {
            bool re = this.HangDAL.them(ts);
            return re;
        }

        public bool xoa(HangDTO ts)
        {
            bool re = this.HangDAL.xoa(ts);
            return re;
        
        }

        public List<HangDTO> GetDanhSach()
        {
            return HangDAL.Select();
        }

        public DataTable GetDataTableHang()
        {
            return HangDAL.getDanhSachHang();
        }

        public DataTable GetDataTableHangByKey(string sKey)
        {
            return HangDAL.getDanhSachHangByKey(sKey);
        }
    }
}
