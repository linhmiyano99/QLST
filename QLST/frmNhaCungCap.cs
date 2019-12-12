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
    public partial class frmNhaCungCap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private NhaCungCapDTO NhaCungCapDTO = new NhaCungCapDTO();
        private NhaCungCapDTO nhaCungCap_CellClickDTO = new NhaCungCapDTO();
        private NhaCungCapBUS NhaCungCapBUS = new NhaCungCapBUS();
        private DataTable nhaCungCapDataTable = new DataTable();
        private List<string> listMaNhaCungCap = new List<string>();
        private DataTable dataTableUpdateTemp;
        private DataTable dataTableInsertTemp;
        private string sKeyword = string.Empty;
        private int MaNCCNextID = 0;

        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {

            LoadDanhSachNhaCungCap();
            getListMaNhaCungCap();
            SelectedRowsDefault();

            dataGridViewNhaCungCap.CurrentCell = dataGridViewNhaCungCap.Rows[0].Cells[0];
            nhaCungCapDataTable = InitNCCDataTable("NhaCungCapDataTable");
            dataTableUpdateTemp = InitNCCDataTable("dataTableUpdateTemp");
            dataTableInsertTemp = InitNCCDataTable("dataTableInsertTemp");
        }




        #region DATA_BINDING
        /*
         * Binding Data vào UI và xử lý các tác vụ liên quan đến database
         */
        public void LoadDanhSachNhaCungCap()
        {
            //List<NhaCungCapDTO> listHang = NhaCungCapBUS.getListDanhSachHang();
            nhaCungCapDataTable = NhaCungCapBUS.GetDataTableHang();

            if (nhaCungCapDataTable == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewNhaCungCap.Columns.Clear();
            dataGridViewNhaCungCap.DataSource = null;

            dataGridViewNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNhaCungCap.AutoGenerateColumns = false;
            //dataGridViewNhaCungCap.AllowUserToAddRows = false;


            dataGridViewNhaCungCap.DataSource = nhaCungCapDataTable;
            CreatedataGridViewNhaCungCap();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewNhaCungCap.DataSource];
            myCurrencyManager.Refresh();

        }


        private void LoadDanhSachNhaCungCapByKey(DataTable dataNhaCungCap)
        {

            if (dataNhaCungCap == null)
            {
                XtraMessageBox.Show("ĐÃ CÓ LỖI XẢY RA KHI TẢI DỮ LIỆU!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dataGridViewNhaCungCap.Columns.Clear();
            dataGridViewNhaCungCap.DataSource = null;

            dataGridViewNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNhaCungCap.AutoGenerateColumns = false;
            //dataGridViewNhaCungCap.AllowUserToAddRows = false;

            dataGridViewNhaCungCap.DataSource = dataNhaCungCap;
            CreatedataGridViewNhaCungCap();
            // dgvLoadSach.Sort(dgvLoadSach.Columns[0], ListSortDirection.Ascending);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewNhaCungCap.DataSource];
            myCurrencyManager.Refresh();

        }

        private DataTable InitNCCDataTable(string dataTableName)
        {
            DataTable dataTable = new DataTable(dataTableName);
            dataTable.Columns.Add("MaNCC");
            dataTable.Columns.Add("TenNCC");
            return dataTable;
        }

        private void getListMaNhaCungCap()
        {
            foreach (DataRow row in nhaCungCapDataTable.Rows)
            {
                listMaNhaCungCap.Add(row["MaNCC"].ToString());

            }
            MaNCCNextID = int.Parse(listMaNhaCungCap[listMaNhaCungCap.Count - 1] + 1);
        }

      
        #endregion

        #region UI FORMAT


        private void CreatedataGridViewNhaCungCap()
        {

            DataGridViewTextBoxColumn MaNCC = new DataGridViewTextBoxColumn();
            MaNCC.Name = "MaNCC";
            MaNCC.HeaderText = "Mã Nhà Cung Cấp";
            MaNCC.DataPropertyName = "MaNCC";
            // MaPM.Width = (dgvThemSach_frmMuon.Width / 4) / 3;
            dataGridViewNhaCungCap.Columns.Add(MaNCC);


            DataGridViewTextBoxColumn TenNCC = new DataGridViewTextBoxColumn();
            TenNCC.Name = "TenNCC";
            TenNCC.HeaderText = "Tên Nhà Cung Cấp Sản Phẩm";
            TenNCC.DataPropertyName = "TenNCC";
            //MaDG.Width = ((dgvThemSach_frmMuon.Width - 3 * (MaSach.Width)) - 25);
            dataGridViewNhaCungCap.Columns.Add(TenNCC);



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
            dataGridViewNhaCungCap.Columns.Add(colButtonEdit);

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

            dataGridViewNhaCungCap.Columns.Add(colButtonDelete);

        }


        #endregion

        #region MAPPING_BUS

        private int themNhaCungCap(NhaCungCapDTO NhaCungCapDTO)
        {
            bool re = NhaCungCapBUS.them(NhaCungCapDTO);
            return (re == true ? 1 : 0);
        }

        private int updateNhaCungCap(NhaCungCapDTO NhaCungCapDTO)
        {
            bool re = NhaCungCapBUS.sua(NhaCungCapDTO);
            return (re == true ? 1 : 0);
        }
        #endregion

        private void timKiem()
        {
            sKeyword = txtSearch.Text.Trim();
            DataTable dataNhaCungCap = NhaCungCapBUS.GetDataTableNhaCungCapByKey(sKeyword);

            if (sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0)
            {
                this.LoadDanhSachNhaCungCap();

            }
            else
            {
                dataGridViewNhaCungCap.DataSource = dataNhaCungCap;
                dataGridViewNhaCungCap.Refresh();
                dataGridViewNhaCungCap.Update();

            }
        }




        private void deleteNhaCungCap()
        {
            //Tạo List string chứ 
            List<string> selectedRowsID = new List<string>();

            //add MaKH của những row đang được select vào List
            foreach (DataGridViewRow row in dataGridViewNhaCungCap.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                selectedRowsID.Add(id);
            }

            //1. Map data from GUI
            NhaCungCapDTO NhaCungCapDTO = new NhaCungCapDTO();

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
                        NhaCungCapDTO.StrMaNhaCungCap = strID;

                        //2.Kiem tra tren tang database
                        bool result = NhaCungCapBUS.xoa(NhaCungCapDTO);
                        if (result == false)
                        {
                            XtraMessageBox.Show("XẢY RA LỖI KHI XÓA DỮ LIỆU!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    LoadDanhSachNhaCungCap();
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


     
        #endregion

        /*
         * Hàm này trả data về cho 2 data table " dataTableUpdateTemp && dataTableInsertTemp"
         * Nếu data trả về có MaKH đã tồn tại trong database thì data sẽ được trả về cho dataTableUpdateTemp để
         * thực hiện việc update và ngược lại.
         * 
         */

    
        private void buttonEditClick(object sender, EventArgs e)
        {
            frmEditNhaCungCap frmEdit = new frmEditNhaCungCap(nhaCungCap_CellClickDTO);
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
            LoadDanhSachNhaCungCap();
            dataGridViewNhaCungCap.Refresh();
            dataGridViewNhaCungCap.Update();

        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            deleteNhaCungCap();
        }



        private void SelectedRowsDefault()
        {

            try
            {
                DataGridViewRow selectedRows = dataGridViewNhaCungCap.Rows[0];

                //Get data into cellclick dto

                nhaCungCap_CellClickDTO.StrMaNhaCungCap = selectedRows.Cells[0].Value.ToString();
                nhaCungCap_CellClickDTO.StrTenNhaCungCap = selectedRows.Cells[1].Value.ToString();


                //get data to text

                txtMaNCC.Text = selectedRows.Cells[0].Value.ToString();
                txtTenNCC.Text = selectedRows.Cells[1].Value.ToString();

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



        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemNhaCungCap frmEdit = new frmThemNhaCungCap(MaNCCNextID);
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
            dataGridViewNhaCungCap.Refresh();
            dataGridViewNhaCungCap.Update();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deleteNhaCungCap();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXuatThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void dataGridViewNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int ind = e.RowIndex;
            try
            {
                DataGridViewRow selectedRows = dataGridViewNhaCungCap.Rows[ind];
                //Get data into cellclick dto

                nhaCungCap_CellClickDTO.StrMaNhaCungCap = selectedRows.Cells[0].Value.ToString();
                nhaCungCap_CellClickDTO.StrTenNhaCungCap = selectedRows.Cells[1].Value.ToString();

                //get data to text

                txtMaNCC.Text = selectedRows.Cells[0].Value.ToString();
                txtTenNCC.Text = selectedRows.Cells[1].Value.ToString();

            }
            catch
            {
                Console.WriteLine("CellClick can not bound data!");
            }

        }
    }
}