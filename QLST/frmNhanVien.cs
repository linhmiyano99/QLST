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
using DevExpress.XtraEditors;
using QLSTBUS;

namespace QLST
{
    public partial class frmNhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private NhanVienDTO NhanVienDTO = new NhanVienDTO();
        private NhanVienDTO NhanVien_CellClickDTO = new NhanVienDTO();
        private NhanVienBUS NhanVienBUS = new NhanVienBUS();
        private TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        private DataTable NhanVienDataTable = new DataTable();
        private List<string> ListMaNV = new List<string>();
        private DataTable dataTableUpdateTemp;
        private DataTable dataTableInsertTemp;
        private string sKeyword = string.Empty;
        private string strMaNV = string.Empty;
        int NhanVienNextID = int.MinValue;


        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            GetListMaNV();
            SelectedRowsDefault();

            dataGridViewNhanVien.CurrentCell = dataGridViewNhanVien.Rows[0].Cells[0];
            NhanVienDataTable = InitNhanVienDataTable("NhanVienDataTable");
            dataTableUpdateTemp = InitNhanVienDataTable("dataTableUpdateTemp");
            dataTableInsertTemp = InitNhanVienDataTable("dataTableInsertTemp");
        }

       
        #region DATA_BINDING

        /*
         * XU LI DATA
         */
        private void SelectedRowsDefault()
        {
            try
            {
                DataGridViewRow selectedRows = dataGridViewNhanVien.Rows[0];

                //Get data into cellclick dto

                NhanVien_CellClickDTO.StrMaNhanVien = selectedRows.Cells[0].Value.ToString();
                NhanVien_CellClickDTO.StrHoTen = selectedRows.Cells[1].Value.ToString();
                NhanVien_CellClickDTO.StrMaChucVu = ((selectedRows.Cells[2].Value.ToString()));
                NhanVien_CellClickDTO.StrDiaChi = ((selectedRows.Cells[3].Value.ToString()));
                NhanVien_CellClickDTO.StrSoDT = ((selectedRows.Cells[4].Value.ToString()));
                NhanVien_CellClickDTO.FlLuong = float.Parse((selectedRows.Cells[5].Value.ToString()));
                NhanVien_CellClickDTO.IntTongCaLam = int.Parse((selectedRows.Cells[6].Value.ToString()));

                //get data to text

                txtMaNV.Text = selectedRows.Cells[0].Value.ToString();
                txtHoTen.Text = selectedRows.Cells[1].Value.ToString();
                txtChucVu.Text = ((selectedRows.Cells[2].Value.ToString()));
                txtDiaChi.Text = ((selectedRows.Cells[3].Value.ToString()));
                txtSDT.Text = selectedRows.Cells[4].Value.ToString();
                txtLuong.Text = selectedRows.Cells[5].Value.ToString();
                txtTongCaLam.Text = ((selectedRows.Cells[6].Value.ToString()));
                strMaNV = selectedRows.Cells[0].Value.ToString();
                LoadTaiKhoanNV();
            }
            catch
            {
                Console.WriteLine("CellClick can not bound data!");
            }
        }


        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            try
            {
                DataGridViewRow selectedRows = dataGridViewNhanVien.Rows[ind];

                //Get data into cellclick dto
                NhanVien_CellClickDTO.StrMaNhanVien = selectedRows.Cells[0].Value.ToString();
                NhanVien_CellClickDTO.StrHoTen = selectedRows.Cells[1].Value.ToString();
                NhanVien_CellClickDTO.StrMaChucVu = ((selectedRows.Cells[2].Value.ToString()));
                NhanVien_CellClickDTO.StrDiaChi = ((selectedRows.Cells[3].Value.ToString()));
                NhanVien_CellClickDTO.StrSoDT = ((selectedRows.Cells[4].Value.ToString()));
                NhanVien_CellClickDTO.FlLuong = float.Parse((selectedRows.Cells[5].Value.ToString()));
                NhanVien_CellClickDTO.IntTongCaLam = int.Parse((selectedRows.Cells[6].Value.ToString()));

                //get data to text
                txtMaNV.Text = selectedRows.Cells[0].Value.ToString();
                txtHoTen.Text = selectedRows.Cells[1].Value.ToString();
                txtChucVu.Text = ((selectedRows.Cells[2].Value.ToString()));
                txtDiaChi.Text = ((selectedRows.Cells[3].Value.ToString()));
                txtSDT.Text = selectedRows.Cells[4].Value.ToString();
                txtLuong.Text = selectedRows.Cells[5].Value.ToString();
                txtTongCaLam.Text = ((selectedRows.Cells[6].Value.ToString()));

                strMaNV = selectedRows.Cells[0].Value.ToString();
                LoadTaiKhoanNV();
            }
            catch
            {
                Console.WriteLine("CellClick can not bound data!");
            }
        }

        private void GetListMaNV()
        {
            ListMaNV = NhanVienBUS.GetNhanVienID();
            if (ListMaNV == null)
                NhanVienNextID = 1;
            else
            {
                int temp = Int32.Parse(ListMaNV[ListMaNV.Count - 1].ToString()) ;
                NhanVienNextID = temp + 1;
            }
               
        }

        public void LoadDanhSachNhanVien()
        {
            NhanVienDataTable = NhanVienBUS.GetDanhSachNV();


            if (NhanVienDataTable == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dataGridViewNhanVien.Columns.Clear();
            dataGridViewNhanVien.DataSource = null;

            dataGridViewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNhanVien.AutoGenerateColumns = false;
            //dataGridViewHang.AllowUserToAddRows = false;
            dataGridViewNhanVien.DataSource = NhanVienDataTable;
            CreateDataGridViewNhanVien();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewNhanVien.DataSource];
            myCurrencyManager.Refresh();
        }

       

        private DataTable InitNhanVienDataTable(string dataTableName)
        {
            DataTable dataTable = new DataTable(dataTableName);
            dataTable.Columns.Add("MaNV");
            dataTable.Columns.Add("HoTen");
            dataTable.Columns.Add("TenChucVu");
            dataTable.Columns.Add("DiaChi");
            dataTable.Columns.Add("SDT");
            dataTable.Columns.Add("Luong");
            dataTable.Columns.Add("TongCaLam");

            return dataTable;
        }


        private void LoadTaiKhoanNV()
        {
            try
            {
                List<TaiKhoanDTO> ListTaiKhoan = taiKhoanBUS.SelectByKeyWord(strMaNV);
                txtTenTK.Text = ListTaiKhoan[0].StrTenTk.ToString();
                txtMatKhau.Text = ListTaiKhoan[0].StrMatKhau.ToString();
            }
            catch
            {
                Console.WriteLine("TAIKHOAN cannot be bound to list");
            }

        }


        #endregion




        #region EVENT HANDLE
        /*
         * XU LI CAC SU KIEN
         */
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetListMaNV();
            frmThemNhanVien frm = new frmThemNhanVien(NhanVienNextID);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
          

        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            deleteNhanVien();
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
     
            XtraMessageBox.Show("DỮ LIỆU ĐÃ ĐƯỢC CẬP NHẬT!", "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            timKiem();
        }

        //btn EditClick

        private void buttonEditClick(object sender, EventArgs e)
        {
            frmEditNhanVien frmEdit = new frmEditNhanVien(NhanVien_CellClickDTO);
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

            LoadDanhSachNhanVien();
            dataGridViewNhanVien.Refresh();
            dataGridViewNhanVien.Update();

        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            deleteNhanVien();
        }


        #endregion


        #region UI CREATE

        /* 
         * CREATE UI FOR frmNHANVIEN
         * 
         */

        private void CreateDataGridViewNhanVien()
        {
            DataGridViewTextBoxColumn MaNV = new DataGridViewTextBoxColumn();
            MaNV.Name = "MaNV";
            MaNV.HeaderText = "Mã Nhân Viên";
            MaNV.DataPropertyName = "MaNV";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewNhanVien.Columns.Add(MaNV);


            DataGridViewTextBoxColumn HoTen = new DataGridViewTextBoxColumn();
            HoTen.Name = "HoTen";
            HoTen.HeaderText = "Họ Tên";
            HoTen.DataPropertyName = "HoTen";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewNhanVien.Columns.Add(HoTen);

            DataGridViewTextBoxColumn TenChucVu = new DataGridViewTextBoxColumn();
            TenChucVu.Name = "TenChucVu";
            TenChucVu.HeaderText = "Chức Vụ";
            TenChucVu.DataPropertyName = "TenChucVu";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewNhanVien.Columns.Add(TenChucVu);

            DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();
            DiaChi.Name = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.DataPropertyName = "DiaChi";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewNhanVien.Columns.Add(DiaChi);

            DataGridViewTextBoxColumn SDT = new DataGridViewTextBoxColumn();
            SDT.Name = "SDT";
            SDT.HeaderText = "Số Điện Thoại";
            SDT.DataPropertyName = "SDT";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewNhanVien.Columns.Add(SDT);

            DataGridViewTextBoxColumn Luong = new DataGridViewTextBoxColumn();
            Luong.Name = "Luong";
            Luong.HeaderText = "Tiền Lương";
            Luong.DataPropertyName = "Luong";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewNhanVien.Columns.Add(Luong);

            DataGridViewTextBoxColumn TongCaLam = new DataGridViewTextBoxColumn();
            TongCaLam.Name = "TongCaLam";
            TongCaLam.HeaderText = "Tổng Ca Làm Việc";
            TongCaLam.DataPropertyName = "TongCaLam";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewNhanVien.Columns.Add(TongCaLam);

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
            colButtonEdit.Click += buttonEditClick;
            dataGridViewNhanVien.Columns.Add(colButtonEdit);

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

            dataGridViewNhanVien.Columns.Add(colButtonDelete);
        }

        #endregion

        #region MAP_BUSS

        private void deleteNhanVien()
        {

            //Tạo List string chứ MaCV
            List<string> selectedRowsID = new List<string>();

            //add MaKH của những row đang được select vào List
            foreach (DataGridViewRow row in dataGridViewNhanVien.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                selectedRowsID.Add(id);
            }

            //1. Map data from GUI
            NhanVienDTO nhanVienDTO = new NhanVienDTO();

            if (selectedRowsID.Count == 0)
            {
                XtraMessageBox.Show("HÃY CHỌN ÍT NHẤT MỘT HÀNG DỮ LIỆU ĐỂ XÓA!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result_ = XtraMessageBox.Show("BẠN CHẮC CHẮN MUỐN XÓA DỮ LIỆU ?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result_ == DialogResult.OK)
                {
                    foreach (string strID in selectedRowsID)
                    {
                        nhanVienDTO.StrMaNhanVien = strID;

                        //2.Kiem tra tren tang database
                        bool result = NhanVienBUS.XoaNV(nhanVienDTO);
                        if (result == false)
                        {
                            XtraMessageBox.Show("XẢY RA LỖI KHI XÓA DỮ LIỆU!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    LoadDanhSachNhanVien();
                    XtraMessageBox.Show("ĐÃ XÓA THÀNH CÔNG", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    //Roll back to NhanVien
                }
            }
        }

        private void timKiem()
        {
            sKeyword = txtSearch.Text.Trim();
            // List<KhachHangDTO> ListKhachHang = khachHangBUS.getListKhachHangByKey(sKeyword);
            DataTable data = NhanVienBUS.GetDanhSachNVByKey(sKeyword);

            if (sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0)
            {
                this.LoadDanhSachNhanVien();

            }
            else
            {

                dataGridViewNhanVien.DataSource = data;
                dataGridViewNhanVien.Refresh();
                dataGridViewNhanVien.Update();

            }
        }

        #endregion

       
    }
}