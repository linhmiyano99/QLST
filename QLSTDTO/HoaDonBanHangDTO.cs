using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class HoaDonBanHangDTO
    {
        private string strSoHoaDon;
        private int iTongSo;
        private double dTongCong;
        private double dTienKhachTra;
        private string strMaNV;
        private int iDiemMuaHang;
        private string strMaKH;
        private int iDiemSauMuaHang;
        private string strNgayGio;

        public string StrSoHoaDon { get => strSoHoaDon; set => strSoHoaDon = value; }
        public int ITongSo { get => iTongSo; set => iTongSo = value; }
        public double DTongCong { get => dTongCong; set => dTongCong = value; }
        public double DTienKhachTra { get => dTienKhachTra; set => dTienKhachTra = value; }
        public string StrMaNV { get => strMaNV; set => strMaNV = value; }
        public int IDiemMuaHang { get => iDiemMuaHang; set => iDiemMuaHang = value; }
        public string StrMaKH { get => strMaKH; set => strMaKH = value; }
        public int IDiemSauMuaHang { get => iDiemSauMuaHang; set => iDiemSauMuaHang = value; }
        public string StrNgayGio { get => strNgayGio; set => strNgayGio = value; }
    }
}
