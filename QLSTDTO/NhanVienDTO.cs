using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTDTO
{
    public class NhanVienDTO
    {
        private string strMaNhanVien;
        private string strHoTen;
        private string strMaChucVu;
        private string strDiaChi;
        private string strSoDT;
        private double flLuong;
        private int intTongCaLam;

        public string StrMaNhanVien { get => strMaNhanVien; set => strMaNhanVien = value; }
        public string StrHoTen { get => strHoTen; set => strHoTen = value; }
        public string StrMaChucVu { get => strMaChucVu; set => strMaChucVu = value; }
        public string StrDiaChi { get => strDiaChi; set => strDiaChi = value; }
        public string StrSoDT { get => strSoDT; set => strSoDT = value; }
        public double FlLuong { get => flLuong; set => flLuong = value; }
        public int IntTongCaLam { get => intTongCaLam; set => intTongCaLam = value; }
    }
}
