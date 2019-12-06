using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class frmEditNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private NhanVienDTO NhanVienDTO = new NhanVienDTO();
        private NhanVienDTO NhanVien_CellClickDTO = new NhanVienDTO();
        private NhanVienBUS NhanVienBUS = new NhanVienBUS();

        private DataTable NhanVienDataTable = new DataTable();
        private List<string> ListMaNV = new List<string>();
       
        private string sKeyword = string.Empty;

        ChucVuDTO chucVuDTO = new ChucVuDTO();
        ChucVuBUS chucVuBUS = new ChucVuBUS();

        public frmNhanVien frmNV;

        public frmEditNhanVien()
        {
            InitializeComponent();
        }

        public frmEditNhanVien(NhanVienDTO nhanVienDTO)
        {
            InitializeComponent();
            LoadChucVuCMB();
            setTextToControls(nhanVienDTO);
        }


       
        private void setTextToControls(NhanVienDTO nhanVienDTO)
        {
            //get data to text
            txtMaNV.Text = nhanVienDTO.StrMaNhanVien;
            txtHoTen.Text = nhanVienDTO.StrHoTen;
            comboBoxCV.Text = nhanVienDTO.StrMaChucVu;
            txtDiaChi.Text = nhanVienDTO.StrDiaChi;
            txtSDT.Text = nhanVienDTO.StrSoDT;
            txtLuong.Text = nhanVienDTO.FlLuong.ToString();
            txtTongCaLam.Text = nhanVienDTO.IntTongCaLam.ToString();
        }

        private void getNhanVienEditedInfo()
        {
            NhanVienDTO.StrMaNhanVien = txtMaNV.Text.ToString();
            NhanVienDTO.StrHoTen = txtHoTen.Text.ToString();
            NhanVienDTO.StrMaChucVu = comboBoxCV.SelectedValue.ToString();
            NhanVienDTO.StrDiaChi = txtDiaChi.Text.ToString();
            NhanVienDTO.StrSoDT = txtSDT.Text.ToString();
            NhanVienDTO.FlLuong = float.Parse( txtLuong.Text.ToString());
            NhanVienDTO.IntTongCaLam = int.Parse(txtTongCaLam.Text.ToString());

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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getNhanVienEditedInfo();
            bool re = NhanVienBUS.SuaNV(NhanVienDTO);
            if (re)
            {

                XtraMessageBox.Show("THÔNG TIN ĐÃ ĐƯỢC CẬP NHẬT", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNV.dataGridViewNhanVien.Refresh();
                frmNV.LoadDanhSachNhanVien();
               

                this.Close();
            }
            else
            {
                XtraMessageBox.Show("CÓ LỖI XẢY RA, VUI LÒNG THỬ LẠI SAU", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
