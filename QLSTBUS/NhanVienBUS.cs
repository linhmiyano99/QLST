using QLSTDAL;
using QLSTDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL NhanVienDAL;

        public NhanVienBUS()
        {
            NhanVienDAL = new NhanVienDAL();
        }


        public bool ThemNV(NhanVienDTO NhanVienDTO)
        {
            bool result = NhanVienDAL.ThemNV(NhanVienDTO);
            return result;
        }

        public bool XoaNV(NhanVienDTO NhanVienDTO)
        {
            bool result = NhanVienDAL.XoaNV(NhanVienDTO);
            return result;
        }

        public bool SuaNV(NhanVienDTO NhanVienDTO)
        {
            bool result = NhanVienDAL.SuaNV(NhanVienDTO);
            return result;
        }

        public int Select_IDENT_CURRENT(int IdentCurrent)
        {
            return NhanVienDAL.Select_IDENT_CURRENT(IdentCurrent);
        }

        public DataTable GetDanhSachNV()
        {
            return NhanVienDAL.GetDanhSachNhanVien();
        }

        public DataTable GetDanhSachNVByKey(string sKey)
        {
            return NhanVienDAL.GetDanhSachNhanVienByKey(sKey);
        }

        public List<string> GetNhanVienID()
        {
            return NhanVienDAL.GetTblNhanVienID();
        }
    }

}

