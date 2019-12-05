using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLSTDTO;
using QLSTBUS;

namespace QLST
{
    
    public partial class frmEditKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang frmKH;
        KhachHangDTO khachHang = new KhachHangDTO();
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        HangDTO hangDTO = new HangDTO();
        HangBUS hangBUS = new HangBUS();

        public frmEditKhachHang()
        {
            InitializeComponent();
            LoadHangCMB();
        }

        public frmEditKhachHang(KhachHangDTO khachHang)
        {
            InitializeComponent();
            LoadHangCMB();
            setTextToControls(khachHang);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getKhachHangEditInfo()
        {
            khachHang.StrMaKH = txtMaKH.Text.ToString();
            khachHang.StrHoTen = txtHoTen.Text.ToString();
            khachHang.StrMaHang = cmbTenHang.SelectedValue.ToString();
            khachHang.DDiem = float.Parse (txtDiem.Text.ToString());

        }

        private void setTextToControls(KhachHangDTO khachHang)
        {
            try
            {
                txtMaKH.Text = khachHang.StrMaKH;
                txtHoTen.Text = khachHang.StrHoTen;
                cmbTenHang.SelectedValue = khachHang.StrMaHang;
                txtDiem.Text = khachHang.DDiem.ToString();
            }

            catch (Exception)
            {
                XtraMessageBox.Show("KHÔNG THỂ LOAD ĐƯỢC DỮ LIỆU", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadHangCMB()
        {
            List<HangDTO> listhang = hangBUS.GetDanhSach();

            if (listhang == null)
            {
                XtraMessageBox.Show("KHÔNG THỂ LOAD ĐƯỢC DỮ LIỆU", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbTenHang.DataSource = new BindingSource(listhang, string.Empty);
            cmbTenHang.DisplayMember = "StrTenHang";
            cmbTenHang.ValueMember = "StrMaHang";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cmbTenHang.DataSource];
            myCurrencyManager.Refresh();

            if (cmbTenHang.Items.Count > 0)
            {
                cmbTenHang.SelectedIndex = 0;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getKhachHangEditInfo();
            bool re = khachHangBUS.suaKhachHang(khachHang);
            if (re)
            {
                XtraMessageBox.Show("THÔNG TIN ĐÃ ĐƯỢC CẬP NHẬT", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmKH.loadDanhSachKhachHang();
                frmKH.dataGridViewKhachHang.Refresh();
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("CÓ LỖI XẢY RA, VUI LÒNG THỬ LẠI SAU", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}