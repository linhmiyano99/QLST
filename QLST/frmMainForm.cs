using BUS;
using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
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
    public partial class frmMainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        
        frmKhachHang frmKhachHang = new frmKhachHang();
        frmNhanVien frmNhanVien = new frmNhanVien();
        frmQuanLyHang frmQuanLyHang = new frmQuanLyHang();
        frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
        frmThayDoiQuyDinh frmThayDoiQuyDinh = new frmThayDoiQuyDinh();
        frmChucVu frmChucVu = new frmChucVu();
        frmNhapKho frmNhapKho;
        frmHoaDonBanHang frmHoaDonBanHang;
        NhanVienDTO nhanVienDTO = new NhanVienDTO();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        List<string> ListAccountInfo = new List<string>();
        int MaChucVu = 0;
        int MaNV = 0;

        public frmMainForm()
        {
            InitializeComponent();
            EnableAcrylicAccent = true;

        }

        public frmMainForm(int MaChucVu, int MaNV)
        {
            InitializeComponent();
            EnableAcrylicAccent = true;

            try
            {
                this.MaChucVu = MaChucVu;
                this.MaNV = MaNV;

                LoadNhanVienInfo();
                frmNhapKho = new frmNhapKho(nhanVienDTO);
                frmHoaDonBanHang = new frmHoaDonBanHang(nhanVienDTO);
            }

            catch (Exception)
            {

            }
        }


        private void frmMainForm_Load(object sender, EventArgs e)
        {
            SetDefaultControlAtStartup();
            PhanQuyenTruyCap();

        }

        public void LoadNhanVienInfo()
        {
            List<string> HotenNV = new List<string>();
            HotenNV = nhanVienBUS.GetNhanVienInfoByMaNV(MaNV.ToString());
            nhanVienDTO.StrHoTen = HotenNV[0].ToString();
            nhanVienDTO.StrMaNhanVien = MaNV.ToString();
        }

        private void PhanQuyenTruyCap()
        {
            switch (MaChucVu)
            {
                case 1:
                    {
                        break; 
                    }
                case 2:
                    {
                        CtrlEl_BaoCaoDS.Dispose();
                        ctrlKhoHang.Dispose();
                        ctrlEl_QuyDinh.Dispose();
                        ctrlNhaCungCap.Dispose();
                        ctrlNhanVien.Dispose();
                        break;
                    }
                case 3:
                    {
                        ctrlKhachHang.Dispose();
                        ctrlNhanVien.Dispose();
                        ctrlEl_QuyDinh.Dispose();
                        CtrlEl_BaoCaoDS.Dispose();
                        break;
                    }
            }

        }
        private void SetDefaultControlAtStartup()
        {
            if(MaChucVu == 1 || MaChucVu == 2)
            {
                frmHoaDonBanHang = new frmHoaDonBanHang(nhanVienDTO);
                frmHoaDonBanHang.TopLevel = false;
                frmMainContainer.Controls.Add(frmHoaDonBanHang);
                frmHoaDonBanHang.Dock = DockStyle.Fill;
                frmHoaDonBanHang.Show();
                frmHoaDonBanHang.BringToFront();
               
            }
            if(MaChucVu == 3)
            {
               
            }
           
        }

        private void ctrlEl_ThongTinKhachHang_Click(object sender, EventArgs e)
        {

            frmKhachHang.TopLevel = false;
            if (!frmMainContainer.Contains(frmKhachHang))
            {
                frmMainContainer.Controls.Add(frmKhachHang);
                frmKhachHang.Dock = DockStyle.Fill;
                frmKhachHang.Show();
                frmKhachHang.BringToFront();
                frmKhachHang.Focus();
            }
            else
            {
                frmKhachHang.Show();
                frmKhachHang.BringToFront();
                frmKhachHang.Focus();
            }

        }

        private void ctrlBanHang_Click(object sender, EventArgs e)
        {

            frmHoaDonBanHang.TopLevel = false;
            if (!frmMainContainer.Contains(frmHoaDonBanHang))
            {
                frmMainContainer.Controls.Add(frmHoaDonBanHang);
                frmHoaDonBanHang.Dock = DockStyle.Fill;
                frmHoaDonBanHang.Show();
                frmHoaDonBanHang.BringToFront();
                frmHoaDonBanHang.Focus();
            }
            else
            {
                frmHoaDonBanHang.Show();
                frmHoaDonBanHang.BringToFront();
                frmHoaDonBanHang.Focus();
            }
        }

        private void ctrlEl_HangKH_Click(object sender, EventArgs e)
        {
            frmQuanLyHang.TopLevel = false;
            if (!frmMainContainer.Contains(frmQuanLyHang))
            {
                frmMainContainer.Controls.Add(frmQuanLyHang);
                frmQuanLyHang.Dock = DockStyle.Fill;
                frmQuanLyHang.Show();
                frmQuanLyHang.BringToFront();
                frmQuanLyHang.Focus();
            }
            else
            {
                frmQuanLyHang.Show();
                frmQuanLyHang.BringToFront();
                frmQuanLyHang.Focus();
            }
        }

        private void ctrlEl_MatHang_Click(object sender, EventArgs e)
        {

        }

        private void ctrlEl_NhapHang_Click(object sender, EventArgs e)
        {
            frmNhapKho frmNhapKho = new frmNhapKho(nhanVienDTO);
            frmNhapKho.TopLevel = false;
            if (!frmMainContainer.Contains(frmNhapKho))
            {
                frmMainContainer.Controls.Add(frmNhapKho);
                frmNhapKho.Dock = DockStyle.Fill;
                frmNhapKho.Show();
                frmNhapKho.BringToFront();
                frmNhapKho.Focus();
            }
            else
            {
                frmNhapKho.Show();
                frmNhapKho.BringToFront();
                frmNhapKho.Focus();
            }
        }

        private void ctrlEl_ThongTinNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien.TopLevel = false;
            if (!frmMainContainer.Contains(frmNhanVien))
            {
                frmMainContainer.Controls.Add(frmNhanVien);
                frmNhanVien.Dock = DockStyle.Fill;
                frmNhanVien.Show();
                frmNhanVien.BringToFront();
                frmNhanVien.Focus();
            }
            else
            {
                frmNhanVien.Show();
                frmNhanVien.BringToFront();
                frmNhanVien.Focus();
            }
        }

        private void ctrlEl_ChucVuNhanVien_Click(object sender, EventArgs e)
        {
            frmChucVu.TopLevel = false;
            if (!frmMainContainer.Contains(frmChucVu))
            {
                frmMainContainer.Controls.Add(frmChucVu);
                frmChucVu.Dock = DockStyle.Fill;
                frmChucVu.Show();
                frmChucVu.BringToFront();
                frmNhanVien.Focus();
            }
            else
            {
                frmChucVu.Show();
                frmChucVu.BringToFront();
                frmChucVu.Focus();
            }
        }

        private void ctrlNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap.TopLevel = false;
            if (!frmMainContainer.Contains(frmNhaCungCap))
            {
                frmMainContainer.Controls.Add(frmNhaCungCap);
                frmNhaCungCap.Dock = DockStyle.Fill;
                frmNhaCungCap.Show();
                frmNhaCungCap.BringToFront();
                frmNhaCungCap.Focus();
            }
            else
            {
                frmNhaCungCap.Show();
                frmNhaCungCap.BringToFront();
                frmNhaCungCap.Focus();
            }
        }

        private void ctrlEl_QuyDinh_Click(object sender, EventArgs e)
        {
            frmThayDoiQuyDinh.TopLevel = false;
            if (!frmMainContainer.Contains(frmThayDoiQuyDinh))
            {
                frmMainContainer.Controls.Add(frmNhaCungCap);
                frmThayDoiQuyDinh.Dock = DockStyle.Fill;
                frmThayDoiQuyDinh.Show();
                frmThayDoiQuyDinh.BringToFront();
                frmThayDoiQuyDinh.Focus();
            }
            else
            {
                frmThayDoiQuyDinh.Show();
                frmThayDoiQuyDinh.BringToFront();
                frmThayDoiQuyDinh.Focus();
            }
        }
    }
}
