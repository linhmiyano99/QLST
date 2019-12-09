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
    public partial class frmBaoCaoDoanhSo : Form
    {
        private DataTable baoCaoDataTable = new DataTable();
        private BaoCaoDoanhSoBUS baoCaoBUS = new BaoCaoDoanhSoBUS();
        public frmBaoCaoDoanhSo()
        {
            InitializeComponent();
            loadDanhSachKhachHang();
        }
        public void loadDanhSachKhachHang()
        {
            //List<KhachHangDTO> listKhachHang = khachHangBUS.getListDanhSachKhachHang();
            baoCaoDataTable = baoCaoBUS.GetDataTableBaoCaoDoanhSo();


            if (baoCaoDataTable == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dataGridViewBaoCaoDoanhSo.Columns.Clear();
            dataGridViewBaoCaoDoanhSo.DataSource = null;

            dataGridViewBaoCaoDoanhSo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBaoCaoDoanhSo.AutoGenerateColumns = false;
            //dataGridViewBaoCaoDoanhSo.AllowUserToAddRows = false;


            dataGridViewBaoCaoDoanhSo.DataSource = baoCaoDataTable;
            CreateDataGridViewBaoCao();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewBaoCaoDoanhSo.DataSource];
            myCurrencyManager.Refresh();

        }
        private void CreateDataGridViewBaoCao()
        {

            DataGridViewTextBoxColumn SoHoaDon = new DataGridViewTextBoxColumn();
            SoHoaDon.Name = "SoHoaDon";
            SoHoaDon.HeaderText = "Số hóa đơn";
            SoHoaDon.DataPropertyName = "MaKH";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewBaoCaoDoanhSo.Columns.Add(SoHoaDon);


            DataGridViewTextBoxColumn TongCong = new DataGridViewTextBoxColumn();
            TongCong.Name = "TongCong";
            TongCong.HeaderText = "Tổng cộng";
            TongCong.DataPropertyName = "TongCong";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewBaoCaoDoanhSo.Columns.Add(TongCong);

            DataGridViewTextBoxColumn MaKH = new DataGridViewTextBoxColumn();
            MaKH.Name = "MaKH";
            MaKH.HeaderText = "Mã khách hàng";
            MaKH.DataPropertyName = "MaKH";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewBaoCaoDoanhSo.Columns.Add(MaKH);

           


        }
    }
}
