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
    public partial class frmThemNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
       
        private int NCCNextID;

        public frmNhaCungCap frmNhaCungCap;

        private NhaCungCapDTO NhaCungCapDTO = new NhaCungCapDTO();
        private NhaCungCapDTO nhaCungCap_CellClickDTO = new NhaCungCapDTO();
        private NhaCungCapBUS NhaCungCapBUS = new NhaCungCapBUS();
        private DataTable nhaCungCapDataTable = new DataTable();
        private List<string> listMaNhaCungCap = new List<string>();
   
        private string sKeyword = string.Empty;

        public frmThemNhaCungCap()
        {
            InitializeComponent();
        }

        public frmThemNhaCungCap(int NhaCungCapNextID)
        {
            InitializeComponent();
            NCCNextID = NhaCungCapNextID;
            setTextToControls();
        }

       
        private void getNewNhaCungCapInfo()
        {
            NhaCungCapDTO.StrMaNhaCungCap = txtMaNCC.Text.ToString();
            NhaCungCapDTO.StrTenNhaCungCap = txtTenNhaCungCap.Text.ToString();
           

        }

       

        private void setTextToControls()
        {
            try
            {
                txtMaNCC.Text = NCCNextID.ToString();

            }

            catch (Exception)
            {
                XtraMessageBox.Show("KHÔNG THỂ LOAD ĐƯỢC DỮ LIỆU", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            getNewNhaCungCapInfo();


            bool re = NhaCungCapBUS.them(NhaCungCapDTO);
               
            if (re )
            {

                XtraMessageBox.Show("THÔNG TIN ĐÃ ĐƯỢC CẬP NHẬT", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    frmNhaCungCap.LoadDanhSachNhaCungCap();
                    frmNhaCungCap.dataGridViewNhaCungCap.Refresh();
                }
                catch (Exception)
                {
                    this.Close();
                }


                this.Close();
            }
            else
            {
                XtraMessageBox.Show("CÓ LỖI XẢY RA, VUI LÒNG THỬ LẠI SAU", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        
    }
}