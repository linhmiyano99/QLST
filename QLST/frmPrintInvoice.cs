using DevComponents.DotNetBar.Controls;
using QLSTDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST
{
    public partial class frmPrintInvoice : Form
    {
        //*************
        private System.Windows.Forms.Label TongCong;
        private System.Windows.Forms.Label TongSo;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label TienNhan;
        private System.Windows.Forms.Label TienTra;
        private System.Windows.Forms.Label EndingTitle;
        private System.Windows.Forms.Label Address;
        //*************
        private string TongTien = string.Empty;
        private string TienKhachDua = string.Empty;
        private string TienTraLai = string.Empty;
        private string TongSoLuong = string.Empty;

        DataTable dataCTHoaDon = new DataTable();
        NhanVienDTO NhanVienHoaDon = new NhanVienDTO();

        private List<Label> ListLabel = new List<Label>();
        private List<string> ListString = new List<string>();

        private int Ypos = 400;
        private string PathName = string.Empty;
        private string soHoaDon = string.Empty;

        public frmPrintInvoice()
        {
            InitializeComponent();
        }

        public frmPrintInvoice(DataGridViewX datagridviewX, NhanVienDTO nhanVienDTO,
               string strTongTien, string strTienKhachDua, string strTienTraLai, string strTongSo,string pathname, string HoaDonID)
        {

            InitializeComponent();

            TongTien = strTongTien;
            TienKhachDua = strTienKhachDua.ToString();
            TienTraLai = strTienTraLai;
            TongSoLuong = strTongSo.ToString();
            dataCTHoaDon = (DataTable)(datagridviewX.DataSource);
            NhanVienHoaDon = nhanVienDTO;
            lbSellerName.Text += " " + nhanVienDTO.StrHoTen;
            PathName = pathname.ToString();
            soHoaDon = HoaDonID.ToString();
            lbInvoiceNum.Text += " " + HoaDonID;

            string timeNow = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            DateTime today = DateTime.Today;
            Date.Text += today.ToShortDateString();
            Time.Text += timeNow;

            lbCompany.Text = "SIÊU THỊ MINI JJADA";
            lbCompanyAddr.Text = "90 Vo Van Ngan - Thu Duc - Hcmc ";
            lbCompanyTel.Text = "0123456789";
            lbBranchAddr.Text = " ";
            lbBranchTel.Text = " ";


        }




        private float getTextSize(string text)
        {
            Font font = new Font("Consolas", 12.0F);
            Image fakeImage = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(fakeImage);
            SizeF size = graphics.MeasureString(text, font);
            return size.Width;
        }

        private void GetDataFromDataGridView()
        {
            foreach (DataRow row in dataCTHoaDon.Rows)
            {
                Label labelCT = new Label();
                string[] temp = new string[5];

                temp[0] = "  "+ row["TenMH"].ToString();
                float temp1 = 0;
                temp1 = float.Parse(row["GiaBan"].ToString());
                temp[1] = temp1.ToString();
                temp[2] = row["SoLuong"].ToString();
                temp1 = float.Parse(row["ThanhTien"].ToString());
                temp[3] = temp1.ToString();
                temp[4] = "       ";

                float size  = getTextSize(temp[0]);
                int width = (int)size;

                if (width < 150)
                {
                    int iTemp = 150 - width;
                    int temp2 = width / temp[0].Length;
                    int index = iTemp / temp2;

                    for(int i = 0;i< index; i++)
                    {
                        temp[0] += " ";
                    }
                }

                if (temp[1].Length < 16)
                {
                    for(int index = 0; index < 16- temp[1].Length; index++)
                    {
                        temp[1] += " ";
                    }
                }
                labelCT.Text = temp[0]+  temp[1]  + temp[2] + temp[4]+"  " + temp[3];
                labelCT.AutoSize = true;
                labelCT.Font = new System.Drawing.Font("Consolas", 12F, FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //ListString.Add(temp);
                ListLabel.Add(labelCT);
            }
        }

        public void AddLabelListToPrintPanel(List<Label> lb)
        {
            for (int i = 0; i < lb.Count; i++)
            {
   
                PrintPanel.Controls.Add(lb[i]);
                lb[i].Location = new Point(20, lb[i].Location.Y + Ypos);
                Ypos += 50;
               // PrintPanel.Controls.Add(CreateSymbolLabel(Ypos+10 ));
            }

            PrintPanel.Controls.Add(CreateSymbolLabel(Ypos-10));
        }
        public Label CreateSymbolLabel(int Y)
        {
            Label lb = new Label();
            lb.AutoSize = true;
            lb.Font = new System.Drawing.Font("Consolas", 9.75F, FontStyle.Regular, 
            System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb.Location = new System.Drawing.Point(20, Y + 20);
            lb.Size = new System.Drawing.Size(413, 15);
            lb.TabIndex = 16;
            lb.Text = "----------------------------------------------------------\r\n";
            return lb;
        }

        private void CreatePrintPanelHeader(int y)
        {


            this.TongCong = new Label();
            this.TienNhan = new System.Windows.Forms.Label();
            this.TienTra = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.TongSo = new System.Windows.Forms.Label();
            this.EndingTitle = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();

            // 
            // TOTAL_
            // 
            this.TongCong.AutoSize = true;
            this.TongCong.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongCong.Location = new System.Drawing.Point(368, y);
            this.TongCong.Name = "TOTAL_";
            this.TongCong.Size = new System.Drawing.Size(0, 22);
            this.TongCong.TabIndex = 15;
            this.TongCong.Text = TongTien.ToString();
            // 
            // TotalQty
            // 
            this.TongSo.AutoSize = true;
            this.TongSo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongSo.Location = new System.Drawing.Point(195, y);
            this.TongSo.Name = "TotalQty";
            this.TongSo.Size = new System.Drawing.Size(0, 22);
            this.TongSo.TabIndex = 13;
            this.TongSo.Text = "       "+ TongSoLuong.ToString();
            // 
            // TOTAL_TITLE
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(20, y);
            this.Title.Name = "TOTAL_TITLE";
            this.Title.Size = new System.Drawing.Size(110, 22);
            this.Title.TabIndex = 12;
            this.Title.Text = "TỔNG CỘNG:";
            //
            //MoneyReceived
            //
            this.TienNhan.AutoSize = true;
            this.TienNhan.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TienNhan.Location = new System.Drawing.Point(20, y + 20);
            this.TienNhan.Name = "TOTAL_TITLE";
            this.TienNhan.Size = new System.Drawing.Size(110, 22);
            this.TienNhan.Text = "TIỀN ĐÃ NHẬN:                      " + TienKhachDua.ToString();
            //
            //EXCESSMONEY
            //

            this.TienTra.AutoSize = true;
            this.TienTra.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TienTra.Location = new System.Drawing.Point(20, y + 40);
            this.TienTra.Name = "ExcessMoney";
            this.TienTra.Size = new System.Drawing.Size(0, 22);
            this.TienTra.TabIndex = 15;
            this.TienTra.Text = "TIỀN TRẢ LẠI:                      " + TienTraLai.ToString();

            PrintPanel.Controls.Add(CreateSymbolLabel(y + 50));

            this.EndingTitle.AutoSize = true;
            this.EndingTitle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndingTitle.Location = new System.Drawing.Point(20, y + 95);
            this.EndingTitle.Name = "EndingTitle";
            this.EndingTitle.Size = new System.Drawing.Size(0, 22);
            this.EndingTitle.TabIndex = 15;
            this.EndingTitle.Text = "    XIN CÁM ƠN VÀ HẸN GẶP LẠI QUÝ KHÁCH";

            //
            //ADDRESS
            //
            y += 60;
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(20, y + 80);
            this.Address.Name = "EndingTitle";
            this.Address.Size = new System.Drawing.Size(0, 22);
            this.Address.TabIndex = 15;
            //this.Address.Text = "       Kp6 - Linh Đông - Thủ Đức - HCM";

            y += 50;

            int Ysize = GetLastLabelLocation(ListLabel);
            if (Ysize >= (PrintPanel.Height - 100))
            {
                PrintPanel.Height += 200;
            }

            PrintPanel.Controls.Add(CreateSymbolLabel(y ));
            this.PrintPanel.Controls.Add(this.TongCong);
            this.PrintPanel.Controls.Add(this.TongSo);
            this.PrintPanel.Controls.Add(this.Title);
            this.PrintPanel.Controls.Add(this.TienNhan);
            this.PrintPanel.Controls.Add(this.TienTra);
            this.PrintPanel.Controls.Add(this.EndingTitle);
            //this.PrintPanel.Controls.Add(this.Address);


        }

        private int GetLastLabelLocation(List<Label> lb_)
        {

            return lb_[lb_.Count - 1].Location.Y;
        }
        private void frmPrintInvoice_Load(object sender, EventArgs e)
        {
            GetDataFromDataGridView();
            AddLabelListToPrintPanel(ListLabel);
            CreatePrintPanelHeader(100 + GetLastLabelLocation(ListLabel));
            PrintPanel.AutoScrollPosition = new Point(0, 0);
            CreateBitmapForPrintPanel(PrintPanel);
        }

        public void DrawControl(Control control, Bitmap bitmap)
        {
            try
            {
                control.DrawToBitmap(bitmap, control.Bounds);
                foreach (Control childControl in control.Controls)
                {
                    DrawControl(childControl, bitmap);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Loi Draw bitmap");
            }
        }

        public void CreateBitmapForPrintPanel(Panel PrintPanel)
        {
            Bitmap bmp = new Bitmap(this.PrintPanel.Width-2, this.PrintPanel.Height);
            SystemInformation.HorizontalScrollBarHeight.ToString();
            this.PrintPanel.DrawToBitmap(bmp, new Rectangle(0, 0, this.PrintPanel.Width +5, this.PrintPanel.Height + 1000));
            foreach (Control control in PrintPanel.Controls)
            {
                DrawControl(control, bmp);
            }

            bmp.Save(PathName+"\\HD"+soHoaDon+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

    }
}
