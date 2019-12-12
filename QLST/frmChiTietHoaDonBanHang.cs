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
    public partial class frmChiTietHoaDonBanHang : DevExpress.XtraEditors.XtraForm
    {
        DataGridViewRow selectedRows = new DataGridViewRow();
        private ChiTietHoaDonBanHangBUS khachHangBUS = new ChiTietHoaDonBanHangBUS();
        private DataTable chitietDataTable = new DataTable();
        private ChiTietHoaDonBanHangDTO hoadon_CellClickDTO = new ChiTietHoaDonBanHangDTO();
        public frmChiTietHoaDonBanHang()
        {
            InitializeComponent();
        }

        public frmChiTietHoaDonBanHang(string ma)
        {
            InitializeComponent();
            CreateDataGridViewBanHang();
            loadDanhSachChiTiet(ma);

        }
        public void loadDanhSachChiTiet(string ma)
        {
            //List<KhachHangDTO> listKhachHang = khachHangBUS.getListDanhSachKhachHang();
            chitietDataTable = khachHangBUS.getChiTiet(ma);


            if (chitietDataTable == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dataGridViewChiTietHoaDon.Columns.Clear();
            dataGridViewChiTietHoaDon.DataSource = null;

            dataGridViewChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewChiTietHoaDon.AutoGenerateColumns = false;
            //dataGridViewKhachHang.AllowUserToAddRows = false;


            dataGridViewChiTietHoaDon.DataSource = chitietDataTable;
            CreateDataGridViewBanHang();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewChiTietHoaDon.DataSource];
            myCurrencyManager.Refresh();

        }
        private void CreateDataGridViewBanHang()
        {


            DataGridViewTextBoxColumn SoHoaDon = new DataGridViewTextBoxColumn();
            SoHoaDon.Name = "SoHoaDon";
            SoHoaDon.HeaderText = "Số hóa đơn";
            SoHoaDon.DataPropertyName = "SoHoaDon";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewChiTietHoaDon.Columns.Add(SoHoaDon);


            DataGridViewTextBoxColumn MaMH = new DataGridViewTextBoxColumn();
            MaMH.Name = "MaMH";
            MaMH.HeaderText = "Mã Mặt Hàng";
            MaMH.DataPropertyName = "MaMH";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewChiTietHoaDon.Columns.Add(MaMH);


            DataGridViewTextBoxColumn DonGia = new DataGridViewTextBoxColumn();
            DonGia.Name = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.DataPropertyName = "DonGia";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewChiTietHoaDon.Columns.Add(DonGia);

            DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn SoLuong = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            SoLuong.Name = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.DataPropertyName = "SoLuong";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            SoLuong.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            SoLuong.ShowUpDown = true;
            SoLuong.MinValue = 1;
            dataGridViewChiTietHoaDon.Columns.Add(SoLuong);

            DataGridViewTextBoxColumn ThanhTien = new DataGridViewTextBoxColumn();
            ThanhTien.Name = "ThanhTien";
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.DataPropertyName = "ThanhTien";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewChiTietHoaDon.Columns.Add(ThanhTien);

        }
        private void dataGridViewChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            try
            {
                DataGridViewRow selectedRows = dataGridViewChiTietHoaDon.Rows[ind];

                //Get data into cellclick dto

                hoadon_CellClickDTO.StrSoHoaDon = selectedRows.Cells[0].Value.ToString();
                hoadon_CellClickDTO.StrMaMH = selectedRows.Cells[1].Value.ToString();
                hoadon_CellClickDTO.DDonGia = double.Parse(selectedRows.Cells[2].Value.ToString());
                hoadon_CellClickDTO.ISoLuong = int.Parse(selectedRows.Cells[3].Value.ToString());
                hoadon_CellClickDTO.DThanhTien = double.Parse(selectedRows.Cells[4].Value.ToString());

                frmEditChiTietHoaDonBanHang frmEdit = new frmEditChiTietHoaDonBanHang(hoadon_CellClickDTO);
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
                dataGridViewChiTietHoaDon.Refresh();
                dataGridViewChiTietHoaDon.Update();
            }
            catch
            {

            }
        }

    }
}
