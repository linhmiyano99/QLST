using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class BaoCaoDoanhSoDTO
    {
        private string strMaBaoCaoDoanhSo;
        private int iThang;
        private int iNam;
        private double dTongDoanhThu;

        public string StrMaBaoCaoDoanhSo { get => strMaBaoCaoDoanhSo; set => strMaBaoCaoDoanhSo = value; }
        public int IThang { get => iThang; set => iThang = value; }
        public int INam { get => iNam; set => iNam = value; }
        public double DTongDoanhThu { get => dTongDoanhThu; set => dTongDoanhThu = value; }
    }
}
