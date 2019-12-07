using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class MatHangDTO
    {
        private string strMaMH;
        private string strBarcode;
        private string strTenMatHang;
        private double dGiaNhap;
        private double dGiaBan;
        private int iTonToiDa;
        private int iTonToiThieu;

        public string StrMaMH { get => strMaMH; set => strMaMH = value; }
        public string StrBarcode { get => strBarcode; set => strBarcode = value; }
        public string StrTenMatHang { get => strTenMatHang; set => strTenMatHang = value; }
        public double DGiaNhap { get => dGiaNhap; set => dGiaNhap = value; }
        public double DGiaBan { get => dGiaBan; set => dGiaBan = value; }
        public int ITonToiDa { get => iTonToiDa; set => iTonToiDa = value; }
        public int ITonToiThieu { get => iTonToiThieu; set => iTonToiThieu = value; }
    }
}
