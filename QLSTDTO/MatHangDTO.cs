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
        private string strTenMH;
        private double dGiaNhap;
        private string strDonGia;
        private int iTonToiDa;
        private int iTonToiThieu;

        public string StrMaMH { get => strMaMH; set => strMaMH = value; }
        public string StrBarcode { get => strBarcode; set => strBarcode = value; }
        public string StrTenMH { get => strTenMH; set => strTenMH = value; }
        public double DGiaNhap { get => dGiaNhap; set => dGiaNhap = value; }
        public string StrDonGia { get => strDonGia; set => strDonGia = value; }
        public int ITonToiDa { get => iTonToiDa; set => iTonToiDa = value; }
        public int ITonToiThieu { get => iTonToiThieu; set => iTonToiThieu = value; }
    }
}
