using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class KhachHangDTO
    {
        private string strMaKH;
        private string strHoTen;
        private double dDiem;
        private string strMaHang;

        public string StrHoTen { get => strHoTen; set => strHoTen = value; }
        public double DDiem { get => dDiem; set => dDiem = value; }
        public string StrMaHang { get => strMaHang; set => strMaHang = value; }
        public string StrMaKH { get => strMaKH; set => strMaKH = value; }

        public KhachHangDTO()
        {

        }
    }
}
