
﻿using QLSTDAL;
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
        public DataTable GetDataTableBaoCaoDoanhSo(DateTime dt1, DateTime dt2)
        {
            return baoCaoDoanhSoDAL.getDanhSachChiTietByKey(dt1, dt2);
        }

        public DataTable GetTongDoanhSo(DateTime dt1, DateTime dt2)
        {
            return baoCaoDoanhSoDAL.GetTongDoanhSo(dt1, dt2);
        }
    }
}