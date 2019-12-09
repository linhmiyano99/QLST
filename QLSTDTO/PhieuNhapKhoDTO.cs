using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class PhieuNhapKhoDTO
    {
        private string strMaSoPhieu;
        private string strNgay;
        private string strMaNCC;
        private string strMaNV;

        public string StrMaSoPhieu { get => strMaSoPhieu; set => strMaSoPhieu = value; }
        public string StrNgay { get => strNgay; set => strNgay = value; }
        public string StrMaNCC { get => strMaNCC; set => strMaNCC = value; }
        public string StrMaNV { get => strMaNV; set => strMaNV = value; }
    }
}
