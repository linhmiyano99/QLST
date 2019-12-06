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
    public partial class frmEditChucVu : DevExpress.XtraEditors.XtraForm
    {

        private ChucVuDTO ChucVuDTO = new ChucVuDTO();
        private ChucVuDTO ChucVu_CellClickDTO = new ChucVuDTO();
        private ChucVuBUS ChucVuBUS = new ChucVuBUS();
        private DataTable ChucVuDataTable = new DataTable();
        private List<string> ListMaCV = new List<string>();

        private string sKeyword = string.Empty;
        public frmChucVu frmChucVu;
        public frmEditChucVu()
        {
            InitializeComponent();
        }

        public frmEditChucVu(ChucVuDTO chucVuDTO)
        {
            InitializeComponent();
            LoadChucVuCMB();
            setTextToControls(chucVuDTO);
        }


        private void getChucVuEditInfo()
        {
            ChucVuDTO.StrMaCV = txtMaCV.Text.ToString();
            ChucVuDTO.StrTenCV = cmbTenChucVu.Text.ToString();
            ChucVuDTO.FLuongCa = float.Parse(txtLuongCa.Text.ToString());
         
        }

        private void setTextToControls(ChucVuDTO chucVu)
        {
            try
            {
                txtMaCV.Text = chucVu.StrMaCV;
                cmbTenChucVu.Text = chucVu.StrTenCV;
                txtLuongCa.Text = chucVu.FLuongCa.ToString();
              
            }

            catch (Exception)
            {
                XtraMessageBox.Show("KHÔNG THỂ LOAD ĐƯỢC DỮ LIỆU", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadChucVuCMB()
        {
            List<ChucVuDTO> listCV = ChucVuBUS.GetDanhSach();

            if (listCV == null)
            {
                XtraMessageBox.Show("KHÔNG THỂ LOAD ĐƯỢC DỮ LIỆU", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbTenChucVu.DataSource = new BindingSource(listCV, string.Empty);
            cmbTenChucVu.DisplayMember = "StrTenCV";
            cmbTenChucVu.ValueMember = "StrTenCV";
           // cmbTenChucVu.SelectedItem = "StrTenChucVu";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cmbTenChucVu.DataSource];
            myCurrencyManager.Refresh();

            if (cmbTenChucVu.Items.Count > 0)
            {
                cmbTenChucVu.SelectedIndex = 0;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getChucVuEditInfo();
            bool re = ChucVuBUS.sua(ChucVuDTO);
            if (re)
            {

                XtraMessageBox.Show("THÔNG TIN ĐÃ ĐƯỢC CẬP NHẬT", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmChucVu.LoadDanhSachChucVu();
                frmChucVu.dataGridViewChucVu.Refresh();

                this.Close();
            }
            else
            {
                XtraMessageBox.Show("CÓ LỖI XẢY RA, VUI LÒNG THỬ LẠI SAU", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}