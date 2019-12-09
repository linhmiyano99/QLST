using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class BaoCaoTonDTO
    {
        private string strMaBaoCaoTon;
        private string strMaMH;
        private int iTon;
        private double dGiaVon;
        private double dGiaBan;

        public string StrMaBaoCaoTon { get => strMaBaoCaoTon; set => strMaBaoCaoTon = value; }
        public string StrMaMH { get => strMaMH; set => strMaMH = value; }
        public int ITon { get => iTon; set => iTon = value; }
        public double DGiaVon { get => dGiaVon; set => dGiaVon = value; }
        public double DGiaBan { get => dGiaBan; set => dGiaBan = value; }
    }
}
