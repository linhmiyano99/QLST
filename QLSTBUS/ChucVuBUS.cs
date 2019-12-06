using QLSTDAL;
using QLSTDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTBUS
{
    public class ChucVuBUS
    {
        private ChucVuDAL ChucVuDAL;
        public ChucVuBUS()
        {
            this.ChucVuDAL = new ChucVuDAL();
        }

        public bool sua(ChucVuDTO ts)
        {
            bool re = this.ChucVuDAL.sua(ts);
            return re;
        }

        public bool them(ChucVuDTO ts)
        {
            bool re = this.ChucVuDAL.them(ts);
            return re;
        }

        public bool xoa(ChucVuDTO ts)
        {
            bool re = this.ChucVuDAL.xoa(ts);
            return re;

        }

        public List<ChucVuDTO> GetDanhSach()
        {
            return ChucVuDAL.Select();
        }

        public DataTable GetDataTableCV()
        {
            return ChucVuDAL.getDanhSachCV();
        }

        public DataTable GetDataTableCV_ByKey(string sKey)
        {
            return ChucVuDAL.getDanhSachChucVuByKey(sKey);
        }
    }
}
