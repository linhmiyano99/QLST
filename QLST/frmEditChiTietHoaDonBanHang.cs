using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLSTBUS;
using QLSTDTO;
using DevExpress.XtraEditors;
using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraEditors.UI;
using System.IO;

namespace QLST
{
    public partial class frmEditChiTietHoaDonBanHang : DevExpress.XtraEditors.XtraForm
    {
        public frmEditChiTietHoaDonBanHang()
        {
            InitializeComponent();
        } 
        public frmEditChiTietHoaDonBanHang(ChiTietHoaDonBanHangDTO chitietDTO)
        {
            InitializeComponent();
            setTextToControls(chitietDTO);

        }
        private void setTextToControls(ChiTietHoaDonBanHangDTO chitietDTO)
        {
            try
            {
                txtSoHoaDon.Text = chitietDTO.StrSoHoaDon;
                txtSoLuong.Text = chitietDTO.ISoLuong.ToString();
                txtDonGia.Text = chitietDTO.DDonGia.ToString();
                txtThanhTien.Text = chitietDTO.DThanhTien.ToString();
                txtMaMH.Text = chitietDTO.StrMaMH;
            }

            catch (Exception)
            {
                XtraMessageBox.Show("KHÔNG THỂ LOAD ĐƯỢC DỮ LIỆU", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
