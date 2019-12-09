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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace QLST
{
    public partial class frmHoaDonBanHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MatHangBUS matHangBUS = new MatHangBUS();
        DataGridViewRow selectedRows = new DataGridViewRow();
        List<string> ListSoHD = new List<string>();
        private HoaDonBanHangBUS hoaDonBanHangBUS = new HoaDonBanHangBUS();
        private HoaDonBanHangDTO hoaDonBanHangDTO = new HoaDonBanHangDTO();
        AutoCompleteStringCollection ListMaMatHang = new AutoCompleteStringCollection();
        private int SoHDNextID;
        private ChiTietHoaDonBanHangBUS chiTietHDBUS = new ChiTietHoaDonBanHangBUS();
        private ChiTietHoaDonBanHangDTO chiTietHDDTO = new ChiTietHoaDonBanHangDTO();
        DataTable dataChiTietHoaDon = new DataTable();
        DataTable dataHoaDonBanHang = new DataTable();
        private int TongSo = new int();
        private float tongTien = 0;
        private float tienTraLai = 0;
        NhanVienDTO nhanVienHoaDon = new NhanVienDTO();

        private string PathForInvoicePrinting = string.Empty;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public frmHoaDonBanHang()
        {
            InitializeComponent();
            GetListSoHoaDon();
            txtSoHoaDon.Text = SoHDNextID.ToString();
            txtMaKH.Text = "8";

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cmbCamera.Items.Add(Device.Name);
            cmbCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        public frmHoaDonBanHang(NhanVienDTO nhanVienDTO)
        {
            InitializeComponent();
            GetNhanVienInfo(nhanVienDTO);
            txtSoHoaDon.Text = SoHDNextID.ToString();
            txtMaKH.Text = "8";

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cmbCamera.Items.Add(Device.Name);
            cmbCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }


        private void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            ReadPathAddress();
            setDefaultValueToControls();
            LoadMaMH();
            CreateDataGridViewBanHang();
            nhanVienHoaDon.StrMaNhanVien = "4";
        }



        #region DATA BINDING
        void GetNhanVienInfo(NhanVienDTO nhanVienDTO)
        {
            nhanVienHoaDon.StrMaNhanVien = nhanVienDTO.StrMaNhanVien.ToString();
            nhanVienHoaDon.StrHoTen = nhanVienDTO.StrHoTen.ToString();
            nhanVienHoaDon.StrMaChucVu = nhanVienDTO.StrMaChucVu.ToString();
            nhanVienHoaDon.StrDiaChi = nhanVienDTO.StrDiaChi.ToString();
            nhanVienHoaDon.StrDiaChi = nhanVienDTO.StrDiaChi.ToString();

        }
        void setDefaultValueToControls()
        {
            DateTime localDate = DateTime.Now;
            string timeNow = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            txtGio.Text = timeNow;

            DateTime today = DateTime.Today;
            txtNgay.Text = today.ToLongDateString();

        }


        private DataTable InitMatHangDataTable(string dataTableName)
        {
            DataTable dataTable = new DataTable(dataTableName);
            dataTable.Columns.Add("MaMH");
            dataTable.Columns.Add("TenMH");
            dataTable.Columns.Add("GiaBan");
            dataTable.Columns.Add("SoLuong");
            dataTable.Columns.Add("ThanhTien");

            return dataTable;
        }


        private void GetListSoHoaDon()
        {
            ListSoHD = hoaDonBanHangBUS.GetHoaDonID();
            if (ListSoHD == null)
                SoHDNextID = 1;
            else
            {
                try
                {
                    int temp = Int32.Parse(ListSoHD[ListSoHD.Count - 1].ToString());
                    SoHDNextID = temp + 1;
                }
                catch (Exception)
                {

                }
            }

        }

        private void LoadMaMH()
        {

            DataTable dtMaMH = new DataTable();
            dtMaMH = matHangBUS.GetDataTableMatHang();

            foreach (DataRow row in dtMaMH.Rows)
            {
                string ID = (row[0].ToString());
                ListMaMatHang.Add(ID);
                ListMaMatHang.Add(ID);

            }


            cmbMaMH.AutoCompleteCustomSource = ListMaMatHang;
            cmbMaMH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMaMH.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        #endregion

       
        #region UI CREATE

        /* 
         * CREATE UI FOR frmNHANVIEN
         * 
         */

        private void CreateDataGridViewBanHang()
        {
            DataGridViewTextBoxColumn MaMH = new DataGridViewTextBoxColumn();
            MaMH.Name = "MaMH";
            MaMH.HeaderText = "Mã Mặt Hàng";
            MaMH.DataPropertyName = "MaMH";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewChiTietHoaDon.Columns.Add(MaMH);


            DataGridViewTextBoxColumn TenMH = new DataGridViewTextBoxColumn();
            TenMH.Name = "TenMH";
            TenMH.HeaderText = "Tên Mặt Hàng";
            TenMH.DataPropertyName = "TenMH";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewChiTietHoaDon.Columns.Add(TenMH);

            DataGridViewTextBoxColumn GiaBan = new DataGridViewTextBoxColumn();
            GiaBan.Name = "GiaBan";
            GiaBan.HeaderText = "Đơn Giá";
            GiaBan.DataPropertyName = "GiaBan";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewChiTietHoaDon.Columns.Add(GiaBan);

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



            // 
            // colButtonEdit
            // 
            DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colButtonEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();

            colButtonEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            colButtonEdit.DataPropertyName = "ButtonEdit";
            colButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            colButtonEdit.HeaderText = "Button Edit";
            colButtonEdit.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;

            colButtonEdit.Image = ((System.Drawing.Image)(Properties.Resources.edit_16x16));

            colButtonEdit.ImageTextSpacing = 5;
            colButtonEdit.Name = "colButtonEdit";
            colButtonEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            colButtonEdit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            colButtonEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;

            colButtonEdit.SubItemsExpandWidth = 20;
            colButtonEdit.Text = "Sửa";
            colButtonEdit.ToolTipText = "Cập Nhật Thông Tin";
            //colButtonEdit.Click += buttonEditClick;
            dataGridViewChiTietHoaDon.Columns.Add(colButtonEdit);

            DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colButtonDelete = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();

            colButtonDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            colButtonDelete.DataPropertyName = "ButtonEdit";
            colButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            colButtonDelete.HeaderText = "Button Xóa";
            colButtonDelete.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            colButtonDelete.Image = Properties.Resources.delete_16x16;
            colButtonDelete.ImageTextSpacing = 5;
            colButtonDelete.Name = "colButtonDelete";
            colButtonEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            colButtonDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            colButtonDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;

            colButtonDelete.SubItemsExpandWidth = 20;
            colButtonDelete.Text = "Xóa";
            colButtonDelete.ToolTipText = "Xóa Thông Tin";
            colButtonDelete.Click += btnDeleteClick;

            dataGridViewChiTietHoaDon.Columns.Add(colButtonDelete);
            dataGridViewChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void SetTextEmpty()
        {
            txtBarcode.Text = string.Empty;
            txtMaKH.Text = string.Empty;
            cmbMaMH.Text = string.Empty;
           
            txtTienTongCong.Text = string.Empty;
            txtTienTraLai.Text = string.Empty;
            txtTienKhachDua.Text = string.Empty;
           
        }
        #endregion


        #region EVENT PROCESS
        private void btnDeleteClick(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridViewChiTietHoaDon.SelectedRows)
            {
                dataGridViewChiTietHoaDon.Rows.Remove(row);
            }
            dataGridViewChiTietHoaDon.Refresh();
            TinhTongTien();
            TinhTienTraLai();
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool re = LuuHoaDon();
            bool res = LuuChiTietHoaDon();

            frmPrintInvoice frm = new frmPrintInvoice(dataGridViewChiTietHoaDon, nhanVienHoaDon, tongTien.ToString(),
              txtTienKhachDua.Text.ToString(), tienTraLai.ToString(), TongSo.ToString(), PathForInvoicePrinting.ToString(), txtSoHoaDon.Text.ToString());
            frm.ShowDialog();

            if(re && res)
            {
                XtraMessageBox.Show("HÓA ĐƠN ĐÃ ĐƯỢC LẬP!", "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void dataGridViewChiTietHoaDon_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int soLuong = int.Parse(dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString());
                float dongia = float.Parse(dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells[4].Value.ToString());
                float temp = soLuong * dongia;
                dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells[6].Value = temp;

                TinhTongTien();
                TinhTienTraLai();
            }
            catch (Exception)
            {
                Console.WriteLine("error from editting number");
            }

        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewChiTietHoaDon.SelectedRows)
            {
                dataGridViewChiTietHoaDon.Rows.Remove(row);
            }
            dataGridViewChiTietHoaDon.Refresh();
            TinhTongTien();
            TinhTienTraLai();

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetTextEmpty();
            dataGridViewChiTietHoaDon.DataSource = null;
            dataGridViewChiTietHoaDon.Columns.Clear();
            CreateDataGridViewBanHang();
            GetListSoHoaDon();
            txtSoHoaDon.Text = SoHDNextID.ToString();
            setDefaultValueToControls();


        }

        
        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMaMH();
        }

        private void cmbMaMH_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            DataTable dtMatHang = InitMatHangDataTable("dtMatHang");
            dtMatHang = matHangBUS.GetMatHangByMaMH(cmbMaMH.SelectedText.ToString());
            dtMatHang.Columns.Add("SoLuong");
            dtMatHang.Columns.Add("ThanhTien");

            foreach (DataRow dr in dtMatHang.Rows)
            {
                dr["ThanhTien"] = dr["GiaBan"];
                dr["SoLuong"] = 1;
            }

            if (dataGridViewChiTietHoaDon.DataSource == null)
            {
                dataGridViewChiTietHoaDon.DataSource = dtMatHang;

            }
            else
            {
                AddRowFromDataTable(dtMatHang);

            }

            cmbMaMH.SelectedItem = null;
            cmbMaMH.SelectedText = string.Empty;
            TinhTongTien();

        }


        #endregion
        #region MAP BUSS
        private bool LuuHoaDon()
        {
            try
            {
                hoaDonBanHangDTO.ITongSo = TongSo;
                hoaDonBanHangDTO.StrSoHoaDon = SoHDNextID.ToString();
                hoaDonBanHangDTO.StrMaKH = txtMaKH.Text.ToString();
                hoaDonBanHangDTO.StrMaNV = nhanVienHoaDon.StrMaNhanVien;
                hoaDonBanHangDTO.DTienKhachTra = double.Parse(txtTienKhachDua.Text.ToString());
                hoaDonBanHangDTO.StrNgayGio = DateTime.Now.ToString();
                hoaDonBanHangDTO.DTongCong = double.Parse(tongTien.ToString());
                hoaDonBanHangDTO.IDiemMuaHang = 0;
                hoaDonBanHangDTO.IDiemSauMuaHang = 1000;


            }
            catch (Exception)
            {

            }

            bool re = hoaDonBanHangBUS.themHoaDonBanHang(hoaDonBanHangDTO);
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

            return GetDataForChiTietHD();

        }

        private bool GetDataForChiTietHD()
        {
            DataTable dt = (DataTable)(dataGridViewChiTietHoaDon.DataSource);
            if (dt == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI XUẤT CHI TIẾT HÓA ĐƠN, VUI LÒNG KIỂM TRA LẠI!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    chiTietHDDTO = new ChiTietHoaDonBanHangDTO();
                    chiTietHDDTO.StrMaMH = row["MaMH"].ToString();
                    chiTietHDDTO.StrSoHoaDon = SoHDNextID.ToString();
                    chiTietHDDTO.ISoLuong = int.Parse(row["SoLuong"].ToString());
                    chiTietHDDTO.DDonGia = double.Parse(row["GiaBan"].ToString());
                    chiTietHDDTO.DThanhTien = double.Parse(row["ThanhTien"].ToString());

                    bool re = chiTietHDBUS.themChiTietHoaDonBanHang(chiTietHDDTO);
                    if (!re)
                    {
                        XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI XUẤT CHI TIẾT HÓA ĐƠN, VUI LÒNG KIỂM TRA LẠI!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            return true;

        }

        private void AddRowFromDataTable(DataTable dataTable)
        {
            DataTable dtOld = (DataTable)dataGridViewChiTietHoaDon.DataSource;
            foreach (DataRow newRow in dataTable.Rows)
            {
                dtOld.ImportRow(newRow);
            }
            dataGridViewChiTietHoaDon.DataSource = dtOld;
        }


        private void TinhTongTien()
        {
            TongSo = 0;
            tongTien = 0;
            foreach (DataGridViewRow row in dataGridViewChiTietHoaDon.Rows)
            {
                tongTien += float.Parse(row.Cells[6].Value.ToString());
                TongSo += int.Parse(row.Cells[5].Value.ToString());
            }

            txtTienTongCong.Text = tongTien.ToString();
        }

        private void TinhTienTraLai()
        {
            if(!string.IsNullOrEmpty(txtTienKhachDua.Text.ToString()))
            {
                if (float.Parse(txtTienKhachDua.Text.ToString()) > float.Parse(txtTienTongCong.Text.ToString()))
                {
                    tienTraLai = float.Parse(txtTienKhachDua.Text.ToString()) - float.Parse(txtTienTongCong.Text.ToString());
                    txtTienTraLai.Text = tienTraLai.ToString();
                }
                else
                {
                    txtTienKhachDua.ForeColor = Color.Red;
                }
            }
            
        }
        #endregion

        private void txtTienKhachDua_Validated(object sender, EventArgs e)
        {

            TinhTienTraLai();
        }

        private void btnXuatHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool re = LuuHoaDon();
            bool res = LuuChiTietHoaDon();

            frmPrintInvoice frm = new frmPrintInvoice(dataGridViewChiTietHoaDon, nhanVienHoaDon, tongTien.ToString(),
              txtTienKhachDua.Text.ToString(), tienTraLai.ToString(), TongSo.ToString(), PathForInvoicePrinting.ToString(), txtSoHoaDon.Text.ToString());
            frm.ShowDialog();

            if (re && res)
            {
                XtraMessageBox.Show("HÓA ĐƠN ĐÃ ĐƯỢC LẬP!", "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            
            string fullpath =  System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            PathForInvoicePrinting = System.IO.File.ReadAllText(fullpath+"\\printPath.txt");

        }

        private void WritePathToFile(string content)
        {
            string fullpath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(fullpath, "printPath.txt")))
            {
                 outputFile.WriteAsync(content);
            }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception) {
                timer1.Stop();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                try
                {
                    BarcodeReader Reader = new BarcodeReader();
                    Result result = Reader.Decode((Bitmap)pictureBox.Image);
                    if (result != null)
                    {
                        cmbMaMH.Text = result.ToString();
                        timer1.Stop();
                        if (videoCaptureDevice.IsRunning)
                        {
                            videoCaptureDevice.Stop();
                        }
                    }
                }
                catch(Exception)
                { }
            }
        }
        private void btnDecode_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void Form24_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }
    }

}