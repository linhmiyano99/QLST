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
    public class HangBUS
    {
        private HangDAL hangDAL;
        public HangBUS()
        {
            this.hangDAL = new HangDAL();
        }

        public bool suaThamSo(ThamSoDTO ts)
        {
         //   bool re = this.hangDAL.suaThamSo(ts);
            return true;
        }

        public List<ThamSoDTO> selectListTS()
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
