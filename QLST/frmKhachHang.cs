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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private KhachHangDTO khachHangDTO = new KhachHangDTO();
        private KhachHangDTO khachHang_CellClickDTO = new KhachHangDTO();
        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        private DataTable khachHangDataTable = new DataTable();
        private List<string> listMaKhachHang = new List<string>();
        private DataTable dataTableUpdateTemp;
        private DataTable dataTableInsertTemp;
        private string sKeyword = string.Empty;


        public frmKhachHang()
        {
            InitializeComponent();

            khachHangDataTable = InitKhachHangDataTable("khachHangDataTable");
            dataTableUpdateTemp = InitKhachHangDataTable("dataTableUpdateTemp");
            dataTableInsertTemp = InitKhachHangDataTable("dataTableInsertTemp");
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadDanhSachKhachHang();
            getListMaKhachHang();


        }

        #region DATA_BINDING
        /*
         * Binding Data vào UI và xử lý các tác vụ liên quan đến database
         */
        private void loadDanhSachKhachHang()
        {
            List<KhachHangDTO> listKhachHang = khachHangBUS.getListDanhSachKhachHang();
            khachHangDataTable = khachHangBUS.getDanhSachKhachHang();


            if (listKhachHang == null)
            {
                XtraMessageBox.Show("Đã Có Lỗi Xảy Ra Khi Tải Dữ Liệu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewKhachHang.Columns.Clear();
            dataGridViewKhachHang.DataSource = null;

            dataGridViewKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKhachHang.AutoGenerateColumns = false;
            //dataGridViewKhachHang.AllowUserToAddRows = false;

            dataGridViewKhachHang.DataSource = listKhachHang;
            CreateDataGridViewKhachHang();

           

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewKhachHang.DataSource];
            myCurrencyManager.Refresh();

        }


        private void loadDanhSachKhachHang_byKey(List<KhachHangDTO> listKhachHang)
        {
            
            listKhachHang = khachHangBUS.getListKhachHangByKey(sKeyword);


            if (listKhachHang == null)
            {
                XtraMessageBox.Show("Đã Có Lỗi Xảy Ra Khi Tải Dữ Liệu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewKhachHang.Columns.Clear();
            dataGridViewKhachHang.DataSource = null;

            dataGridViewKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKhachHang.AutoGenerateColumns = false;
            //dataGridViewKhachHang.AllowUserToAddRows = false;

            dataGridViewKhachHang.DataSource = listKhachHang;
            CreateDataGridViewKhachHang();




            // dgvLoadSach.Sort(dgvLoadSach.Columns[0], ListSortDirection.Ascending);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewKhachHang.DataSource];
            myCurrencyManager.Refresh();

        }

        private DataTable InitKhachHangDataTable(string dataTableName)
        {
            DataTable dataTable = new DataTable(dataTableName);
            dataTable.Columns.Add("MaKH");
            dataTable.Columns.Add("HoTen");
            dataTable.Columns.Add("Diem", typeof(double));
            dataTable.Columns.Add("MaHang");

            return dataTable;
        }

        private void getListMaKhachHang()
        {
            foreach (DataRow row in khachHangDataTable.Rows)
            {
                listMaKhachHang.Add(row["MaKH"].ToString());

            }
        }

        private bool getDataForTempTable()
        {
            DataTable changedRowsDataTable;
            changedRowsDataTable = InitKhachHangDataTable("changedRowsDataTable");
            changedRowsDataTable = getCurrentlyEditedRowData();

            if (changedRowsDataTable != null)
            {
                foreach (DataRow row in changedRowsDataTable.Rows)
                {
                    //listMaKhachHang.Add(row["MaKH"].ToString());
                    //nếu MaKH đã tồn tại trong database -> UPdate
                    if (listMaKhachHang.Contains(row["MaKH"].ToString()))
                    {
                        try
                        {
                            //Create a new row and add to dataTableInsertTemp
                            DataRow updateRow = dataTableUpdateTemp.NewRow();
                            updateRow[0] = row["MaKH"].ToString();
                            updateRow[1] = row["HoTen"].ToString();
                            updateRow[2] = double.Parse(row["Diem"].ToString());
                            updateRow[3] = row["MaHang"].ToString();

                            dataTableInsertTemp.Rows.Add(updateRow);
                        }
                        catch (Exception)
                        {

                        }
                    }

                    //ngược lại
                    else if (!listMaKhachHang.Contains(row["MaKH"].ToString()))
                    {
                        try
                        {
                            //Create a new row and add to dataTableInsertTemp
                            DataRow insertRow = dataTableInsertTemp.NewRow();
                            insertRow[0] = row["MaKH"].ToString();
                            insertRow[1] = row["HoTen"].ToString();
                            insertRow[2] = double.Parse(row["Diem"].ToString());
                            insertRow[3] = row["MaHang"].ToString();

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


        private void CreateDataGridViewKhachHang()
        {

            DataGridViewTextBoxColumn MaKH = new DataGridViewTextBoxColumn();
            MaKH.Name = "MaKH";
            MaKH.HeaderText = "Mã Khách Hàng";
            MaKH.DataPropertyName = "MaKH";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewKhachHang.Columns.Add(MaKH);


            DataGridViewTextBoxColumn HoTen = new DataGridViewTextBoxColumn();
            HoTen.Name = "HoTen";
            HoTen.HeaderText = "Họ Tên Khách Hàng";
            HoTen.DataPropertyName = "HoTen";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewKhachHang.Columns.Add(HoTen);

            DataGridViewTextBoxColumn Diem = new DataGridViewTextBoxColumn();
            Diem.Name = "Diem";
            Diem.HeaderText = "Điểm Số Tích Lũy";
            Diem.DataPropertyName = "Diem";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewKhachHang.Columns.Add(Diem);

            DataGridViewTextBoxColumn MaHang = new DataGridViewTextBoxColumn();
            MaHang.Name = "MaHang";
            MaHang.HeaderText = "Tên Hạng";
            MaHang.DataPropertyName = "MaHang";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewKhachHang.Columns.Add(MaHang);

            // 
            // colButtonEdit
            // 
            DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colButtonEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
           
            colButtonEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            colButtonEdit.DataPropertyName = "ButtonEdit";
            colButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            colButtonEdit.HeaderText = "Button Edit";
           // colButtonEdit.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            //colButtonEdit.Image = Properties.Resources.formatastable_16x16;
            colButtonEdit.ImageTextSpacing = 5;
            colButtonEdit.Name = "colButtonEdit";
            colButtonEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            colButtonEdit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            colButtonEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            colButtonEdit.SubItemsExpandWidth = 20;
            colButtonEdit.Text = "Sửa";
            colButtonEdit.ToolTipText = "Cập Nhật Thông Tin";
            colButtonEdit.Click += buttonEditClick;
            dataGridViewKhachHang.Columns.Add(colButtonEdit);

            DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colButtonDelete = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();

            colButtonDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            colButtonDelete.DataPropertyName = "ButtonEdit";
            colButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            colButtonDelete.HeaderText = "Button Xóa";
            colButtonDelete.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            colButtonDelete.Image = Properties.Resources.delete_16x16;
            colButtonDelete.ImageTextSpacing = 5;
            colButtonDelete.Name = "colButtonDelete";
            colButtonEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            colButtonDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            colButtonDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            colButtonDelete.SubItemsExpandWidth = 20;
            colButtonDelete.Text = "Xóa";
            colButtonDelete.ToolTipText = "Xóa Thông Tin";
            colButtonDelete.Click += btnDeleteClick;

            dataGridViewKhachHang.Columns.Add(colButtonDelete);

            //DataGridViewLinkCell colEdit = new DataGridViewLinkCell();
            //colEdit.Value = "Edit";
            //dataGridViewKhachHang.Columns.Add(colEdit);
            //dataGridViewKhachHang.Columns["ButtonDelete"].DefaultCellStyle.BackColor = Color.FloralWhite;
            //dataGridViewKhachHang.Columns["ButtonEdit"].DefaultCellStyle.BackColor = Color.FloralWhite;
        }


        #endregion

        #region MAPPING_BUS

        private int themKhachHang(KhachHangDTO khachHang)
        {
            bool re = khachHangBUS.themKhachHang(khachHang);
            return (re == true ? 1 : 0);
        }

        private int updateKhachHang(KhachHangDTO khachHang)
        {
            bool re = khachHangBUS.suaKhachHang(khachHang);
            return (re == true ? 1 : 0);
        }
        #endregion

        private void timKiemKhachHang()
        {
            sKeyword = txtSearch.Text.Trim();
            List<KhachHangDTO> ListKhachHang = khachHangBUS.getListKhachHangByKey(sKeyword);
            if (sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0)
            {
                this.loadDanhSachKhachHang();

            }
            else
            {
                //this.loadDanhSachKhachHang_byKey(ListKhachHang);
                //this.gridViewKhachHang.Refresh();
                dataGridViewKhachHang.DataSource = ListKhachHang;
                dataGridViewKhachHang.Refresh();
                dataGridViewKhachHang.Update();

            }
        }


        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            timKiemKhachHang();
        }

        private void dataGridViewKhachHang_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deleteKhachHang();
        }


       
        private void deleteKhachHang()
        {

            //Tạo List string chứ MaKH
            List<string> selectedRowsID = new List<string>();

            //add MaKH của những row đang được select vào List
            foreach (DataGridViewRow row in dataGridViewKhachHang.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                selectedRowsID.Add(id);
            }


            //1. Map data from GUI
            KhachHangDTO khachHang = new KhachHangDTO();


            if (selectedRowsID.Count == 0)
            {
                //MessageBox.Show("HÃY CHỌN ÍT NHẤT MỘT HÀNG DỮ LIỆU ĐỂ XÓA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                XtraMessageBox.Show("HÃY CHỌN ÍT NHẤT MỘT HÀNG DỮ LIỆU ĐỂ XÓA!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                DialogResult result_ = XtraMessageBox.Show("BẠN CHẮC CHẮN MUỐN XÓA KHÁCH HÀNG CHỨ ?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result_ == DialogResult.OK)
                {
                    foreach (string strID in selectedRowsID)
                    {
                        khachHang.StrMaKH = strID;

                        //2.Kiem tra tren tang database
                        bool result = khachHangBUS.xoaKhachHang(khachHang);
                        if (result == false)
                        {
                            XtraMessageBox.Show("XẢY RA LỖI KHI XÓA KHÁCH HÀNG!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                    loadDanhSachKhachHang();

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

        //BTN_THEM
        private void btnThemKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            AddNewRowItem(true);
            int newRowIndex =
            dataGridViewKhachHang.NewRowIndex;
            dataGridViewKhachHang.CurrentCell = dataGridViewKhachHang.Rows[newRowIndex].Cells[0];

        }

        //BTN_LUU
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //getCurrentlyEditedRowData();
            if (!getDataForTempTable())
            {
                XtraMessageBox.Show("Đã Có Lỗi Xảy Ra, Vui Lòng Kiểm Tra Lại!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            int flag = 0;
            int flag1 = 1;
            //Insert Database
            foreach (DataRow row in dataTableInsertTemp.Rows)
            {
                khachHangDTO = new KhachHangDTO();
                khachHangDTO.StrMaKH = row["MaKH"].ToString();
                khachHangDTO.StrHoTen = row["HoTen"].ToString();
                khachHangDTO.DDiem = double.Parse(row["Diem"].ToString());
                khachHangDTO.StrMaHang = row["MaHang"].ToString();

                //return 1 if successfull
                flag = themKhachHang(khachHangDTO);
            }

            foreach (DataRow row in dataTableUpdateTemp.Rows)
            {
                khachHangDTO = new KhachHangDTO();
                khachHangDTO.StrMaKH = row["MaKH"].ToString();
                khachHangDTO.StrHoTen = row["HoTen"].ToString();
                khachHangDTO.DDiem = double.Parse(row["Diem"].ToString());
                khachHangDTO.StrMaHang = row["MaHang"].ToString();

                //return 1 if successfull
                flag1 = updateKhachHang(khachHangDTO);


            }

            if (flag == 0)
            {
                XtraMessageBox.Show("Đã Có Lỗi Xảy Ra, Vui Lòng Kiểm Tra Lại!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show("Dữ Liệu đã được cập nhật!", "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // gridKhachHang.RefreshDataSource();
        }

        //Add new row
        private void OnEditValueChanged(object sender, EventArgs e)
        {
            //if (gridViewKhachHang.FocusedRowHandle == GridControl.NewItemRowHandle)
            //{
            //    gridViewKhachHang.CloseEditor();
            //    gridViewKhachHang.UpdateCurrentRow();
            //    gridViewKhachHang.ShowEditor();


            //    TextEdit edit = sender as TextEdit;
            //    if (edit == null) return;
            //    edit.SelectionStart = 1;
            //    edit.SelectionLength = 0;
            //}
            //AddNewRowItem(false);
        }


        //Thực hiện Add 1 row mới vào gridControl
        private void AddNewRowItem(bool result)
        {
            if (result == true)
                dataGridViewKhachHang.AllowUserToAddRows = true;
            else
            {
                dataGridViewKhachHang.AllowUserToAddRows = false;
            }



        }


        //Rằng buộc dữ liệu trong cell được nhập
        private void gridViewKhachHang_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {

            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            string mess = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError.ToString();
            XtraMessageBox.Show(mess, "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private DataTable getCurrentlyEditedRowData()
        {
            //Trả về DataTable các rows đã được chỉnh sửa



            // Bind dataGridView to DataView.
            // MyView = (DataView)dataGridViewKhachHang.DataSource;

            // Bind  DataView to Table.
            //myTable = (DataTable)MyView.Table.GetChanges();

            DataTable dt = (DataTable)(dataGridViewKhachHang.DataSource);
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

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            try
            {
                DataGridViewRow selectedRows = dataGridViewKhachHang.Rows[ind];

                //Get data into cellclick dto

                khachHang_CellClickDTO.StrMaKH = selectedRows.Cells[0].Value.ToString();
                khachHang_CellClickDTO.StrHoTen = selectedRows.Cells[1].Value.ToString();
                khachHang_CellClickDTO.DDiem = double.Parse( (selectedRows.Cells[2].Value.ToString()));
                khachHang_CellClickDTO.StrMaHang = (selectedRows.Cells[3].Value.ToString());
                
            }
            catch
            {

            }
        }

        private void dataGridViewKhachHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int lastRow = e.RowIndex;
                DataGridViewRow nRow = dataGridViewKhachHang.Rows[lastRow];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditClick(object sender, EventArgs e)
        {

           
        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            deleteKhachHang();
        }

        private void buttonEditClick(object sender, EventArgs e)
        {
            frmEditKhachHang frmEdit = new frmEditKhachHang(khachHang_CellClickDTO);
            frmEdit.StartPosition = FormStartPosition.CenterParent;
            frmEdit.ShowDialog();
        }

        private void dataGridViewKhachHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            AddNewRowItem(false);
        }
    }
}