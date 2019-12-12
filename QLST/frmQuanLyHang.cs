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

namespace QLST
{
    public partial class frmQuanLyHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {


        private HangDTO hangDTO = new HangDTO();
        private HangDTO hang_CellClickDTO = new HangDTO();
        private HangBUS hangBUS = new HangBUS();
        private DataTable hangDataTable = new DataTable();
        private List<string> listMaHang = new List<string>();
        private DataTable dataTableUpdateTemp;
        private DataTable dataTableInsertTemp;
        private string sKeyword = string.Empty;


        public frmQuanLyHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyHang_Load(object sender, EventArgs e)
        {
            loadDanhSachHang();
            getListMaHang();
            SelectedRowsDefault();

            dataGridViewHang.CurrentCell = dataGridViewHang.Rows[0].Cells[0];
            hangDataTable = InitHangDataTable("hangDataTable");
            dataTableUpdateTemp = InitHangDataTable("dataTableUpdateTemp");
            dataTableInsertTemp = InitHangDataTable("dataTableInsertTemp");
        }

        #region DATA_BINDING
        /*
         * Binding Data vào UI và xử lý các tác vụ liên quan đến database
         */
        public void loadDanhSachHang()
        {
            //List<HangDTO> listHang = HangBUS.getListDanhSachHang();
            hangDataTable = hangBUS.GetDataTableHang();


            if (hangDataTable == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dataGridViewHang.Columns.Clear();
            dataGridViewHang.DataSource = null;

            dataGridViewHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHang.AutoGenerateColumns = false;
            //dataGridViewHang.AllowUserToAddRows = false;


            dataGridViewHang.DataSource = hangDataTable;
            CreateDataGridViewHang();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewHang.DataSource];
            myCurrencyManager.Refresh();

        }


        private void LoadDanhSachNhaCungCap_byKey(DataTable Hang)
        {

            // Hang = HangBUS.getDanhSachHang();
            //listHang = HangBUS.getListHangByKey(sKeyword);


            if (Hang == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dataGridViewHang.Columns.Clear();
            dataGridViewHang.DataSource = null;

            dataGridViewHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHang.AutoGenerateColumns = false;
            //dataGridViewHang.AllowUserToAddRows = false;

            dataGridViewHang.DataSource = Hang;
            CreateDataGridViewHang();
            // dgvLoadSach.Sort(dgvLoadSach.Columns[0], ListSortDirection.Ascending);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewHang.DataSource];
            myCurrencyManager.Refresh();

        }

        private DataTable InitHangDataTable(string dataTableName)
        {
            DataTable dataTable = new DataTable(dataTableName);
            dataTable.Columns.Add("MaHang");
            dataTable.Columns.Add("TenHang");
            dataTable.Columns.Add("ChietKhau");
            dataTable.Columns.Add("Diem");

            return dataTable;
        }

        private void getListMaHang()
        {
            foreach (DataRow row in hangDataTable.Rows)
            {
                listMaHang.Add(row["MaHang"].ToString());

            }
        }

        private bool getDataForTempTable()
        {
            DataTable changedRowsDataTable;
            changedRowsDataTable = InitHangDataTable("changedRowsDataTable");
            changedRowsDataTable = getCurrentlyEditedRowData();

            if (changedRowsDataTable != null)
            {
                foreach (DataRow row in changedRowsDataTable.Rows)
                {
                    //listMaHang.Add(row["MaKH"].ToString());
                    //nếu MaKH đã tồn tại trong database -> UPdate
                    if (listMaHang.Contains(row["MaHang"].ToString()))
                    {
                        try
                        {
                            //Create a new row and add to dataTableInsertTemp
                            DataRow updateRow = dataTableUpdateTemp.NewRow();
                            updateRow[0] = row["MaHang"].ToString();
                            updateRow[1] = row["TenHang"].ToString();
                            updateRow[2] = float.Parse(row["ChietKhau"].ToString());
                            updateRow[3] = double.Parse(row["Diem"].ToString());

                            dataTableInsertTemp.Rows.Add(updateRow);
                        }
                        catch (Exception)
                        {

                        }
                    }

                    //ngược lại
                    else if (!listMaHang.Contains(row["MaHang"].ToString()))
                    {
                        try
                        {
                            //Create a new row and add to dataTableInsertTemp
                            DataRow insertRow = dataTableInsertTemp.NewRow();
                            insertRow[0] = row["MaHang"].ToString();
                            insertRow[1] = row["TenHang"].ToString();
                            insertRow[2] = row["ChietKhau"].ToString();
                            insertRow[3] = row["Diem"].ToString();

                            dataTableInsertTemp.Rows.Add(insertRow);
                        }
                        catch (Exception)
                        {

                        }


                    }
                }
                return true;

            }
            else
                return false;
        }
        #endregion

        #region UI FORMAT


        private void CreateDataGridViewHang()
        {

            DataGridViewTextBoxColumn MaHang = new DataGridViewTextBoxColumn();
            MaHang.Name = "MaHang";
            MaHang.HeaderText = "Mã Hạng";
            MaHang.DataPropertyName = "MaHang";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewHang.Columns.Add(MaHang);


            DataGridViewTextBoxColumn TenHang = new DataGridViewTextBoxColumn();
            TenHang.Name = "TenHang";
            TenHang.HeaderText = "Tên Hạng";
            TenHang.DataPropertyName = "TenHang";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewHang.Columns.Add(TenHang);

            DataGridViewTextBoxColumn Diem = new DataGridViewTextBoxColumn();
            Diem.Name = "Diem";
            Diem.HeaderText = "Điểm Số Tối Thiểu";
            Diem.DataPropertyName = "Diem";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewHang.Columns.Add(Diem);

            DataGridViewTextBoxColumn ChietKhau = new DataGridViewTextBoxColumn();
            ChietKhau.Name = "ChietKhau";
            ChietKhau.HeaderText = "Chiết Khấu";
            ChietKhau.DataPropertyName = "ChietKhau";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewHang.Columns.Add(ChietKhau);

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
            dataGridViewHang.Columns.Add(colButtonEdit);

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

            dataGridViewHang.Columns.Add(colButtonDelete);

        }


        #endregion

        #region MAPPING_BUS

        private int themHang(HangDTO hangDTO)
        {
            bool re = hangBUS.them(hangDTO);
            return (re == true ? 1 : 0);
        }

        private int updateHang(HangDTO hangDTO)
        {
            bool re = hangBUS.sua(hangDTO);
            return (re == true ? 1 : 0);
        }
        #endregion

        private void timKiem()
        {
            sKeyword = txtSearch.Text.Trim();
            // List<KhachHangDTO> ListKhachHang = khachHangBUS.getListKhachHangByKey(sKeyword);
            DataTable dataHang = hangBUS.GetDataTableHangByKey(sKeyword);

            if (sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0)
            {
                this.loadDanhSachHang();

            }
            else
            {

                dataGridViewHang.DataSource = dataHang;
                dataGridViewHang.Refresh();
                dataGridViewHang.Update();

            }
        }


       

        private void dataGridViewKhachHang_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

            AddNewRowItem(true);
            int newRowIndex =
            dataGridViewHang.NewRowIndex;
            dataGridViewHang.CurrentCell = dataGridViewHang.Rows[newRowIndex].Cells[0];

        }

        private void deleteHang()
        {

            //Tạo List string chứ MaKH
            List<string> selectedRowsID = new List<string>();

            //add MaKH của những row đang được select vào List
            foreach (DataGridViewRow row in dataGridViewHang.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                selectedRowsID.Add(id);
            }


            //1. Map data from GUI
            HangDTO hangDTO = new HangDTO();


            if (selectedRowsID.Count == 0)
            {
                //MessageBox.Show("HÃY CHỌN ÍT NHẤT MỘT HÀNG DỮ LIỆU ĐỂ XÓA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                XtraMessageBox.Show("HÃY CHỌN ÍT NHẤT MỘT HÀNG DỮ LIỆU ĐỂ XÓA!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                DialogResult result_ = XtraMessageBox.Show("BẠN CHẮC CHẮN MUỐN XÓA DỮ LIỆU ?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result_ == DialogResult.OK)
                {
                    foreach (string strID in selectedRowsID)
                    {
                        hangDTO.StrMaHang = strID;

                        //2.Kiem tra tren tang database
                        bool result = hangBUS.xoa(hangDTO);
                        if (result == false)
                        {
                            XtraMessageBox.Show("XẢY RA LỖI KHI XÓA DỮ LIỆU!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    loadDanhSachHang();

                    XtraMessageBox.Show("ĐÃ XÓA THÀNH CÔNG", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    //Roll back to NhanVien
                }
            }
        }

        #region EventHandle
        /*
         * Đoạn code dưới đây là để thêm 1 row mới khi người dùng nhấn btnThemMoiKhachHang
         * Khi btnThemMoiKhachHang được click, gridControl sẽ thêm 1 dòng mới vào dưới cùng của gridViewKhachHang
         * Sau khi dữ liệu được nạp vào sẽ được lưu trữ trên DataTable
         * Người dùng có thể tùy chỉnh (Thêm, Xóa,Chỉnh sửa dữ liệu trên đây)
         * Chỉ khi nào btnLuu được click thì dữ liệu mới được insert hoặc update vào database
            
         */

        private void btnThemHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                AddNewRowItem(true);
                int newRowIndex =
                dataGridViewHang.NewRowIndex;
                dataGridViewHang.CurrentCell = dataGridViewHang.Rows[newRowIndex].Cells[0];
            }
            catch (Exception)
            {
                XtraMessageBox.Show("HỆ THỐNG ĐÃ XẢY RA LỖI, VUI LÒNG THỬ LẠI SAU!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deleteHang();
        }

        private void btnLuu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //getCurrentlyEditedRowData();
            if (!getDataForTempTable())
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA, VUI LÒNG KIỂM TRA LẠI!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }

            int flag = 0;
          
            //Insert Database
            foreach (DataRow row in dataTableInsertTemp.Rows)
            {
                hangDTO = new HangDTO();
                hangDTO.StrMaHang = row["MaHang"].ToString();
                hangDTO.StrTenHang = row["TenHang"].ToString();
                hangDTO.DDiem = double.Parse(row["ChietKhau"].ToString());
                hangDTO.FChietKhau = float.Parse(row["Diem"].ToString());

                //return 1 if successfull
                flag = themHang(hangDTO);

            }

            if (flag == 0)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA, VUI LÒNG KIỂM TRA LẠI!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show("DỮ LIỆU ĐÃ ĐƯỢC CẬP NHẬT!", "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // gridKhachHang.RefreshDataSource();
        }

        //Thực hiện Add 1 row mới vào gridControl
        private void AddNewRowItem(bool result)
        {
            if (result)
                dataGridViewHang.AllowUserToAddRows = true;
            else
            {
                dataGridViewHang.AllowUserToAddRows = false;
            }

        }
        private DataTable getCurrentlyEditedRowData()
        {
            //Trả về DataTable các rows đã được chỉnh sửa
            // Bind dataGridView to DataView.
            // MyView = (DataView)dataGridViewKhachHang.DataSource;

            // Bind  DataView to Table.
            //myTable = (DataTable)MyView.Table.GetChanges();

            DataTable dt = (DataTable)(dataGridViewHang.DataSource);
            dt = dt.GetChanges();

            //BindingSource bindingSource = (BindingSource)dataGridViewKhachHang.DataSource;
            //DataTable changedRowsDataTable = (DataTable)bindingSource.DataSource;
            // changedRowsDataTable.GetChanges();
            return dt;
        }
        #endregion


        /*
         * Hàm này trả data về cho 2 data table " dataTableUpdateTemp && dataTableInsertTemp"
         * Nếu data trả về có MaKH đã tồn tại trong database thì data sẽ được trả về cho dataTableUpdateTemp để
         * thực hiện việc update và ngược lại.
         * 
         */

       
        private void dataGridViewKhachHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int lastRow = e.RowIndex;
                DataGridViewRow nRow = dataGridViewHang.Rows[lastRow];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEditClick(object sender, EventArgs e)
        {
            frmEditHang frmEdit = new frmEditHang(hang_CellClickDTO);
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
            dataGridViewHang.Refresh();
            dataGridViewHang.Update();

        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            deleteHang();
        }

       
        private void dataGridViewKhachHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            AddNewRowItem(false);

        }

        private void dataGridViewHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            try
            {
                DataGridViewRow selectedRows = dataGridViewHang.Rows[ind];

                //Get data into cellclick dto

                hang_CellClickDTO.StrMaHang = selectedRows.Cells[0].Value.ToString();
                hang_CellClickDTO.StrTenHang = selectedRows.Cells[1].Value.ToString();
                hang_CellClickDTO.FChietKhau = float.Parse((selectedRows.Cells[3].Value.ToString()));
                hang_CellClickDTO.DDiem = double.Parse((selectedRows.Cells[2].Value.ToString()));

                //get data to text

                txtMaHang.Text = selectedRows.Cells[0].Value.ToString();
                txtTenHang.Text = selectedRows.Cells[1].Value.ToString();
                cmbChieuKhau.Text = ((selectedRows.Cells[3].Value.ToString()));
                txtDiemHang.Text = ((selectedRows.Cells[2].Value.ToString()));
            }
            catch
            {
                Console.WriteLine("CellClick can not bound data!");
            }
        }

        private void SelectedRowsDefault()
        {
           
            try
            {
                DataGridViewRow selectedRows = dataGridViewHang.Rows[0];

                //Get data into cellclick dto

                hang_CellClickDTO.StrMaHang = selectedRows.Cells[0].Value.ToString();
                hang_CellClickDTO.StrTenHang = selectedRows.Cells[1].Value.ToString();
                hang_CellClickDTO.FChietKhau = float.Parse((selectedRows.Cells[3].Value.ToString()));
                hang_CellClickDTO.DDiem = double.Parse((selectedRows.Cells[2].Value.ToString()));

                //get data to text

                txtMaHang.Text = selectedRows.Cells[0].Value.ToString();
                txtTenHang.Text = selectedRows.Cells[1].Value.ToString();
                cmbChieuKhau.Text = ((selectedRows.Cells[3].Value.ToString()));
                txtDiemHang.Text = ((selectedRows.Cells[2].Value.ToString()));
            }
            catch
            {
                Console.WriteLine("CellClick can not bound data!");
            }
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            timKiem();
        }
    }
}