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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using QLST.Properties;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevComponents.DotNetBar;
using System.Resources;

namespace QLST
{
    public partial class frmBaoCaoTon : DevExpress.XtraEditors.XtraForm
    {
        private DataTable tonDataTable = new DataTable();
        private BaoCaoTonBUS baoCaoTonBUS = new BaoCaoTonBUS();
        private string sKeyword = string.Empty;

        public frmBaoCaoTon()
        {
            InitializeComponent();
            loadDanhSachMatHang();
        }
        public void loadDanhSachMatHang()
        {
            //List<KhachHangDTO> listKhachHang = khachHangBUS.getListDanhSachKhachHang();
            tonDataTable = baoCaoTonBUS.GetDataTableBaoCaoTon();


            if (tonDataTable == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dataGridViewMatHang.Columns.Clear();
            dataGridViewMatHang.DataSource = null;

            dataGridViewMatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatHang.AutoGenerateColumns = false;
            //dataGridViewMatHang.AllowUserToAddRows = false;


            dataGridViewMatHang.DataSource = tonDataTable;
            CreateDataGridViewMatHang();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewMatHang.DataSource];
            myCurrencyManager.Refresh();

        }
        private void CreateDataGridViewMatHang()
        {

            DataGridViewTextBoxColumn MaMH = new DataGridViewTextBoxColumn();
            MaMH.Name = "MaMH";
            MaMH.HeaderText = "Mã Mặt Hàng";
            MaMH.DataPropertyName = "MaMH";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewMatHang.Columns.Add(MaMH);


            DataGridViewTextBoxColumn TenMH = new DataGridViewTextBoxColumn();
            TenMH.Name = "TenMH";
            TenMH.HeaderText = "Tên Mặt Hàng";
            TenMH.DataPropertyName = "TenMH";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewMatHang.Columns.Add(TenMH);

            DataGridViewTextBoxColumn GiaNhap = new DataGridViewTextBoxColumn();
            GiaNhap.Name = "GiaNhap";
            GiaNhap.HeaderText = "Giá Nhập";
            GiaNhap.DataPropertyName = "GiaNhap";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewMatHang.Columns.Add(GiaNhap);

            DataGridViewTextBoxColumn GiaBan = new DataGridViewTextBoxColumn();
            GiaBan.Name = "GiaBan";
            GiaBan.HeaderText = "Giá Bán";
            GiaBan.DataPropertyName = "GiaBan";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewMatHang.Columns.Add(GiaBan);

            DataGridViewTextBoxColumn TonToiThieu = new DataGridViewTextBoxColumn();
            TonToiThieu.Name = "TonToiThieu";
            TonToiThieu.HeaderText = "Tồn Tối Thiểu";
            TonToiThieu.DataPropertyName = "TonToiThieu";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewMatHang.Columns.Add(TonToiThieu);

            DataGridViewTextBoxColumn TonToiDa = new DataGridViewTextBoxColumn();
            TonToiDa.Name = "TonToiDa";
            TonToiDa.HeaderText = "Tồn Tối Đa";
            TonToiDa.DataPropertyName = "TonToiDa";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewMatHang.Columns.Add(TonToiDa);

            
            
            

        }

        private void txtSoHoaDon_EditValueChanged(object sender, EventArgs e)
        {
              timKiemMatHang();
        }
        private void timKiemMatHang()
        {
            sKeyword = txtMaMH.Text.Trim();
            // List<KhachHangDTO> ListKhachHang = khachHangBUS.getListKhachHangByKey(sKeyword);

            if (sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0)
            {
                this.loadDanhSachMatHang();

            }
            else
            {
                DataTable dataMatHang = baoCaoTonBUS.GetDataTableBaoCaoTon(sKeyword);
                dataGridViewMatHang.DataSource = dataMatHang;
                dataGridViewMatHang.Refresh();
                dataGridViewMatHang.Update();

            }
        }
    }
}
