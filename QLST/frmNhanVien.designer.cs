namespace QLST
{
    partial class frmNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grThongtinNhanVien = new DevExpress.XtraEditors.GroupControl();
            this.txtTongCaLam = new DevExpress.XtraEditors.TextEdit();
            this.txtLuongCa = new DevExpress.XtraEditors.TextEdit();
            this.txtLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtChucVu = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.lbLuong = new DevExpress.XtraEditors.LabelControl();
            this.lbTongCaLam = new DevExpress.XtraEditors.LabelControl();
            this.lbLuongCa = new DevExpress.XtraEditors.LabelControl();
            this.lbChucVu = new DevExpress.XtraEditors.LabelControl();
            this.lbSDT = new DevExpress.XtraEditors.LabelControl();
            this.lbDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lbHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lbMaNV = new DevExpress.XtraEditors.LabelControl();
            this.lbSearch = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.dataGridViewNhanVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtinNhanVien)).BeginInit();
            this.grThongtinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongCaLam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnThem,
            this.btnXoa,
            this.btnLuu,
            this.btnXuatThongTin});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1071, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm Nhân Viên";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = global::QLST.Properties.Resources.addfile_16x16;
            this.btnThem.ImageOptions.LargeImage = global::QLST.Properties.Resources.addfile_32x321;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa Nhân Viên";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::QLST.Properties.Resources.delete_16x16;
            this.btnXoa.ImageOptions.LargeImage = global::QLST.Properties.Resources.delete_32x32;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu Thay Đổi";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = global::QLST.Properties.Resources.save_16x16;
            this.btnLuu.ImageOptions.LargeImage = global::QLST.Properties.Resources.save_32x32;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnXuatThongTin
            // 
            this.btnXuatThongTin.Caption = "Xuất thông tin";
            this.btnXuatThongTin.Id = 4;
            this.btnXuatThongTin.ImageOptions.Image = global::QLST.Properties.Resources.exporttopdf_16x16;
            this.btnXuatThongTin.ImageOptions.LargeImage = global::QLST.Properties.Resources.exporttopdf_32x321;
            this.btnXuatThongTin.Name = "btnXuatThongTin";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThem, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnXoa, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thao tác";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLuu, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Lưu trữ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnXuatThongTin, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Xuất file";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 618);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1071, 31);
            // 
            // grThongtinNhanVien
            // 
            this.grThongtinNhanVien.Controls.Add(this.txtTongCaLam);
            this.grThongtinNhanVien.Controls.Add(this.txtLuongCa);
            this.grThongtinNhanVien.Controls.Add(this.txtLuong);
            this.grThongtinNhanVien.Controls.Add(this.txtSDT);
            this.grThongtinNhanVien.Controls.Add(this.txtDiaChi);
            this.grThongtinNhanVien.Controls.Add(this.txtChucVu);
            this.grThongtinNhanVien.Controls.Add(this.txtHoTen);
            this.grThongtinNhanVien.Controls.Add(this.txtMaNV);
            this.grThongtinNhanVien.Controls.Add(this.lbLuong);
            this.grThongtinNhanVien.Controls.Add(this.lbTongCaLam);
            this.grThongtinNhanVien.Controls.Add(this.lbLuongCa);
            this.grThongtinNhanVien.Controls.Add(this.lbChucVu);
            this.grThongtinNhanVien.Controls.Add(this.lbSDT);
            this.grThongtinNhanVien.Controls.Add(this.lbDiaChi);
            this.grThongtinNhanVien.Controls.Add(this.lbHoTen);
            this.grThongtinNhanVien.Controls.Add(this.lbMaNV);
            this.grThongtinNhanVien.Location = new System.Drawing.Point(18, 149);
            this.grThongtinNhanVien.Name = "grThongtinNhanVien";
            this.grThongtinNhanVien.Size = new System.Drawing.Size(1033, 170);
            this.grThongtinNhanVien.TabIndex = 2;
            this.grThongtinNhanVien.Text = "Thông tin nhân viên";
            // 
            // txtTongCaLam
            // 
            this.txtTongCaLam.Location = new System.Drawing.Point(863, 30);
            this.txtTongCaLam.MenuManager = this.ribbon;
            this.txtTongCaLam.Name = "txtTongCaLam";
            this.txtTongCaLam.Size = new System.Drawing.Size(148, 20);
            this.txtTongCaLam.TabIndex = 17;
            // 
            // txtLuongCa
            // 
            this.txtLuongCa.Location = new System.Drawing.Point(863, 83);
            this.txtLuongCa.MenuManager = this.ribbon;
            this.txtLuongCa.Name = "txtLuongCa";
            this.txtLuongCa.Size = new System.Drawing.Size(148, 20);
            this.txtLuongCa.TabIndex = 16;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(863, 132);
            this.txtLuong.MenuManager = this.ribbon;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(148, 20);
            this.txtLuong.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(488, 84);
            this.txtSDT.MenuManager = this.ribbon;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(206, 20);
            this.txtSDT.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(126, 132);
            this.txtDiaChi.MenuManager = this.ribbon;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(364, 20);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(488, 33);
            this.txtChucVu.MenuManager = this.ribbon;
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(206, 20);
            this.txtChucVu.TabIndex = 11;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(126, 83);
            this.txtHoTen.MenuManager = this.ribbon;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(217, 20);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(126, 33);
            this.txtMaNV.MenuManager = this.ribbon;
            this.txtMaNV.Name = "txtMaNV";
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
            this.lbLuong.Location = new System.Drawing.Point(720, 133);
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
            // 
            // lbLuongCa
            // 
            this.lbLuongCa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuongCa.Appearance.Options.UseFont = true;
            this.lbLuongCa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbLuongCa.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbLuongCa.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbLuongCa.LineVisible = true;
            this.lbLuongCa.Location = new System.Drawing.Point(720, 87);
            this.lbLuongCa.Name = "lbLuongCa";
            this.lbLuongCa.Size = new System.Drawing.Size(68, 16);
            this.lbLuongCa.TabIndex = 5;
            this.lbLuongCa.Text = "Lương ca: ";
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
            // lbSearch
            // 
            this.lbSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Appearance.Options.UseFont = true;
            this.lbSearch.LineVisible = true;
            this.lbSearch.Location = new System.Drawing.Point(354, 88);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(41, 13);
            this.lbSearch.TabIndex = 21;
            this.lbSearch.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(419, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNhanVien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNhanVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(18, 325);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(1033, 287);
            this.dataGridViewNhanVien.TabIndex = 22;
            this.dataGridViewNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellClick);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 649);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grThongtinNhanVien);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmNhanVien";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtinNhanVien)).EndInit();
            this.grThongtinNhanVien.ResumeLayout(false);
            this.grThongtinNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongCaLam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnXuatThongTin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.GroupControl grThongtinNhanVien;
        private DevExpress.XtraEditors.LabelControl lbLuong;
        private DevExpress.XtraEditors.LabelControl lbTongCaLam;
        private DevExpress.XtraEditors.LabelControl lbLuongCa;
        private DevExpress.XtraEditors.LabelControl lbChucVu;
        private DevExpress.XtraEditors.LabelControl lbSDT;
        private DevExpress.XtraEditors.LabelControl lbDiaChi;
        private DevExpress.XtraEditors.LabelControl lbHoTen;
        private DevExpress.XtraEditors.LabelControl lbMaNV;
        private DevExpress.XtraEditors.TextEdit txtTongCaLam;
        private DevExpress.XtraEditors.TextEdit txtLuongCa;
        private DevExpress.XtraEditors.TextEdit txtLuong;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtChucVu;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.LabelControl lbSearch;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        public DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewNhanVien;
    }
}