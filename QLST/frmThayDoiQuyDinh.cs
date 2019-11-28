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
using QLSTDTO;

namespace QLST
{
    public partial class frmThayDoiQuyDinh : DevExpress.XtraEditors.XtraForm
    {
        ThamSoBUS thamSoBUS = new ThamSoBUS();
        ThamSoDTO thamSoDTO = new ThamSoDTO();
        DataTable thamSoDataTable = new DataTable();

        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
           
        }

        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            getThamSo();
        }

        private void getThamSo()
        {
            thamSoDataTable = thamSoBUS.getThamSo();
            DataRow row = thamSoDataTable.Rows[thamSoDataTable.Rows.Count - 1];

            try
            {
                thamSoDTO.FChietKhauVang = float.Parse(row[1].ToString());
                thamSoDTO.FChietKhauBac = float.Parse(row[2].ToString());
                thamSoDTO.FChietKhauBachKim = float.Parse(row[3].ToString());
                thamSoDTO.DLuongCa = double.Parse(row[4].ToString());

                txtChietKhauHangVang.Text = thamSoDTO.FChietKhauVang.ToString();
                txtChietKhauHangBac.Text = thamSoDTO.FChietKhauBac.ToString();
                txtChietKhauHangBachKim.Text = thamSoDTO.FChietKhauBachKim.ToString();
                txtLuongCa.Text = thamSoDTO.DLuongCa.ToString();

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Đã Có Lỗi Xảy Ra Khi Tải Dữ Liệu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suaThamSo()
        {
            thamSoDTO.FChietKhauVang = float.Parse(txtChietKhauHangVang.Text.ToString());
            thamSoDTO.FChietKhauBac = float.Parse(txtChietKhauHangBac.Text.ToString());
            thamSoDTO.FChietKhauBachKim = float.Parse(txtChietKhauHangBachKim.Text.ToString());
            thamSoDTO.DLuongCa = double.Parse( txtLuongCa.Text.ToString());

            bool re = thamSoBUS.suaThamSo(thamSoDTO);
            if (re)
            {
                XtraMessageBox.Show("Đã Lưu Thay Đổi!", "Notifications!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Đã Có Lỗi Xảy Ra Khi Lưu Thay Đổi!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            suaThamSo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}