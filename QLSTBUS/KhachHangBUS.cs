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

        private KhachHangDAL KhachHangDAL;
        public KhachHangBUS()
        {
            this.KhachHangDAL = new KhachHangDAL();
        }

        public bool suaKhachHang(KhachHangDTO ts)
        {
            bool re = this.KhachHangDAL.sua(ts);
            return re;
        }

        public bool themKhachHang(KhachHangDTO ts)
        {
            bool re = this.KhachHangDAL.them(ts);
            return re;
        }

        public bool xoaKhachHang(KhachHangDTO ts)
        {
            bool re = this.KhachHangDAL.xoa(ts);
            return re;
        }

        public DataTable getDanhSachKhachHang()
        {
            return KhachHangDAL.getDanhSachKhachHang();
        }

        public List<KhachHangDTO> getListDanhSachKhachHang()
        {
            return KhachHangDAL.getListDanhSachKhachHang();
        }

        public List<KhachHangDTO> getListKhachHangByKey(string sKey)
        {
            return KhachHangDAL.getListKhachHangByKey(sKey);
        }
       

    }
}
