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
    public class ChiTietPhieuNhapHangBUS
    {
        public ChiTietPhieuNhapKhoDAL DAL = new ChiTietPhieuNhapKhoDAL();
        private ChiTietPhieuNhapKhoDTO DTO = new ChiTietPhieuNhapKhoDTO();
        public ChiTietPhieuNhapHangBUS()
        {
        }

        public bool sua(ChiTietPhieuNhapKhoDTO DTO)
        {
            bool re = this.DAL.sua(DTO);
            return re;
        }
        public bool them(ChiTietPhieuNhapKhoDTO DTO)
        {
            bool re = this.DAL.them(DTO  );
            return re;
        }
        public bool xoa(ChiTietPhieuNhapKhoDTO DTO)
        {
            bool re = this.DAL.xoa( DTO);
            return re;
        }


    }
}
