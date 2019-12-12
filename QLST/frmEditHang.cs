using DevExpress.XtraEditors;
using QLST;
using QLSTBUS;
using QLSTDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLST
{
    public partial class frmEditHang : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLyHang frmQLHang;

        private HangDTO hangDTO = new HangDTO();
        private HangDTO hang_CellClickDTO = new HangDTO();
        private HangBUS hangBUS = new HangBUS();
        private DataTable hangDataTable = new DataTable();
        private List<string> listMaHang = new List<string>();
     
        private string sKeyword = string.Empty;

        public frmEditHang()
        {
            InitializeComponent();
            LoadHangCMB();
        }

        public frmEditHang(HangDTO hang)
        {
            InitializeComponent();
            LoadHangCMB();
            setTextToControls(hang);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getHangEditInfo()
        {
            hangDTO.StrMaHang = txtMaHang.Text.ToString();
            hangDTO.StrTenHang = cmbTenHang.Text.ToString();
            hangDTO.FChietKhau = float.Parse(txtChietKhau.Text.ToString());
            hangDTO.DDiem = double.Parse(txtDiem.Text.ToString());

        }

        private void setTextToControls(HangDTO HangDTO)
        {
            try
            {
                txtMaHang.Text = HangDTO.StrMaHang;
                cmbTenHang.Text = HangDTO.StrTenHang;
                txtChietKhau.Text = HangDTO.FChietKhau.ToString();
                txtDiem.Text = HangDTO.DDiem.ToString();
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
            getHangEditInfo();
            bool re = hangBUS.sua(hangDTO);
            if (re)
            {

                XtraMessageBox.Show("THÔNG TIN ĐÃ ĐƯỢC CẬP NHẬT", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQLHang.loadDanhSachHang();
                frmQLHang.dataGridViewHang.Refresh();

                this.Close();
            }
            else
            {
                XtraMessageBox.Show("CÓ LỖI XẢY RA, VUI LÒNG THỬ LẠI SAU", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
