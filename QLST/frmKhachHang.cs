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

namespace QLST
{

    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private KhachHangDTO khachHangDTO = new KhachHangDTO();
        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        private DataTable khachHangDataTable = new DataTable();
        private List<string> listMaKhachHang = new List<string>();
        private DataTable dataTableUpdateTemp;
        private DataTable dataTableInsertTemp;




        public frmKhachHang()
        {
            InitializeComponent();

            dataTableUpdateTemp = InitKhachHangDataTable("dataTableUpdateTemp");
            dataTableInsertTemp = InitKhachHangDataTable("dataTableInsertTemp");

        }


        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadDanhSachKhachHang();
            getListMaKhachHang();
            createGridViewColumn();
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

            GridView view = gridKhachHang.MainView as GridView;
            (view).Columns.Clear();
            gridKhachHang.DataSource = null;

            changeGridViewHeaderText();
            // createGridViewColumn();
            gridKhachHang.DataSource = khachHangDataTable;
            gridKhachHang.ForceInitialize();

            gridKhachHang.MainView.PopulateColumns();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridKhachHang.DataSource];
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
                        // dataTableUpdateTemp.NewRow();
                        dataTableUpdateTemp.ImportRow(row);
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
            for (int i = 0; i < gridViewKhachHang.VisibleColumns.Count; i++)
                gridViewKhachHang.VisibleColumns[i].RealColumnEdit.EditValueChanged += OnEditValueChanged;

            AddNewRowItem(true);

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

                if (flag == 0)
                {
                    XtraMessageBox.Show("Đã Có Lỗi Xảy Ra, Vui Lòng Kiểm Tra Lại!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                XtraMessageBox.Show("Dữ Liệu đã được cập nhật!", "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridKhachHang.RefreshDataSource();
            }
        }

        //Add new row
        private void OnEditValueChanged(object sender, EventArgs e)
        {
            if (gridViewKhachHang.FocusedRowHandle == GridControl.NewItemRowHandle)
            {
                gridViewKhachHang.CloseEditor();
                gridViewKhachHang.UpdateCurrentRow();
                gridViewKhachHang.ShowEditor();


                TextEdit edit = sender as TextEdit;
                if (edit == null) return;
                edit.SelectionStart = 1;
                edit.SelectionLength = 0;
            }
            AddNewRowItem(false);
        }


        //Thực hiện Add 1 row mới vào gridControl
        private void AddNewRowItem(bool result)
        {
            if (result == true)
            {
                gridViewKhachHang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            else
                this.gridViewKhachHang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
        }


        //Rằng buộc dữ liệu trong cell được nhập
        private void gridViewKhachHang_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            gridViewKhachHang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }


        private DataTable getCurrentlyEditedRowData()
        {
            //Trả về DataTable các rows đã được chỉnh sửa

            DataTable myTable;
            DataView MyView;
            DataSet ds = new DataSet();

            // Bind dataGridView to DataView.
            MyView = (DataView)gridViewKhachHang.DataSource;

            // Bind  DataView to Table.
            myTable = (DataTable)MyView.Table.GetChanges();

            //BindingSource bindingSource = (BindingSource)gridViewKhachHang.DataSource;
            //DataTable changedRowsDataTable = (DataTable)bindingSource.DataSource;
            //changedRowsDataTable.GetChanges();

            //DataTable changedRowsDataTable = ((DataTable)((BindingSource)gridViewKhachHang.DataSource).DataSource).GetChanges();
            // return changedRowsDataTable;
            return myTable;
        }
        #endregion


        /*
         * Hàm này trả data về cho 2 data table " dataTableUpdateTemp && dataTableInsertTemp"
         * Nếu data trả về có MaKH đã tồn tại trong database thì data sẽ được trả về cho dataTableUpdateTemp để
         * thực hiện việc update và ngược lại.
         * 
         */
       
        #region UI FORMAT
        private void changeGridViewHeaderText()
        {
            //GridView view = gridKhachHang.MainView as GridView;
            //(gridKhachHang.MainView as GridView).Columns[0].Caption = "123";

            //gridViewKhachHang.Columns[0].Caption = "Mã Khách Hàng";
            //gridViewKhachHang.Columns[1].Caption = "Họ Tên Khách Hàng";
            //gridViewKhachHang.Columns[2].Caption = "Điểm Số Tích Lũy";
            //gridViewKhachHang.Columns[3].Caption = "Tên Hạng";

        }
        private void createGridViewColumn()
        {


            DevExpress.XtraGrid.Columns.GridColumn colMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            DevExpress.XtraGrid.Columns.GridColumn colDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            DevExpress.XtraGrid.Columns.GridColumn colTenHang = new DevExpress.XtraGrid.Columns.GridColumn();

            // 
            // colMaKhachHang
            // 
            colMaKhachHang.Caption = "Mã Khách Hàng";
            colMaKhachHang.CustomizationCaption = "Mã Khách Hàng";
            colMaKhachHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colMaKhachHang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            //colMaKhachHang.ImageOptions.Image = ((System.Drawing.Image)(Resources.GetObject("colMaKhachHang.ImageOptions.Image")));
            colMaKhachHang.Name = "colMaKhachHang";
            colMaKhachHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            colMaKhachHang.OptionsEditForm.Caption = "Mã Khách Hàng";
            colMaKhachHang.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            colMaKhachHang.ToolTip = "Hiển Thị Mã Khách Hàng Thành Viên";
            colMaKhachHang.Visible = true;
            colMaKhachHang.VisibleIndex = 0;
            colMaKhachHang.Width = 204;
            // 
            // colTenKhachHang
            // 
            colTenKhachHang.Caption = "Họ Tên ";
            colTenKhachHang.Name = "colTenKhachHang";
            colTenKhachHang.OptionsEditForm.Caption = "Họ Tên";
            colTenKhachHang.Visible = true;
            colTenKhachHang.VisibleIndex = 1;
            colTenKhachHang.Width = 162;
            // 
            // colDiem
            // 
            colDiem.Caption = "Điểm Tích Lũy";
            colDiem.CustomizationCaption = "Điểm Tích Lũy";
            colDiem.Name = "colDiem";
            colDiem.Visible = true;
            colDiem.VisibleIndex = 2;
            colDiem.Width = 162;
            // 
            // colTenHang
            // 
            colTenHang.Caption = "Tên Hạng";
            colTenHang.CustomizationCaption = "Tên Hạng";
            colTenHang.Name = "colTenHang";
            colTenHang.Visible = true;
            colTenHang.VisibleIndex = 3;
            colTenHang.Width = 162;

            //gridViewKhachHang.Columns.Add(colMaKhachHang);
            //gridViewKhachHang.Columns.Add(colTenKhachHang);
            //gridViewKhachHang.Columns.Add(colDiem);
            //gridViewKhachHang.Columns.Add(colTenHang);

            gridViewKhachHang.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colMaKhachHang, DevExpress.Data.ColumnSortOrder.Ascending)});
        }

        #endregion

        #region MAPPING_BUS

        private int themKhachHang(KhachHangDTO khachHang)
        {
            bool re = khachHangBUS.themKhachHang(khachHang);
            return (re == true ? 1 : 0);
        }

        #endregion
    }
}