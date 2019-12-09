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
    public class BaoCaoDoanhSoBUS
    {
        private BaoCaoDoanhSoDAL baoCaoDoanhSoDAL;
        public BaoCaoDoanhSoBUS()
        {
            this.baoCaoDoanhSoDAL = new BaoCaoDoanhSoDAL();
        }

        public DataTable GetDataTableBaoCaoDoanhSo()
        {
            return baoCaoDoanhSoDAL.getDanhSachChiTietByKey();
        }
        public DataTable GetTongDoanhSo(int iThang, int iNam)
        {
            return baoCaoDoanhSoDAL.GetTongDoanhSo(iThang, iNam);
        }
    }
}
