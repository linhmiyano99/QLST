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
        private string strTenMH;
        private string strDonGia;

        public MatHangDTO(string strMaMH, string strTenMH, string strDonGia)
        {
            this.StrMaMH = strMaMH;
            this.StrTenMH = strTenMH;
            this.StrDonGia = strDonGia;
        }

        public MatHangDTO()
        {
        }

        public string StrMaMH { get => strMaMH; set => strMaMH = value; }
        public string StrTenMH { get => strTenMH; set => strTenMH = value; }
        public string StrDonGia { get => strDonGia; set => strDonGia = value; }
    }

}
