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
    class HoaDonTraHangBUS
    {
        private HoaDonTraHangDAL hdDAL;
        public HoaDonTraHangBUS()
        {
            this.hdDAL = new HoaDonTraHangDAL();
        }

        public bool suaHoaDonTraHang(HoaDonTraHangDTO hoaDonTraHangDto)
        {
            bool re = this.hdDAL.sua(hoaDonTraHangDto);
            return true;
        }
        public bool themHoaDonTraHang(HoaDonTraHangDTO hoaDonTraHangDto)
        {
            bool re = this.hdDAL.them(hoaDonTraHangDto);
            return true;
        }
        public bool xoaHoaDonTraHang(HoaDonTraHangDTO hoaDonTraHangDto)
        {
            bool re = this.hdDAL.xoa(hoaDonTraHangDto);
            return true;
        }
    }
}
