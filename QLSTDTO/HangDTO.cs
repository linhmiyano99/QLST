using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class HangDTO
    {
        private string strMaHang;
        private string strTenHang;
        private float fChietKhau;
        private double dDiem;

        public string StrTenHang { get => strTenHang; set => strTenHang = value; }
        public float FChietKhau { get => fChietKhau; set => fChietKhau = value; }
        public double DDiem { get => dDiem; set => dDiem = value; }
        public string StrMaHang { get => strMaHang; set => strMaHang = value; }

        public HangDTO()
        {

        }
    }
}
