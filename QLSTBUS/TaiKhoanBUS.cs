using QLSTDAL;
using QLSTDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTBUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAL TaiKhoanDAL;

        public TaiKhoanBUS()
        {
            TaiKhoanDAL = new TaiKhoanDAL();
        }


        public bool ThemTK(TaiKhoanDTO TaiKhoanDTO)
        {
            bool result = TaiKhoanDAL.ThemTK(TaiKhoanDTO);
            return result;
        }

        public bool XoaTK(TaiKhoanDTO TaiKhoanDTO)
        {
            bool result = TaiKhoanDAL.XoaTK(TaiKhoanDTO);
            return result;
        }

        public List<TaiKhoanDTO> SelectByKeyWord(string sKeyword)
        {
            return TaiKhoanDAL.SelectByKeyWord(sKeyword);
        }

        public List<string> GetTaiKhoanID()
        {
            return TaiKhoanDAL.GetTaiKhoanID();
        }

    }
}
