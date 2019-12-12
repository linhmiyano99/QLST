using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class ChiTietPhieuNhapKhoDTO
    {
        private string strMaSoPhieu;
        private string strMaMH;
        private int iSoLuongTheoChungTu;
        private int iSoLuongThucNhap;
        private double dDonGia;
        private double dThanhTien;

        public string StrMaSoPhieu { get => strMaSoPhieu; set => strMaSoPhieu = value; }
        public string StrMaMH { get => strMaMH; set => strMaMH = value; }
        public int ISoLuongTheoChungTu { get => iSoLuongTheoChungTu; set => iSoLuongTheoChungTu = value; }
        public int ISoLuongThucNhap { get => iSoLuongThucNhap; set => iSoLuongThucNhap = value; }
        public double DDonGia { get => dDonGia; set => dDonGia = value; }
        public double DThanhTien { get => dThanhTien; set => dThanhTien = value; }
    }
}
