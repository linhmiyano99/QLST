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
    public partial class frmMatHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MatHangDTO matHangDTO = new MatHangDTO();
        private MatHangDTO matHang_CellClickDTO = new MatHangDTO();
        private MatHangBUS matHangBUS = new MatHangBUS();
        private DataTable matHangDataTable = new DataTable();
        private List<string> listMaMatHang = new List<string>();
        private DataTable dataTableUpdateTemp;
        private DataTable dataTableInsertTemp;
        private string sKeyword = string.Empty;
        public frmMatHang()
        {
            InitializeComponent();
        }



        private void frmMatHang_Load(object sender, EventArgs e)
        {
            loadDanhSachMatHang();
            getListMaMatHang();

            matHangDataTable = InitMatHangDataTable("matHangDataTable");
            dataTableUpdateTemp = InitMatHangDataTable("dataTableUpdateTemp");
            dataTableInsertTemp = InitMatHangDataTable("dataTableInsertTemp");

        }

        #region DATA_BINDING
        /*
         * Binding Data vào UI và xử lý các tác vụ liên quan đến database
         */
        public void loadDanhSachMatHang()
        {
            //List<KhachHangDTO> listKhachHang = khachHangBUS.getListDanhSachKhachHang();
            matHangDataTable = matHangBUS.GetDataTableMatHang();


            if (matHangDataTable == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dataGridViewMatHang.Columns.Clear();
            dataGridViewMatHang.DataSource = null;

            dataGridViewMatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatHang.AutoGenerateColumns = false;
            //dataGridViewMatHang.AllowUserToAddRows = false;


            dataGridViewMatHang.DataSource = matHangDataTable;
            CreateDataGridViewMatHang();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewMatHang.DataSource];
            myCurrencyManager.Refresh();

        }
        private DataTable InitMatHangDataTable(string dataTableName)
        {
            DataTable dataTable = new DataTable(dataTableName);
            dataTable.Columns.Add("MaMH");
            dataTable.Columns.Add("TenMH");
            dataTable.Columns.Add("GiaNhap", typeof(double));
            dataTable.Columns.Add("GiaBan");
            dataTable.Columns.Add("TonToiDa", typeof(int));
            dataTable.Columns.Add("TonToiThieu", typeof(int));


            return dataTable;
        }
        private void getListMaMatHang()
        {
            foreach (DataRow row in matHangDataTable.Rows)
            {
                listMaMatHang.Add(row["MaMH"].ToString());

            }
        }

        private bool getDataForTempTable()
        {
            DataTable changedRowsDataTable;
            changedRowsDataTable = InitMatHangDataTable("changedRowsDataTable");
            changedRowsDataTable = getCurrentlyEditedRowData();

            if (changedRowsDataTable != null)
            {
                foreach (DataRow row in changedRowsDataTable.Rows)
                {
                    //listMaKhachHang.Add(row["MaKH"].ToString());
                    //nếu MaKH đã tồn tại trong database -> UPdate
                    if (listMaMatHang.Contains(row["MaMH"].ToString()))
                    {
                        try
                        {
                            //Create a new row and add to dataTableInsertTemp
                            DataRow updateRow = dataTableUpdateTemp.NewRow();
                            updateRow[0] = row["MaMH"].ToString();
                            updateRow[1] = row["TenMH"].ToString();
                            updateRow[2] = double.Parse(row["GiaNhap"].ToString());
                            updateRow[3] = row["GiaBan"].ToString();
                            updateRow[4] = int.Parse(row["TonToiDa"].ToString());
                            updateRow[5] = int.Parse(row["TonToiThieu"].ToString());

                            dataTableInsertTemp.Rows.Add(updateRow);
                        }
                        catch (Exception)
                        {

                        }
                    }

                    //ngược lại
                    else if (!listMaMatHang.Contains(row["MaMH"].ToString()))
                    {
                        try
                        {
                            //Create a new row and add to dataTableInsertTemp
                            DataRow insertRow = dataTableInsertTemp.NewRow();
                            insertRow[0] = row["MaMH"].ToString();
                            insertRow[1] = row["TenMH"].ToString();
                            insertRow[2] = double.Parse(row["GiaNhap"].ToString());
                            insertRow[3] = row["GiaBan"].ToString();
                            insertRow[4] = int.Parse(row["TonToiDa"].ToString());
                            insertRow[5] = int.Parse(row["TonToiThieu"].ToString());

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
        private void CreateDataGridViewMatHang()
        {

            DataGridViewTextBoxColumn MaMH = new DataGridViewTextBoxColumn();
            MaMH.Name = "MaMH";
            MaMH.HeaderText = "Mã Mặt Hàng";
            MaMH.DataPropertyName = "MaMH";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewMatHang.Columns.Add(MaMH);


            DataGridViewTextBoxColumn TenMH = new DataGridViewTextBoxColumn();
            TenMH.Name = "TenMH";
            TenMH.HeaderText = "Tên Mặt Hàng";
            TenMH.DataPropertyName = "TenMH";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewMatHang.Columns.Add(TenMH);

            DataGridViewTextBoxColumn GiaNhap = new DataGridViewTextBoxColumn();
            GiaNhap.Name = "GiaNhap";
            GiaNhap.HeaderText = "Giá Nhập";
            GiaNhap.DataPropertyName = "GiaNhap";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewMatHang.Columns.Add(GiaNhap);

            DataGridViewTextBoxColumn GiaBan = new DataGridViewTextBoxColumn();
            GiaBan.Name = "GiaBan";
            GiaBan.HeaderText = "Giá Bán";
            GiaBan.DataPropertyName = "GiaBan";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewMatHang.Columns.Add(GiaBan);

            DataGridViewTextBoxColumn TonToiThieu = new DataGridViewTextBoxColumn();
            TonToiThieu.Name = "TonToiThieu";
            TonToiThieu.HeaderText = "Tồn Tối Thiểu";
            TonToiThieu.DataPropertyName = "TonToiThieu";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewMatHang.Columns.Add(TonToiThieu); 
            
            DataGridViewTextBoxColumn TonToiDa = new DataGridViewTextBoxColumn();
            TonToiDa.Name = "TonToiDa";
            TonToiDa.HeaderText = "Tồn Tối Đa";
            TonToiDa.DataPropertyName = "TonToiDa";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewMatHang.Columns.Add(TonToiDa);

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
            dataGridViewMatHang.Columns.Add(colButtonEdit);

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

            dataGridViewMatHang.Columns.Add(colButtonDelete);

        }

        #endregion

        #region MAPPING_BUS

        private int themMatHang(MatHangDTO mathang)
        {
            bool re = matHangBUS.them(mathang);
            return (re == true ? 1 : 0);
        }

        private int updateMatHang(MatHangDTO mathang)
        {
            bool re = matHangBUS.sua(mathang);
            return (re == true ? 1 : 0);
        }
        #endregion
        private DataTable getCurrentlyEditedRowData()
        {
            //Trả về DataTable các rows đã được chỉnh sửa
            // Bind dataGridView to DataView.
            // MyView = (DataView)dataGridViewKhachHang.DataSource;

            // Bind  DataView to Table.
            //myTable = (DataTable)MyView.Table.GetChanges();

            DataTable dt = (DataTable)(dataGridViewMatHang.DataSource);
            dt = dt.GetChanges();

            //BindingSource bindingSource = (BindingSource)dataGridViewKhachHang.DataSource;
            //DataTable changedRowsDataTable = (DataTable)bindingSource.DataSource;
            // changedRowsDataTable.GetChanges();
            return dt;
        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            deleteMatHang();
        }

        private void buttonEditClick(object sender, EventArgs e)
        {
            frmEditMatHang frmEdit = new frmEditMatHang(matHang_CellClickDTO);
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
            dataGridViewMatHang.Refresh();
            dataGridViewMatHang.Update();


        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //getCurrentlyEditedRowData();
            if (!getDataForTempTable())
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA, VUI LÒNG KIỂM TRA LẠI!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //this.Close();
            }

            int flag = 0;
            int flag1 = 1;
            //Insert Database
            foreach (DataRow row in dataTableInsertTemp.Rows)
            {
                matHangDTO = new MatHangDTO();
                matHangDTO.StrMaMH = row["MaMH"].ToString();
                matHangDTO.StrTenMH = row["TenMH"].ToString();
                matHangDTO.DGiaNhap = double.Parse(row["GiaNhap"].ToString());
                matHangDTO.StrDonGia = row["GiaBan"].ToString();
                matHangDTO.ITonToiDa = int.Parse(row["TonToiDa"].ToString());
                matHangDTO.ITonToiThieu = int.Parse(row["TonToiThieu"].ToString());

                //return 1 if successfull
                flag = themMatHang(matHangDTO);
            }

            foreach (DataRow row in dataTableUpdateTemp.Rows)
            {
                matHangDTO = new MatHangDTO();
                 matHangDTO.StrMaMH = row["MaMH"].ToString();
                matHangDTO.StrTenMH = row["TenMH"].ToString();
                matHangDTO.DGiaNhap = double.Parse(row["GiaNhap"].ToString());
                matHangDTO.StrDonGia = row["MaHang"].ToString();
                matHangDTO.ITonToiDa = int.Parse(row["TonToiDa"].ToString());
                matHangDTO.ITonToiThieu = int.Parse(row["TonToiThieu"].ToString());

                //return 1 if successfull
                flag1 = updateMatHang(matHangDTO);
            }

            if (flag == 0)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA, VUI LÒNG KIỂM TRA LẠI!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show("DỮ LIỆU ĐÃ ĐƯỢC CẬP NHẬT!", "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // gridKhachHang.RefreshDataSource();
        }
        private void deleteMatHang()
        {

            //Tạo List string chứ MaKH
            List<string> selectedRowsID = new List<string>();

            //add MaKH của những row đang được select vào List
            foreach (DataGridViewRow row in dataGridViewMatHang.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                selectedRowsID.Add(id);
            }


            //1. Map data from GUI
            MatHangDTO matHang = new MatHangDTO();


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
                        matHang.StrMaMH = strID;

                        //2.Kiem tra tren tang database
                        bool result = matHangBUS.xoa(matHang);
                        if (result == false)
                        {
                            XtraMessageBox.Show("XẢY RA LỖI KHI XÓA KHÁCH HÀNG!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                    loadDanhSachMatHang();

                    XtraMessageBox.Show("ĐÃ XÓA THÀNH CÔNG", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }

                else
                {
                    //Roll back to NhanVien
                }
            }
        }

        private void btnThemMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                AddNewRowItem(true);
                int newRowIndex =
                dataGridViewMatHang.NewRowIndex;
                dataGridViewMatHang.CurrentCell = dataGridViewMatHang.Rows[newRowIndex].Cells[0];
            }
            catch (Exception)
            {
                XtraMessageBox.Show("HỆ THỐNG ĐÃ XẢY RA LỖI, VUI LÒNG THỬ LẠI SAU!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void AddNewRowItem(bool result)
        {
            if (result)
                dataGridViewMatHang.AllowUserToAddRows = true;
            else
            {
                dataGridViewMatHang.AllowUserToAddRows = false;
            }



        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                AddNewRowItem(true);
                int newRowIndex =
                dataGridViewMatHang.NewRowIndex;
                dataGridViewMatHang.CurrentCell = dataGridViewMatHang.Rows[newRowIndex].Cells[0];
            }
            catch (Exception)
            {
                XtraMessageBox.Show("HỆ THỐNG ĐÃ XẢY RA LỖI, VUI LÒNG THỬ LẠI SAU!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deleteMatHang();
        }
        private void dataGridViewMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            try
            {
                DataGridViewRow selectedRows = dataGridViewMatHang.Rows[ind];

                //Get data into cellclick dto

                matHang_CellClickDTO.StrMaMH = selectedRows.Cells[0].Value.ToString();
                matHang_CellClickDTO.StrTenMH = selectedRows.Cells[1].Value.ToString();
                matHang_CellClickDTO.DGiaNhap = double.Parse(selectedRows.Cells[2].Value.ToString());
                matHang_CellClickDTO.StrDonGia = (selectedRows.Cells[3].Value.ToString());
                matHang_CellClickDTO.ITonToiDa = int.Parse(selectedRows.Cells[4].Value.ToString());
                matHang_CellClickDTO.ITonToiThieu = int.Parse(selectedRows.Cells[5].Value.ToString());
            }
            catch
            {

            }
        }

        private void dataGridViewMatHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int lastRow = e.RowIndex;
                DataGridViewRow nRow = dataGridViewMatHang.Rows[lastRow];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridViewMatHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            AddNewRowItem(false);

        }
        private void dataGridViewMatHang_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

            AddNewRowItem(true);
            int newRowIndex =
            dataGridViewMatHang.NewRowIndex;

        }
    }
}