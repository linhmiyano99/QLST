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
using QLSTDTO;
using BUS;
using QLSTBUS;
using DevExpress.XtraEditors;
using DevExpress.Utils.CommonDialogs;
using System.IO;

namespace QLST
{
    public partial class frmNhapKho : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private NhanVienDTO nhanVienNhapKho = new NhanVienDTO();
        private NhanVienDTO nhanVienDTO = new NhanVienDTO();
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();

        private NhaCungCapDTO nhaCungCapDTO = new NhaCungCapDTO();
        private NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();

        private MatHangBUS matHangBUS = new MatHangBUS();
        private MatHangDTO matHangDTO = new MatHangDTO();
        private MatHangBUS matHangCapNhatBUS = new MatHangBUS();

        private HoaDonBanHangBUS hoaDonBanHangBUS = new HoaDonBanHangBUS();
        private HoaDonBanHangDTO hoaDonBanHangDTO = new HoaDonBanHangDTO();

        private ChiTietPhieuNhapHangBUS chiTietPhieuNhapBUS = new ChiTietPhieuNhapHangBUS();
        private ChiTietPhieuNhapKhoDTO chiTietPhieuNhapDTO = new ChiTietPhieuNhapKhoDTO();

        private PhieuNhapKhoBUS phieuNhapKhoBUS = new PhieuNhapKhoBUS();
        private PhieuNhapKhoDTO phieuNhapKhoDTO = new PhieuNhapKhoDTO();

        DataTable dataChiTietHoaDon = new DataTable();
        DataTable dataHoaDonBanHang = new DataTable();

        AutoCompleteStringCollection ListMaMatHang = new AutoCompleteStringCollection();
        DataGridViewRow selectedRows = new DataGridViewRow();


        private List<MatHangDTO> ListMatHangCapNhat = new List<MatHangDTO>();
        List<string> ListMaSoPhieu = new List<string>();
        private string PathForInvoicePrinting = string.Empty;


        private int SoPhieuNextID;
        private int TongSo = new int();
        private float tongTien = 0;


        public frmNhapKho()
        {
            InitializeComponent();
            GetListSoPhieuNhap();
            txtMaPhieu.Text = SoPhieuNextID.ToString();
            LoadNhaCungCapCMB();

            nhanVienNhapKho.StrMaNhanVien = "4";

        }

        public frmNhapKho(NhanVienDTO nhanVienDTO)
        {
            InitializeComponent();
            GetNhanVienInfo(nhanVienDTO);
            txtMaPhieu.Text = SoPhieuNextID.ToString();
            LoadNhaCungCapCMB();
           
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            ReadPathAddress();
            setDefaultValueToControls();
            LoadMaMH();
            CreateDataGridViewNhapHang();
            txtNhanVien.Text = nhanVienNhapKho.StrHoTen;
        }


        #region DATA BINDING
        void GetNhanVienInfo(NhanVienDTO nhanVienDTO)
        {
            try
            {
                nhanVienNhapKho.StrMaNhanVien = nhanVienDTO.StrMaNhanVien.ToString();
                nhanVienNhapKho.StrHoTen = nhanVienDTO.StrHoTen.ToString();
                nhanVienNhapKho.StrMaChucVu = nhanVienDTO.StrMaChucVu.ToString();
                nhanVienNhapKho.StrDiaChi = nhanVienDTO.StrDiaChi.ToString();
                nhanVienNhapKho.StrDiaChi = nhanVienDTO.StrDiaChi.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("LOG:: frmNhapKho :: Cannot Get NhanVien Info :: func:: GetNhanVienInfo(NhanVienDTO nhanVienDTO)");
            }


        }
        void setDefaultValueToControls()
        {
            DateTime localDate = DateTime.Now;
            string timeNow = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            DateTime today = DateTime.Today;
            txtNgay.Text = today.ToLongDateString();
            txtGio.Text = timeNow.ToString();

        }


        private void GetListSoPhieuNhap()
        {
            ListMaSoPhieu = phieuNhapKhoBUS.GetListMaPhieuNhap();
            if (ListMaSoPhieu == null || ListMaSoPhieu[ListMaSoPhieu.Count - 1] == "0")
                SoPhieuNextID = 1;
            else
            {
                try
                {
                    int temp = Int32.Parse(ListMaSoPhieu[ListMaSoPhieu.Count - 1].ToString());
                    SoPhieuNextID = temp + 1;
                }
                catch (Exception)
                {
                    Console.WriteLine("LOG:: frmNhapKho :: Cannot Get ListSoPhieuNhap :: func:: GetListSoPhieuNhap()");
                }

            }

        }

        private void LoadNhaCungCapCMB()
        {
            List<NhaCungCapDTO> ListNhaCungCap = nhaCungCapBUS.GetDanhSach();

            if (ListNhaCungCap == null)
            {
                XtraMessageBox.Show("KHÔNG THỂ LOAD ĐƯỢC DỮ LIỆU", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbNhaCungCap.DataSource = new BindingSource(ListNhaCungCap, string.Empty);
            cmbNhaCungCap.DisplayMember = "StrTenNhaCungCap";
            cmbNhaCungCap.ValueMember = "StrMaNhaCungCap";
            // cmbTenChucVu.SelectedItem = "StrTenChucVu";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cmbNhaCungCap.DataSource];
            myCurrencyManager.Refresh();

            if (cmbNhaCungCap.Items.Count > 0)
            {
                cmbNhaCungCap.SelectedIndex = 0;
            }
        }

        private void LoadMaMH()
        {
            try
            {
                DataTable dtMaMH = new DataTable();
                dtMaMH = matHangBUS.GetDataTableMatHang();

                foreach (DataRow row in dtMaMH.Rows)
                {
                    string ID = (row[0].ToString());
                    ListMaMatHang.Add(ID);

                }
            }
            catch (Exception)
            {
                Console.WriteLine("LOG:: frmNhapKho :: Cannot Load MaMatHang :: func:: LoadMaMH() ");
            }



            cmbMaMH.AutoCompleteCustomSource = ListMaMatHang;
            //var database = cmbNhaCungCap.AutoCompleteCustomSource;
            cmbMaMH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMaMH.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        #endregion


        #region UI CREATE

        /* 
         * CREATE UI FOR frmNHANVIEN
         * 
         */

        private void CreateDataGridViewNhapHang()
        {
            DataGridViewTextBoxColumn MaMH = new DataGridViewTextBoxColumn();
            MaMH.Name = "MaMH";
            MaMH.HeaderText = "Mã Mặt Hàng";
            MaMH.DataPropertyName = "MaMH";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewChiTietPhieuNhapKho.Columns.Add(MaMH);

            DataGridViewTextBoxColumn TenMH = new DataGridViewTextBoxColumn();
            TenMH.Name = "TenMH";
            TenMH.HeaderText = "Tên Mặt Hàng";
            TenMH.DataPropertyName = "TenMH";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewChiTietPhieuNhapKho.Columns.Add(TenMH);

            DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn SoLuongYeuCau = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            SoLuongYeuCau.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            SoLuongYeuCau.ShowUpDown = true;
            SoLuongYeuCau.MinValue = 1;
            SoLuongYeuCau.Name = "SoLuongYeuCau";
            SoLuongYeuCau.HeaderText = "Số Lượng Yêu Cầu";
            SoLuongYeuCau.DataPropertyName = "SoLuongYeuCau";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewChiTietPhieuNhapKho.Columns.Add(SoLuongYeuCau);

            DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn SoLuongThucNhap = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            SoLuongThucNhap.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            SoLuongThucNhap.ShowUpDown = true;
            SoLuongThucNhap.MinValue = 1;
            SoLuongThucNhap.HeaderText = "Số Lượng Thực Nhập";
            SoLuongThucNhap.DataPropertyName = "SoLuongThucNhap";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewChiTietPhieuNhapKho.Columns.Add(SoLuongThucNhap);

            DataGridViewTextBoxColumn DonGia = new DataGridViewTextBoxColumn();
            DonGia.Name = "GiaBan";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.DataPropertyName = "GiaBan";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewChiTietPhieuNhapKho.Columns.Add(DonGia);

            DataGridViewTextBoxColumn ThanhTien = new DataGridViewTextBoxColumn();
            ThanhTien.Name = "ThanhTien";
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.DataPropertyName = "ThanhTien";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewChiTietPhieuNhapKho.Columns.Add(ThanhTien);
            // 
            // colButtonEdit
            // 
            //DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colButtonEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();

            //colButtonEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            //colButtonEdit.DataPropertyName = "ButtonEdit";
            //colButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            //colButtonEdit.HeaderText = "Button Edit";
            //colButtonEdit.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;

            //colButtonEdit.Image = ((System.Drawing.Image)(Properties.Resources.edit_16x16));

            //colButtonEdit.ImageTextSpacing = 5;
            //colButtonEdit.Name = "colButtonEdit";
            //colButtonEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //colButtonEdit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            //colButtonEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;

            //colButtonEdit.SubItemsExpandWidth = 20;
            //colButtonEdit.Text = "Sửa";
            //colButtonEdit.ToolTipText = "Cập Nhật Thông Tin";
            ////colButtonEdit.Click += buttonEditClick;
            //dataGridViewChiTietPhieuNhapKho.Columns.Add(colButtonEdit);

            DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colButtonDelete = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();

            colButtonDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            colButtonDelete.DataPropertyName = "ButtonDelete";
            colButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            colButtonDelete.HeaderText = "Button Xóa";
            colButtonDelete.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            colButtonDelete.Image = Properties.Resources.delete_16x16;
            colButtonDelete.ImageTextSpacing = 5;
            colButtonDelete.Name = "colButtonDelete";
            colButtonDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            colButtonDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            colButtonDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;

            colButtonDelete.SubItemsExpandWidth = 20;
            colButtonDelete.Text = "Xóa";
            colButtonDelete.ToolTipText = "Xóa Thông Tin";
            colButtonDelete.Click += btnDeleteClick;

            dataGridViewChiTietPhieuNhapKho.Columns.Add(colButtonDelete);
            dataGridViewChiTietPhieuNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void SetTextEmpty()
        {
            setDefaultValueToControls();
            txtSearch.Text = string.Empty;
            txtGio.Text = txtNgay.Text = string.Empty;
            txtNhanVien.Text = string.Empty;
            txtMaPhieu.Text = string.Empty;
            cmbMaMH.Text = string.Empty;
            GetListSoPhieuNhap();


        }
        #endregion


        #region EVENT PROCESS
        private void btnDeleteClick(object sender, EventArgs e)
        {
            if (dataGridViewChiTietPhieuNhapKho.SelectedRows != null)
            {
                foreach (DataGridViewRow row in dataGridViewChiTietPhieuNhapKho.SelectedRows)
                {
                    dataGridViewChiTietPhieuNhapKho.Rows.Remove(row);
                }
                dataGridViewChiTietPhieuNhapKho.Refresh();
                TinhTongTien();
            }


        }


        private void dataGridViewChiTietPhieuNhapKho_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int soLuong = int.Parse(dataGridViewChiTietPhieuNhapKho.Rows[e.RowIndex].Cells[5].Value.ToString());
                float dongia = float.Parse(dataGridViewChiTietPhieuNhapKho.Rows[e.RowIndex].Cells[4].Value.ToString());
                float temp = soLuong * dongia;
                dataGridViewChiTietPhieuNhapKho.Rows[e.RowIndex].Cells[6].Value = temp;

                TinhTongTien();

            }
            catch (Exception)
            {
                Console.WriteLine("LOG:: frmNhapKho ::  :: func:: dataGridViewChiTietPhieuNhapKho_CellValidated() ");
            }

        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dataGridViewChiTietPhieuNhapKho.SelectedRows != null)
            {
                foreach (DataGridViewRow row in dataGridViewChiTietPhieuNhapKho.SelectedRows)
                {
                    dataGridViewChiTietPhieuNhapKho.Rows.Remove(row);
                }
                dataGridViewChiTietPhieuNhapKho.Refresh();
                TinhTongTien();
            }
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetTextEmpty();
            dataGridViewChiTietPhieuNhapKho.DataSource = null;
            dataGridViewChiTietPhieuNhapKho.Columns.Clear();
            CreateDataGridViewNhapHang();
            GetListSoPhieuNhap();
            txtMaPhieu.Text = SoPhieuNextID.ToString();
            txtNhanVien.Text = nhanVienDTO.StrHoTen;
            setDefaultValueToControls();
        }


        #endregion
        #region MAP BUSS
        private bool LuuPhieuNhap()
        {
            try
            {
                phieuNhapKhoDTO.StrMaSoPhieu = SoPhieuNextID.ToString();
                phieuNhapKhoDTO.StrMaNCC = cmbNhaCungCap.SelectedValue.ToString();
                phieuNhapKhoDTO.StrMaNV = nhanVienNhapKho.StrMaNhanVien;
                phieuNhapKhoDTO.StrNgay = DateTime.Now.ToString();

            }
            catch (Exception)
            {

            }

            bool re = phieuNhapKhoBUS.themPhieuNhap(phieuNhapKhoDTO);
            if (!re)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA, VUI LÒNG KIỂM TRA LẠI!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
            //KHACH HANG
        }

        private bool LuuChiTietHoaDon()
        {

            return GetDataForChiTietPhieuNhap();

        }

        private bool GetDataForChiTietPhieuNhap()
        {
            DataTable dt = (DataTable)(dataGridViewChiTietPhieuNhapKho.DataSource);
            if (dt == null)
            {

            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        chiTietPhieuNhapDTO = new ChiTietPhieuNhapKhoDTO();
                        chiTietPhieuNhapDTO.StrMaMH = row["MaMH"].ToString();
                        chiTietPhieuNhapDTO.StrMaSoPhieu = SoPhieuNextID.ToString();
                        chiTietPhieuNhapDTO.ISoLuongTheoChungTu = int.Parse(row["SoLuongYeuCau"].ToString());
                        chiTietPhieuNhapDTO.ISoLuongThucNhap = int.Parse(row["SoLuongThucNhap"].ToString());
                        chiTietPhieuNhapDTO.DDonGia = double.Parse(row["GiaBan"].ToString());
                        chiTietPhieuNhapDTO.DThanhTien = double.Parse(row["ThanhTien"].ToString());

                        bool re = chiTietPhieuNhapBUS.them(chiTietPhieuNhapDTO);
                        if (!re)
                        {
                            XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI XUẤT CHI TIẾT HÓA ĐƠN, VUI LÒNG KIỂM TRA LẠI!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }
            return true;

        }

        private void kiemTraTrungMatHang()
        {
            List<string> ListMaMH = new List<string>();
            List<int> rowIndex = new List<int>();
            List<string> soLuong = new List<string>();

            foreach (DataGridViewRow row in dataGridViewChiTietPhieuNhapKho.Rows)
            {
                rowIndex.Add(row.Index);

                if (!ListMaMH.Contains(row.Cells[2].Value.ToString()))
                {
                    ListMaMH.Add(row.Cells[2].Value.ToString());
                }
                else
                {
                    int index = row.Index;
                    string temp = row.Cells[2].Value.ToString();
                    int SL = int.Parse(row.Cells[3].Value.ToString());
                    int indexTrung = ListMaMH.IndexOf(temp);
                    int SLD = int.Parse(dataGridViewChiTietPhieuNhapKho.Rows[indexTrung].Cells[3].Value.ToString());
                    dataGridViewChiTietPhieuNhapKho.Rows[indexTrung].Cells[3].Value = SLD + SL;
                    dataGridViewChiTietPhieuNhapKho.Rows.RemoveAt(index);

                    DataTable dt = (DataTable)(dataGridViewChiTietPhieuNhapKho.DataSource);
                    dt.AcceptChanges();

                    dataGridViewChiTietPhieuNhapKho.Update();
                    dataGridViewChiTietPhieuNhapKho.Refresh();
                    dataGridViewChiTietPhieuNhapKho.DataSource = dt;
                }

            }
        }
        private void CapNhatMatHang()
        {
            DataTable dt = (DataTable)(dataGridViewChiTietPhieuNhapKho.DataSource);
            foreach (DataRow row in dt.Rows)
            {

                string MaMH = row["MaMH"].ToString();
                string soLuong = row["SoLuongThucNhap"].ToString();

                bool re = matHangCapNhatBUS.capNhatSoLuong(MaMH, soLuong);
                if (!re)
                {
                    Console.Write("Loi cap nhat mat hang");
                }
            }
        }
        private void AddRowFromDataTable(DataTable dataTable)
        {
            DataTable dtOld = (DataTable)dataGridViewChiTietPhieuNhapKho.DataSource;
            foreach (DataRow newRow in dataTable.Rows)
            {
                dtOld.ImportRow(newRow);

            }
            dataGridViewChiTietPhieuNhapKho.DataSource = dtOld;
        }

        private void TinhTongTien()
        {
            TongSo = 0;
            tongTien = 0;
            foreach (DataGridViewRow row in dataGridViewChiTietPhieuNhapKho.Rows)
            {
                try
                {
                    tongTien += float.Parse(row.Cells[5].Value.ToString());
                    TongSo += int.Parse(row.Cells[3].Value.ToString());
                }
                catch (Exception)
                {

                }
            }

            txtTienTongCong.Text = tongTien.ToString();
        }


        #endregion

        private void txtTienKhachDua_Validated(object sender, EventArgs e)
        {


        }

        private void btnXuatHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSelectPath_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFolderBrowserDialog folderBrowserDialog = new XtraFolderBrowserDialog();
            folderBrowserDialog.DialogStyle = FolderBrowserDialogStyle.Wide;


            folderBrowserDialog.SelectedPath = PathForInvoicePrinting;
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                WritePathToFile(folderBrowserDialog.SelectedPath);

        }

        private void ReadPathAddress()
        {

            string fullpath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            PathForInvoicePrinting = System.IO.File.ReadAllText(fullpath + "\\printPath_NhapKho.txt");

        }

        private void WritePathToFile(string content)
        {
            string fullpath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(fullpath, "printPath_NhapKho.txt")))
            {
                outputFile.WriteAsync(content);
            }
        }

        private void cmbMaMH_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            LoadMaMH();
        }



        private void cmbMaMH_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            dataGridViewChiTietPhieuNhapKho.AutoGenerateColumns = false;
            DataTable dtMatHang = new DataTable();
            dtMatHang = matHangBUS.GetMatHangByMaMH(cmbMaMH.SelectedText.ToString());
            {
                dtMatHang.Columns.Add("SoLuongYeuCau");
                dtMatHang.Columns.Add("SoLuongThucNhap");
                dtMatHang.Columns.Add("ThanhTien");

                foreach (DataRow dr in dtMatHang.Rows)
                {

                    dr["SoLuongYeuCau"] = 1;
                    dr["SoLuongThucNhap"] = 1;
                    dr["ThanhTien"] = dr["GiaBan"];
                }

                if (dataGridViewChiTietPhieuNhapKho.DataSource == null)
                {

                    dataGridViewChiTietPhieuNhapKho.DataSource = dtMatHang;

                }
                else
                {
                    AddRowFromDataTable(dtMatHang);

                }

                cmbMaMH.SelectedItem = null;
                cmbMaMH.SelectedText = string.Empty;
                TinhTongTien();

            }

        }



        private void cmbMaMH_Validated(object sender, EventArgs e)
        {

        }

        private void dataGridViewChiTietPhieuNhapKho_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int soLuong = int.Parse(dataGridViewChiTietPhieuNhapKho.Rows[e.RowIndex].Cells[3].Value.ToString());
                float dongia = float.Parse(dataGridViewChiTietPhieuNhapKho.Rows[e.RowIndex].Cells[4].Value.ToString());
                float temp = soLuong * dongia;
                dataGridViewChiTietPhieuNhapKho.Rows[e.RowIndex].Cells[5].Value = temp;

                TinhTongTien();

            }
            catch (Exception)
            {
                Console.WriteLine("error from editting number");
            }
        }

        private void barButtonItemXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dataGridViewChiTietPhieuNhapKho.SelectedRows != null)
            {
                foreach (DataGridViewRow row in dataGridViewChiTietPhieuNhapKho.SelectedRows)
                {
                    dataGridViewChiTietPhieuNhapKho.Rows.Remove(row);
                }
                dataGridViewChiTietPhieuNhapKho.Refresh();
                TinhTongTien();
            }
        }

        private void barButtonItemLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            kiemTraTrungMatHang();
            bool re = LuuPhieuNhap();
            bool res = LuuChiTietHoaDon();

            frmPrintInvoice frm = new frmPrintInvoice(dataGridViewChiTietPhieuNhapKho, nhanVienNhapKho, tongTien.ToString(),
              TongSo.ToString(), PathForInvoicePrinting.ToString(), txtMaPhieu.Text.ToString());
            frm.Show();
            frm.Hide();

            if (re && res)
            {
                XtraMessageBox.Show("HÓA ĐƠN ĐÃ ĐƯỢC LẬP!", "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItemThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetTextEmpty();
            dataGridViewChiTietPhieuNhapKho.DataSource = null;
            dataGridViewChiTietPhieuNhapKho.Columns.Clear();
            txtNhanVien.Text = nhanVienNhapKho.StrHoTen;
            CreateDataGridViewNhapHang();
            GetListSoPhieuNhap();
            txtMaPhieu.Text = SoPhieuNextID.ToString();
            txtNhanVien.Text = nhanVienNhapKho.StrHoTen;
            setDefaultValueToControls();
        }

        private void barButtonItemThuMuc_ItemClick(object sender, ItemClickEventArgs e)
        {

            XtraFolderBrowserDialog folderBrowserDialog = new XtraFolderBrowserDialog();
            folderBrowserDialog.DialogStyle = FolderBrowserDialogStyle.Wide;


            folderBrowserDialog.SelectedPath = PathForInvoicePrinting;
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                WritePathToFile(folderBrowserDialog.SelectedPath);
        }

        private void barButtonItemXuatPhieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            kiemTraTrungMatHang();
            bool re = LuuPhieuNhap();
            bool res = LuuChiTietHoaDon();

            frmPrintInvoice frm = new frmPrintInvoice(dataGridViewChiTietPhieuNhapKho, nhanVienNhapKho, tongTien.ToString(),
              TongSo.ToString(), PathForInvoicePrinting.ToString(), txtMaPhieu.Text.ToString());
            frm.Visible = false;
            frm.Show();

            if (re && res)
            {
                XtraMessageBox.Show("HÓA ĐƠN ĐÃ ĐƯỢC LẬP!", "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
