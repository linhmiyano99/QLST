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
    public partial class frmEditNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap frmNhaCungCap;

        private NhaCungCapDTO NhaCungCapDTO = new NhaCungCapDTO();
        private NhaCungCapDTO nhaCungCap_CellClickDTO = new NhaCungCapDTO();
        private NhaCungCapBUS NhaCungCapBUS = new NhaCungCapBUS();
        private DataTable nhaCungCapDataTable = new DataTable();
        private List<string> listMaNhaCungCap = new List<string>();
        private string sKeyword = string.Empty;

        public frmEditNhaCungCap()
        {
            InitializeComponent();
            
        }

        public frmEditNhaCungCap(NhaCungCapDTO NhaCungCapDTO)
        {
            InitializeComponent();
           
            setTextToControls(NhaCungCapDTO);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getHangEditInfo()
        {
            NhaCungCapDTO.StrMaNhaCungCap = txtMaNCC.Text.ToString();
            NhaCungCapDTO.StrTenNhaCungCap = txtTenNhaCungCap.Text.ToString();
          

        }

        private void setTextToControls(NhaCungCapDTO nhaCungCapDTO)
        {
            try
            {
                txtMaNCC.Text = nhaCungCapDTO.StrMaNhaCungCap;
                txtTenNhaCungCap.Text = nhaCungCapDTO.StrTenNhaCungCap;
             
            }

            catch (Exception)
            {
                XtraMessageBox.Show("KHÔNG THỂ LOAD ĐƯỢC DỮ LIỆU", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getHangEditInfo();
            bool re = NhaCungCapBUS.sua(NhaCungCapDTO);
            if (re)
            {

                XtraMessageBox.Show("THÔNG TIN ĐÃ ĐƯỢC CẬP NHẬT", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNhaCungCap.LoadDanhSachNhaCungCap();
                frmNhaCungCap.dataGridViewNhaCungCap.Refresh();

                this.Close();
            }
            else
            {
                XtraMessageBox.Show("CÓ LỖI XẢY RA, VUI LÒNG THỬ LẠI SAU", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
