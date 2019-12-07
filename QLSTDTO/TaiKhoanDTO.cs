using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class TaiKhoanDTO
    {
        private int intMaTk;
        private string strTenTk;
        private string strMatKhau;
        private int intMaNV;
        private int intMaChucVu;

        public int IntMaTk { get => intMaTk; set => intMaTk = value; }
        public string StrTenTk { get => strTenTk; set => strTenTk = value; }
        public string StrMatKhau { get => strMatKhau; set => strMatKhau = value; }
        public int IntMaNV { get => intMaNV; set => intMaNV = value; }
        public int IntMaChucVu { get => intMaChucVu; set => intMaChucVu = value; }
    }
}
