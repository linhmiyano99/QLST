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
using QLSTBUS;

namespace QLST
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        List<string> TenTk;
        LoginBUS loginBUS = new LoginBUS();
        public frmDangNhap()
        {
            InitializeComponent();
            TenTk = new List<string>();
            btnDangNhap.Focus();
          
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (loginBUS.IsValid(txtUserName.Text, txtPassword.Text))
            {
                DataTable data = new DataTable();
                data = loginBUS.GetAccountType(txtUserName.Text);
                int MaChucVu = 0;
                int MaNV = 0;

                foreach (DataRow row in data.Rows)
                {
                    MaChucVu = int.Parse(row["MaChucVu"].ToString());
                    MaNV = int.Parse(row["MaNV"].ToString());

                }
                frmMainForm frmMain = new frmMainForm(MaChucVu, MaNV);
                this.Hide();
           
                frmMain.Show();
                this.Hide();
            }
            else
            {
                if(string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    XtraMessageBox.Show("TÊN TÀI KHOẢN HOẶC MẬT KHẨU KHÔNG ĐÚNG! ", "Notificantions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}