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
    public partial class frmEditMatHang : Form
    {
        public frmMatHang frmMH;

        MatHangDTO matHang = new MatHangDTO();
        MatHangBUS matHangBUS = new MatHangBUS();


        public frmEditMatHang()
        {
            InitializeComponent();
        }
        public frmEditMatHang(MatHangDTO matHang)
        {
            InitializeComponent();
            setTextToControls(matHang);
        }

        private void frmEditMatHang_Load(object sender, EventArgs e)
        {
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getMatHangEditInfo()
        {
            matHang.StrMaMH = txtMaMH.Text.ToString();
            matHang.StrTenMH = txtTenMH.Text.ToString();
            matHang.DGiaNhap = double.Parse(txtGiaNhap.Text.ToString());
            matHang.StrDonGia = txtGiaBan.Text.ToString();
            matHang.ITonToiDa = int.Parse(txtTonToiDa.Text.ToString());
            matHang.ITonToiThieu = int.Parse(txtTonToiThieu.Text.ToString());
        }

        private void setTextToControls(MatHangDTO matHang)
        {
            try
            {
                
                txtMaMH.Text = matHang.StrMaMH;
                txtTenMH.Text = matHang.StrTenMH;
                txtGiaNhap.Text = matHang.DGiaNhap.ToString();
                txtGiaBan.Text = matHang.StrDonGia;
                txtTonToiDa.Text = matHang.ITonToiDa.ToString();
                txtTonToiThieu.Text = matHang.ITonToiThieu.ToString();
            }

            catch (Exception)
            {
                XtraMessageBox.Show("KHÔNG THỂ LOAD ĐƯỢC DỮ LIỆU", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            getMatHangEditInfo();
            bool re = matHangBUS.sua(matHang);
            if (re)
            {

                XtraMessageBox.Show("THÔNG TIN ĐÃ ĐƯỢC CẬP NHẬT", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMH.loadDanhSachMatHang();
                frmMH.dataGridViewMatHang.Refresh();

                this.Close();
            }
            else
            {
                XtraMessageBox.Show("CÓ LỖI XẢY RA, VUI LÒNG THỬ LẠI SAU", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
