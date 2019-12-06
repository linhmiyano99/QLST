using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class ChucVuDTO
    {
        private string strMaCV;
        private string strTenCV;
        private float fLuongCa;

        public string StrMaCV { get => strMaCV; set => strMaCV = value; }
        public string StrTenCV { get => strTenCV; set => strTenCV = value; }
        public float FLuongCa { get => fLuongCa; set => fLuongCa = value; }

        public ChucVuDTO()
        {

        }

    }
}
