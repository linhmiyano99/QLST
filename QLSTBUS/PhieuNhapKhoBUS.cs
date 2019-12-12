using QLSTDAL;
using QLSTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLSTBUS
{
    public class PhieuNhapKhoBUS
    {
        private PhieuNhapKhoDAL phieuNhapKhoDAL;
        public PhieuNhapKhoBUS()
        {
            this.phieuNhapKhoDAL = new PhieuNhapKhoDAL();
        }

        public bool suaPhieuNhap(PhieuNhapKhoDTO phieuNhapKhoDTO)
        {
            bool re = this.phieuNhapKhoDAL.suaPhieuNhap(phieuNhapKhoDTO);
            return re;
        }

        public bool themPhieuNhap(PhieuNhapKhoDTO phieuNhapKhoDTO)
        {
            bool re = this.phieuNhapKhoDAL.themPhieuNhap(phieuNhapKhoDTO);
            return re;
        }

        public bool xoaPhieuNhap(PhieuNhapKhoDTO phieuNhapKhoDTO)
        {
            bool re = this.phieuNhapKhoDAL.xoaPhieuNhap(phieuNhapKhoDTO);
            return re;

        }

        public DataTable GetDataPhieuNhap()
        {
            return phieuNhapKhoDAL.GetDataDanhSachPhieuNhap();
        }

        public DataTable GetDataPhieuNhapByKey(string sKey)
        {
            return phieuNhapKhoDAL.GetDataDanhSachPhieuNhapByKey(sKey);
        }

        public List<string> GetListMaPhieuNhap()
        {
            return phieuNhapKhoDAL.GetListMaPhieuNhap();
        }

    }
}
