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
    public class NhaCungCapBUS
    {
        private NhaCungCapDAL NhaCungCapDAL;
        public NhaCungCapBUS()
        {
            this.NhaCungCapDAL = new NhaCungCapDAL();
        }

        public bool sua(NhaCungCapDTO nhaCungCapDTO)
        {
            bool re = this.NhaCungCapDAL.suaNhaCungCap(nhaCungCapDTO);
            return re;
        }

        public bool them(NhaCungCapDTO nhaCungCapDTO)
        {
            bool re = this.NhaCungCapDAL.themNhaCungCap(nhaCungCapDTO);
            return re;
        }

        public bool xoa(NhaCungCapDTO nhaCungCapDTO)
        {
            bool re = this.NhaCungCapDAL.xoaNhaCungCap( nhaCungCapDTO);
            return re;

        }

        public List<NhaCungCapDTO> GetDanhSach()
        {
            return NhaCungCapDAL.Select();
        }

        public DataTable GetDataTableHang()
        {
            return NhaCungCapDAL.getDanhSachHang();
        }

        public DataTable GetDataTableNhaCungCapByKey(string sKey)
        {
            return NhaCungCapDAL.getDanhSachNCCByKey(sKey);
        }
    }
}
