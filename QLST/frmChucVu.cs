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
using QLSTBUS;
using DevExpress.XtraEditors;

namespace QLST
{
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {


        private ChucVuDTO ChucVuDTO = new ChucVuDTO();
        private ChucVuDTO ChucVu_CellClickDTO = new ChucVuDTO();
        private ChucVuBUS ChucVuBUS = new ChucVuBUS();
        private DataTable ChucVuDataTable = new DataTable();
        private List<string> ListMaCV = new List<string>();

        private string sKeyword = string.Empty;
        private DataTable dataTableUpdateTemp;
        private DataTable dataTableInsertTemp;
       


        public frmChucVu()
        {
            InitializeComponent();
        }


        private void frmChucVu_Load_1(object sender, EventArgs e)
        {
            LoadDanhSachChucVu();
            GetListMaCV();
            SelectedRowsDefault();
    
            dataGridViewChucVu.CurrentCell = dataGridViewChucVu.Rows[0].Cells[0];
            ChucVuDataTable = InitChucVuDataTable("ChucVuDataTable");
            dataTableUpdateTemp = InitChucVuDataTable("dataTableUpdateTemp");
            dataTableInsertTemp = InitChucVuDataTable("dataTableInsertTemp");
        }

        #region DATA_BINDING
        /*
         * Binding Data vào UI và xử lý các tác vụ liên quan đến database
         */
        public void LoadDanhSachChucVu()
        {
            //List<HangDTO> listHang = HangBUS.getListDanhSachHang();
            ChucVuDataTable = ChucVuBUS.GetDataTableCV();


            if (ChucVuDataTable == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dataGridViewChucVu.Columns.Clear();
            dataGridViewChucVu.DataSource = null;

            dataGridViewChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewChucVu.AutoGenerateColumns = false;
            //dataGridViewHang.AllowUserToAddRows = false;


            dataGridViewChucVu.DataSource = ChucVuDataTable;
            CreateDataGridViewHang();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewChucVu.DataSource];
            myCurrencyManager.Refresh();

        }


      
        private DataTable InitChucVuDataTable(string dataTableName)
        {
            DataTable dataTable = new DataTable(dataTableName);
            dataTable.Columns.Add("MaCV");
            dataTable.Columns.Add("TenChucVu");
            dataTable.Columns.Add("LuongCa");
            return dataTable;
        }

        private void GetListMaCV()
        {
            foreach (DataRow row in ChucVuDataTable.Rows)
            {
                ListMaCV.Add(row["MaCV"].ToString());

            }
        }

        private bool getDataForTempTable()
        {
            DataTable changedRowsDataTable;
            changedRowsDataTable = InitChucVuDataTable("changedRowsDataTable");
            changedRowsDataTable = getCurrentlyEditedRowData();

            if (changedRowsDataTable != null)
            {
                foreach (DataRow row in changedRowsDataTable.Rows)
                {
                    
                    if (!ListMaCV.Contains(row["MaCV"].ToString()))
                    {
                        try
                        {
                            //Create a new row and add to dataTableInsertTemp
                            DataRow insertRow = dataTableInsertTemp.NewRow();
                            insertRow[0] = row["MaCV"].ToString();
                            insertRow[1] = row["TenChucVu"].ToString();
                            insertRow[2] = float.Parse(row["LuongCa"].ToString());
                          

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

            DataGridViewTextBoxColumn MaCV = new DataGridViewTextBoxColumn();
            MaCV.Name = "MaCV";
            MaCV.HeaderText = "Mã Chức Vụ";
            MaCV.DataPropertyName = "MaCV";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewChucVu.Columns.Add(MaCV);


            DataGridViewTextBoxColumn TenChucVu = new DataGridViewTextBoxColumn();
            TenChucVu.Name = "TenChucVu";
            TenChucVu.HeaderText = "Tên Chức Vụ";
            TenChucVu.DataPropertyName = "TenChucVu";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewChucVu.Columns.Add(TenChucVu);

            DataGridViewTextBoxColumn LuongCa = new DataGridViewTextBoxColumn();
            LuongCa.Name = "LuongCa";
            LuongCa.HeaderText = "Lương Theo Ca Làm";
            LuongCa.DataPropertyName = "LuongCa";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewChucVu.Columns.Add(LuongCa);

           

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
            dataGridViewChucVu.Columns.Add(colButtonEdit);

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

            dataGridViewChucVu.Columns.Add(colButtonDelete);

        }


        #endregion

        #region MAPPING_BUS

        private int themCV(ChucVuDTO chucVuDTO)
        {
            bool re = ChucVuBUS.them(chucVuDTO);
            return (re == true ? 1 : 0);
        }

        private int updateHang(ChucVuDTO chucVuDTO)
        {
            bool re = ChucVuBUS.sua(chucVuDTO);
            return (re == true ? 1 : 0);
        }
        #endregion

        private void timKiem()
        {
            sKeyword = txtSearch.Text.Trim();
            // List<KhachHangDTO> ListKhachHang = khachHangBUS.getListKhachHangByKey(sKeyword);
            DataTable data = ChucVuBUS.GetDataTableCV_ByKey(sKeyword);

            if (sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0)
            {
                this.LoadDanhSachChucVu();

            }
            else
            {

                dataGridViewChucVu.DataSource = data;
                dataGridViewChucVu.Refresh();
                dataGridViewChucVu.Update();

            }
        }


        private void deleteChucVu()
        {

            //Tạo List string chứ MaCV
            List<string> selectedRowsID = new List<string>();

            //add MaKH của những row đang được select vào List
            foreach (DataGridViewRow row in dataGridViewChucVu.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                selectedRowsID.Add(id);
            }

            //1. Map data from GUI
            ChucVuDTO chucVuDTO = new ChucVuDTO();

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
                        chucVuDTO.StrMaCV = strID;

                        //2.Kiem tra tren tang database
                        bool result = ChucVuBUS.xoa(chucVuDTO);
                        if (result == false)
                        {
                            XtraMessageBox.Show("XẢY RA LỖI KHI XÓA DỮ LIỆU!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                    LoadDanhSachChucVu();

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

        

      

    

        //Thực hiện Add 1 row mới vào gridControl
        private void AddNewRowItem(bool result)
        {
            if (result)
                dataGridViewChucVu.AllowUserToAddRows = true;
            else
            {
                dataGridViewChucVu.AllowUserToAddRows = false;
            }



        }


        private DataTable getCurrentlyEditedRowData()
        {
            //Trả về DataTable các rows đã được chỉnh sửa
            // Bind dataGridView to DataView.
            // MyView = (DataView)dataGridViewKhachHang.DataSource;

            // Bind  DataView to Table.
            //myTable = (DataTable)MyView.Table.GetChanges();

            DataTable dt = (DataTable)(dataGridViewChucVu.DataSource);
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
                DataGridViewRow nRow = dataGridViewChucVu.Rows[lastRow];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEditClick(object sender, EventArgs e)
        {
            frmEditChucVu frmEdit = new frmEditChucVu(ChucVu_CellClickDTO);
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
            dataGridViewChucVu.Refresh();
            dataGridViewChucVu.Update();

        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            deleteChucVu();
        }



        private void dataGridViewKhachHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            AddNewRowItem(false);

        }

       

        private void SelectedRowsDefault()
        {

            try
            {
                DataGridViewRow selectedRows = dataGridViewChucVu.Rows[0];

                //Get data into cellclick dto

                ChucVu_CellClickDTO.StrMaCV = selectedRows.Cells[0].Value.ToString();
                ChucVu_CellClickDTO.StrTenCV = selectedRows.Cells[1].Value.ToString();
                ChucVu_CellClickDTO.FLuongCa = float.Parse((selectedRows.Cells[2].Value.ToString()));


                //get data to text

                txtMaCV.Text = selectedRows.Cells[0].Value.ToString();
                txtTenChucVu.Text = selectedRows.Cells[1].Value.ToString();
                txtLuongCa.Text = ((selectedRows.Cells[2].Value.ToString()));
            }
            catch
            {
                Console.WriteLine("CellClick can not bound data!");
            }
        }

        

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                AddNewRowItem(true);
                int newRowIndex =
                dataGridViewChucVu.NewRowIndex;
                dataGridViewChucVu.CurrentCell = dataGridViewChucVu.Rows[newRowIndex].Cells[0];
            }
            catch (Exception)
            {
                XtraMessageBox.Show("HỆ THỐNG ĐÃ XẢY RA LỖI, VUI LÒNG THỬ LẠI SAU!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            deleteChucVu();
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
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
                ChucVuDTO chucVuDTO = new ChucVuDTO();
                chucVuDTO.StrMaCV = row["MaCV"].ToString();
                chucVuDTO.StrTenCV = row["TenChucVu"].ToString();
                chucVuDTO.FLuongCa = float.Parse(row["LuongCa"].ToString());


                //return 1 if successfull
                flag = themCV(chucVuDTO);

            }

            if (flag == 0)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA, VUI LÒNG KIỂM TRA LẠI!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show("DỮ LIỆU ĐÃ ĐƯỢC CẬP NHẬT!", "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtSearch_EditValueChanged_1(object sender, EventArgs e)
        {
            timKiem();
        }

        private void dataGridViewChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            try
            {
                DataGridViewRow selectedRows = dataGridViewChucVu.Rows[ind];

                //Get data into cellclick dto

                ChucVu_CellClickDTO.StrMaCV = selectedRows.Cells[0].Value.ToString();
                ChucVu_CellClickDTO.StrTenCV = selectedRows.Cells[1].Value.ToString();
                ChucVu_CellClickDTO.FLuongCa = float.Parse((selectedRows.Cells[2].Value.ToString()));


                //get data to text

                txtMaCV.Text = selectedRows.Cells[0].Value.ToString();
                txtTenChucVu.Text = selectedRows.Cells[1].Value.ToString();
                txtLuongCa.Text = ((selectedRows.Cells[2].Value.ToString()));

            }
            catch
            {
                Console.WriteLine("CellClick can not bound data!");
            }
        }

        
    }
}