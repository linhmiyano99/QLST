using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class ThamSoDTO
    {
        private string strMaTS;
        private double dLuongCa;
        private float fChietKhauVang;
        private float fChietKhauBac;
        private float fChietKhauBachKim;

        public global::System.Double DLuongCa { get => dLuongCa; set => dLuongCa = value; }
        public global::System.Single FChietKhauVang { get => fChietKhauVang; set => fChietKhauVang = value; }
        public global::System.Single FChietKhauBac { get => fChietKhauBac; set => fChietKhauBac = value; }
        public global::System.Single FChietKhauBachKim { get => fChietKhauBachKim; set => fChietKhauBachKim = value; }

        public ThamSoDTO()
        {
            strMaTS = "1";
            fChietKhauVang = 0.2f;
            fChietKhauBac = 0.1f;
            fChietKhauBachKim = 0.3f;
            dLuongCa = 100000;
        }
    }
}
