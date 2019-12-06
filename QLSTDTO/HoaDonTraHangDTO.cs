using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class HoaDonTraHangDTO
    {
        private string strSoHoaDon;
        private string strMaNV;
        private string strNgayGio;

        public string StrSoHoaDon { get => strSoHoaDon; set => strSoHoaDon = value; }
        public string StrMaNV { get => strMaNV; set => strMaNV = value; }
        public string StrNgayGio { get => strNgayGio; set => strNgayGio = value; }
    }
}
