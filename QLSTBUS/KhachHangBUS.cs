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
    public class KhachHangBUS
    {
        private KhachHangDAL khDAL;
        private KhachHangDAL KhachHangDAL;
        public KhachHangBUS()
        {
            this.KhachHangDAL = new KhachHangDAL();
        }

        public bool suaPhieu(KhachHangDTO ts)
        {
            bool re = this.KhachHangDAL.sua(ts);
            return re;
        }

        public bool themPhieu(KhachHangDTO ts)
        {
            bool re = this.KhachHangDAL.them(ts);
            return re;
        }

        public bool xoaPhieu(KhachHangDTO ts)
        {
            bool re = this.KhachHangDAL.xoa(ts);
            return re;
        }

    }
}
