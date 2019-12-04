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
    public class ChiTietHoaDonBanHangBUS
    {
        private ChiTietHoaDonBanHangDAL ctDAL;
        public ChiTietHoaDonBanHangBUS()
        {
            this.ctDAL = new ChiTietHoaDonBanHangDAL();
        }

        public bool suaChiTietHoaDonBanHang(ChiTietHoaDonBanHangDTO ChiTietHoaDonBanHangDto)
        {
            bool re = this.ctDAL.sua(ChiTietHoaDonBanHangDto);
            return re;
        }
        public bool themChiTietHoaDonBanHang(ChiTietHoaDonBanHangDTO ChiTietHoaDonBanHangDto)
        {
            bool re = this.ctDAL.them(ChiTietHoaDonBanHangDto);
            return re;
        }
        public bool xoaChiTietHoaDonBanHang(ChiTietHoaDonBanHangDTO ChiTietHoaDonBanHangDto)
        {
            bool re = this.ctDAL.xoa(ChiTietHoaDonBanHangDto);
            return re;
        }

    }
}
