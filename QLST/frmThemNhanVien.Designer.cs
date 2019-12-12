namespace QLST
{
    partial class frmThemNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhanVien));
            this.grThongtinNhanVien = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxCV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTongCaLam = new DevExpress.XtraEditors.TextEdit();
            this.txtLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.lbLuong = new DevExpress.XtraEditors.LabelControl();
            this.lbTongCaLam = new DevExpress.XtraEditors.LabelControl();
            this.lbChucVu = new DevExpress.XtraEditors.LabelControl();
            this.lbSDT = new DevExpress.XtraEditors.LabelControl();
            this.lbDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lbHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lbMaNV = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtinNhanVien)).BeginInit();
            this.grThongtinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongCaLam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongtinNhanVien
            // 
            this.grThongtinNhanVien.Controls.Add(this.comboBoxCV);
            this.grThongtinNhanVien.Controls.Add(this.txtTongCaLam);
            this.grThongtinNhanVien.Controls.Add(this.txtLuong);
            this.grThongtinNhanVien.Controls.Add(this.txtSDT);
            this.grThongtinNhanVien.Controls.Add(this.txtDiaChi);
            this.grThongtinNhanVien.Controls.Add(this.txtHoTen);
            this.grThongtinNhanVien.Controls.Add(this.txtMaNV);
            this.grThongtinNhanVien.Controls.Add(this.lbLuong);
            this.grThongtinNhanVien.Controls.Add(this.lbTongCaLam);
            this.grThongtinNhanVien.Controls.Add(this.lbChucVu);
            this.grThongtinNhanVien.Controls.Add(this.lbSDT);
            this.grThongtinNhanVien.Controls.Add(this.lbDiaChi);
            this.grThongtinNhanVien.Controls.Add(this.lbHoTen);
            this.grThongtinNhanVien.Controls.Add(this.lbMaNV);
            this.grThongtinNhanVien.Location = new System.Drawing.Point(12, 12);
            this.grThongtinNhanVien.Name = "grThongtinNhanVien";
            this.grThongtinNhanVien.Size = new System.Drawing.Size(1033, 170);
            this.grThongtinNhanVien.TabIndex = 3;
            this.grThongtinNhanVien.Text = "Thông tin nhân viên";
            // 
            // comboBoxCV
            // 
            this.comboBoxCV.DisplayMember = "Text";
            this.comboBoxCV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCV.FormattingEnabled = true;
            this.comboBoxCV.ItemHeight = 16;
            this.comboBoxCV.Location = new System.Drawing.Point(488, 34);
            this.comboBoxCV.Name = "comboBoxCV";
            this.comboBoxCV.Size = new System.Drawing.Size(206, 22);
            this.comboBoxCV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxCV.TabIndex = 18;
            // 
            // txtTongCaLam
            // 
            this.txtTongCaLam.Location = new System.Drawing.Point(863, 30);
            this.txtTongCaLam.Name = "txtTongCaLam";
            this.txtTongCaLam.Properties.Mask.EditMask = "n0";
            this.txtTongCaLam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTongCaLam.Size = new System.Drawing.Size(148, 20);
            this.txtTongCaLam.TabIndex = 17;
            this.txtTongCaLam.Visible = false;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(488, 132);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(206, 20);
            this.txtLuong.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(488, 84);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtSDT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtSDT.Size = new System.Drawing.Size(206, 20);
            this.txtSDT.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(126, 132);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(217, 20);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(126, 83);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(217, 20);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(126, 33);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Mask.EditMask = "n0";
            this.txtMaNV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMaNV.Size = new System.Drawing.Size(217, 20);
            this.txtMaNV.TabIndex = 9;
            // 
            // lbLuong
            // 
            this.lbLuong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuong.Appearance.Options.UseFont = true;
            this.lbLuong.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbLuong.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbLuong.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbLuong.Location = new System.Drawing.Point(361, 135);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(49, 16);
            this.lbLuong.TabIndex = 8;
            this.lbLuong.Text = "Lương: ";
            // 
            // lbTongCaLam
            // 
            this.lbTongCaLam.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongCaLam.Appearance.Options.UseFont = true;
            this.lbTongCaLam.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbTongCaLam.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbTongCaLam.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbTongCaLam.LineVisible = true;
            this.lbTongCaLam.Location = new System.Drawing.Point(720, 33);
            this.lbTongCaLam.Name = "lbTongCaLam";
            this.lbTongCaLam.Size = new System.Drawing.Size(115, 16);
            this.lbTongCaLam.TabIndex = 6;
            this.lbTongCaLam.Text = "Tổng ca làm việc: ";
            this.lbTongCaLam.Visible = false;
            // 
            // lbChucVu
            // 
            this.lbChucVu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.Appearance.Options.UseFont = true;
            this.lbChucVu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbChucVu.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbChucVu.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbChucVu.LineVisible = true;
            this.lbChucVu.Location = new System.Drawing.Point(361, 34);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(57, 16);
            this.lbChucVu.TabIndex = 4;
            this.lbChucVu.Text = "Chức vụ:";
            // 
            // lbSDT
            // 
            this.lbSDT.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Appearance.Options.UseFont = true;
            this.lbSDT.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbSDT.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbSDT.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbSDT.LineVisible = true;
            this.lbSDT.Location = new System.Drawing.Point(361, 86);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(89, 16);
            this.lbSDT.TabIndex = 3;
            this.lbSDT.Text = "Số điện thoại:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Appearance.Options.UseFont = true;
            this.lbDiaChi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbDiaChi.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbDiaChi.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbDiaChi.LineVisible = true;
            this.lbDiaChi.Location = new System.Drawing.Point(23, 136);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(48, 16);
            this.lbDiaChi.TabIndex = 2;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Appearance.Options.UseFont = true;
            this.lbHoTen.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbHoTen.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbHoTen.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbHoTen.LineVisible = true;
            this.lbHoTen.Location = new System.Drawing.Point(21, 87);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(99, 16);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Tên nhân viên: ";
            // 
            // lbMaNV
            // 
            this.lbMaNV.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Appearance.Options.UseFont = true;
            this.lbMaNV.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbMaNV.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbMaNV.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbMaNV.LineVisible = true;
            this.lbMaNV.Location = new System.Drawing.Point(23, 34);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(95, 16);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã nhân viên: ";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(875, 198);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(971, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 233);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grThongtinNhanVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemNhanVien";
            this.Text = "Thêm Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.grThongtinNhanVien)).EndInit();
            this.grThongtinNhanVien.ResumeLayout(false);
            this.grThongtinNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongCaLam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grThongtinNhanVien;
        private DevExpress.XtraEditors.TextEdit txtTongCaLam;
        private DevExpress.XtraEditors.TextEdit txtLuong;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.LabelControl lbLuong;
        private DevExpress.XtraEditors.LabelControl lbTongCaLam;
        private DevExpress.XtraEditors.LabelControl lbChucVu;
        private DevExpress.XtraEditors.LabelControl lbSDT;
        private DevExpress.XtraEditors.LabelControl lbDiaChi;
        private DevExpress.XtraEditors.LabelControl lbHoTen;
        private DevExpress.XtraEditors.LabelControl lbMaNV;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxCV;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}