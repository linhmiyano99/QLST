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
    public class BaoCaoTonBUS
    {
        private BaoCaoTonDAL baoCaoTonDAL;
        public BaoCaoTonBUS()
        {
            this.baoCaoTonDAL = new BaoCaoTonDAL();
        }

        public DataTable GetDataTableBaoCaoTon(int iThang, int iNam)
        {
            return baoCaoTonDAL.getDanhSachChiTietByKey(iThang, iNam);
        }
    }
}