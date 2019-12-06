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
using BUS;
using QLSTBUS;

namespace QLST
{
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien frmNV;
        private int NhanVienNextID;

        NhanVienDTO newNhanVienDTO = new NhanVienDTO();
        NhanVienBUS newNhanVienBUS = new NhanVienBUS();

        ChucVuDTO chucVuDTO = new ChucVuDTO();
        ChucVuBUS chucVuBUS = new ChucVuBUS();

        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        public frmThemNhanVien(int NhanVienNextID_)
        {
            InitializeComponent();
            NhanVienNextID = NhanVienNextID_;
            LoadChucVuCMB();
            setTextToControls();
        }

        private void LoadChucVuCMB()
        {
            List<ChucVuDTO> listCV = chucVuBUS.GetDanhSach();

            if (listCV == null)
            {
                XtraMessageBox.Show("KHÔNG THỂ LOAD ĐƯỢC DỮ LIỆU", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            comboBoxCV.DataSource = new BindingSource(listCV, string.Empty);
            comboBoxCV.DisplayMember = "StrTenCV";
            comboBoxCV.ValueMember = "StrMaCV";
            // cmbTenChucVu.SelectedItem = "StrTenChucVu";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboBoxCV.DataSource];
            myCurrencyManager.Refresh();

            if (comboBoxCV.Items.Count > 0)
            {
                comboBoxCV.SelectedIndex = 0;
            }
        }
        private void getNewNhanVienInfo()
        {
            newNhanVienDTO.StrMaNhanVien = txtMaNV.Text.ToString();
            newNhanVienDTO.StrHoTen = txtHoTen.Text.ToString();
            newNhanVienDTO.StrMaChucVu = comboBoxCV.SelectedValue.ToString();
            newNhanVienDTO.StrDiaChi = (txtDiaChi.Text.ToString());
            newNhanVienDTO.StrSoDT = (txtSDT.Text.ToString());
            newNhanVienDTO.FlLuong = float.Parse(txtLuong.Text.ToString());
            newNhanVienDTO.IntTongCaLam = Int32.Parse(txtTongCaLam.Text.ToString());

        }

        private void setTextToControls()
        {
            try
            {
                txtMaNV.Text = NhanVienNextID.ToString();
              
            }

            catch (Exception)
            {
                XtraMessageBox.Show("KHÔNG THỂ LOAD ĐƯỢC DỮ LIỆU", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getNewNhanVienInfo();
            bool re = newNhanVienBUS.ThemNV(newNhanVienDTO);
            if (re)
            {

                XtraMessageBox.Show("THÔNG TIN ĐÃ ĐƯỢC CẬP NHẬT", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    frmNV.LoadDanhSachNhanVien();
                    frmNV.dataGridViewNhanVien.Refresh();
                }
                catch (Exception)
                {
                    this.Close();
                }
                

                this.Close();
            }
            else
            {
                XtraMessageBox.Show("CÓ LỖI XẢY RA, VUI LÒNG THỬ LẠI SAU", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}