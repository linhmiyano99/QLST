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
    public class KhachHangBUS
    {
        private KhachHangDAL khDAL;
        public KhachHangBUS()
        {
            this.khDAL = new KhachHangDAL();
        }

        public bool suaThamSo(KhachHangDAL ts)
        {
            //   bool re = this.hangDAL.suaThamSo(ts);
            return true;
        }

        public List<KhachHangDTO> selectListTS()
        {
            return null;
        }

        public DataTable getThamSo()
        {
            // return tsDAL.getThamSo();
            return null;
        }
    }
}
