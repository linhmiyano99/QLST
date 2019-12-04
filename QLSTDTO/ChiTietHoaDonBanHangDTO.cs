using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class ChiTietHoaDonBanHangDTO
    {
        private string strSoHoaDon;
        private string strMaMH;
        private int iSoLuong;
        private double dDonGia;
        private double dThanhTien;

        public string StrSoHoaDon { get => strSoHoaDon; set => strSoHoaDon = value; }
        public string StrMaMH { get => strMaMH; set => strMaMH = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public double DDonGia { get => dDonGia; set => dDonGia = value; }
        public double DThanhTien { get => dThanhTien; set => dThanhTien = value; }
    }
}
