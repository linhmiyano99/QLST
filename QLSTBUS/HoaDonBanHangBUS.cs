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
    public class HoaDonBanHangBUS
    {
        private HoaDonBanHangDAL hdDAL;
        public HoaDonBanHangBUS()
        {
            this.hdDAL = new HoaDonBanHangDAL();
        }

        public bool suaHoaDonBanHang(HoaDonBanHangDTO hoaDonBanHangDto)
        {
            bool re = this.hdDAL.sua(hoaDonBanHangDto);
            return re;
        }
        public bool themHoaDonBanHang(HoaDonBanHangDTO hoaDonBanHangDto)
        {
            bool re = this.hdDAL.them(hoaDonBanHangDto);
            return re;
        }
        public bool xoaHoaDonBanHang(HoaDonBanHangDTO hoaDonBanHangDto)
        {
            bool re = this.hdDAL.xoa(hoaDonBanHangDto);
            return re;
        }

    }
}
