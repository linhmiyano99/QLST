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
    public partial class frmBaoCaoDoanhSo : DevExpress.XtraEditors.XtraForm
    {
        private DataTable baoCaoDataTable = new DataTable();
        private BaoCaoDoanhSoBUS baoCaoBUS = new BaoCaoDoanhSoBUS();
        private ChiTietHoaDonBanHangDTO hoadon_CellClickDTO = new ChiTietHoaDonBanHangDTO();

        public frmBaoCaoDoanhSo()
        {
            InitializeComponent();
            loadDanhSachKhachHang();
            dtiTuNgay.Value = DateTime.Now;
            dtiDenNgay.Value = DateTime.Now;
            loadDanhSachKhachHang();
        }
        public void loadDanhSachKhachHang()
        {
            //List<KhachHangDTO> listKhachHang = khachHangBUS.getListDanhSachKhachHang();
            baoCaoDataTable = baoCaoBUS.GetDataTableBaoCaoDoanhSo();
            DateTime dt1 = dtiTuNgay.Value;
            DateTime dt2 = dtiDenNgay.Value;

            if (baoCaoDataTable == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            txtTienTongCong.Text = baoCaoBUS.GetTongDoanhSo(dt1, dt2).Rows[0][0].ToString();

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

        private void dtiTuNgay_Click(object sender, EventArgs e)
        {
            LoadByKey();
        }
        private void dtiDenNgay_Click(object sender, EventArgs e)
        {
            LoadByKey();
        }
        private void LoadByKey()
        {
            //List<KhachHangDTO> listKhachHang = khachHangBUS.getListDanhSachKhachHang();
            DateTime dt1 = dtiTuNgay.Value;
            DateTime dt2 = dtiDenNgay.Value;
            baoCaoDataTable = baoCaoBUS.GetDataTableBaoCaoDoanhSo(dt1, dt2);


            if (baoCaoDataTable == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            txtTienTongCong.Text = baoCaoBUS.GetTongDoanhSo(dt1, dt2).Rows[0][0].ToString();

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
        private void dataGridViewBaoCaoDoanhSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            try
            {
                DataGridViewRow selectedRows = dataGridViewBaoCaoDoanhSo.Rows[ind];

                //Get data into cellclick dto

                hoadon_CellClickDTO.StrSoHoaDon = selectedRows.Cells[0].Value.ToString();
                if (hoadon_CellClickDTO.StrSoHoaDon == "")
                    return;
                frmChiTietHoaDonBanHang frmEdit = new frmChiTietHoaDonBanHang(hoadon_CellClickDTO.StrSoHoaDon);
                try
                {
                    //frmEditKhachHang frmEdit = new frmEditKhachHang(khachHang_CellClickDTO);
                    frmEdit.StartPosition = FormStartPosition.CenterParent;
                    frmEdit.ShowDialog();
                }
                catch (Exception)
                {
                    frmEdit.Close();
                }
                dataGridViewBaoCaoDoanhSo.Refresh();
                dataGridViewBaoCaoDoanhSo.Update();
            }
            catch
            {

            }
        }

    }
}
