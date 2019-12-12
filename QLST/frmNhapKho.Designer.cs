namespace QLST
{
    partial class frmNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapKho));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemThem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemXuatPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemThuMuc = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lbSearch = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.grThongTinHoaDon = new DevExpress.XtraEditors.GroupControl();
            this.txtGio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMaMH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNhaCungCap = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgay = new DevExpress.XtraEditors.TextEdit();
            this.lbNgay = new DevExpress.XtraEditors.LabelControl();
            this.txtNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.lbThuNgan = new DevExpress.XtraEditors.LabelControl();
            this.txtMaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.lbSoHoaDon = new DevExpress.XtraEditors.LabelControl();
            this.dataGridViewChiTietPhieuNhapKho = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.PrintPath = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txtTienTongCong = new DevExpress.XtraEditors.TextEdit();
            this.lbTongCong = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinHoaDon)).BeginInit();
            this.grThongTinHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienTongCong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItemThem,
            this.barButtonItemXoa,
            this.barButtonItemLuu,
            this.barButtonItemXuatPhieu,
            this.barButtonItemThuMuc});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1249, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItemThem
            // 
            this.barButtonItemThem.Caption = "Thêm Mới Phiếu Nhập Kho";
            this.barButtonItemThem.Id = 1;
            this.barButtonItemThem.ImageOptions.Image = global::QLST.Properties.Resources.addfile_16x162;
            this.barButtonItemThem.ImageOptions.LargeImage = global::QLST.Properties.Resources.addfile_32x325;
            this.barButtonItemThem.Name = "barButtonItemThem";
            this.barButtonItemThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemThem_ItemClick);
            // 
            // barButtonItemXoa
            // 
            this.barButtonItemXoa.Caption = "Xóa Mặt Hàng";
            this.barButtonItemXoa.Id = 2;
            this.barButtonItemXoa.ImageOptions.Image = global::QLST.Properties.Resources.delete_16x161;
            this.barButtonItemXoa.ImageOptions.LargeImage = global::QLST.Properties.Resources.delete_32x323;
            this.barButtonItemXoa.Name = "barButtonItemXoa";
            this.barButtonItemXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemXoa_ItemClick);
            // 
            // barButtonItemLuu
            // 
            this.barButtonItemLuu.Caption = "Lưu Thông Tin";
            this.barButtonItemLuu.Id = 3;
            this.barButtonItemLuu.ImageOptions.Image = global::QLST.Properties.Resources.save_16x162;
            this.barButtonItemLuu.ImageOptions.LargeImage = global::QLST.Properties.Resources.save_32x322;
            this.barButtonItemLuu.Name = "barButtonItemLuu";
            this.barButtonItemLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemLuu_ItemClick);
            // 
            // barButtonItemXuatPhieu
            // 
            this.barButtonItemXuatPhieu.Caption = "Xuất Phiếu Nhập Kho";
            this.barButtonItemXuatPhieu.Id = 4;
            this.barButtonItemXuatPhieu.ImageOptions.Image = global::QLST.Properties.Resources.exporttopdf_16x164;
            this.barButtonItemXuatPhieu.ImageOptions.LargeImage = global::QLST.Properties.Resources.exporttopdf_32x326;
            this.barButtonItemXuatPhieu.Name = "barButtonItemXuatPhieu";
            this.barButtonItemXuatPhieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemXuatPhieu_ItemClick);
            // 
            // barButtonItemThuMuc
            // 
            this.barButtonItemThuMuc.Caption = "Chọn Thư Mục Lưu Trữ";
            this.barButtonItemThuMuc.Id = 6;
            this.barButtonItemThuMuc.ImageOptions.SvgImage = global::QLST.Properties.Resources.open;
            this.barButtonItemThuMuc.Name = "barButtonItemThuMuc";
            this.barButtonItemThuMuc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemThuMuc_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup6});
            this.ribbonPage1.ImageOptions.SvgImage = global::QLST.Properties.Resources.bo_appointment1;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao Tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemThem);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemXoa);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thêm Mới";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemLuu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Lưu Thông Tin";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemXuatPhieu);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Xuất Phiếu Nhập Kho";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItemThuMuc);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Thư Mục";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 617);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1249, 31);
            // 
            // lbSearch
            // 
            this.lbSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Appearance.Options.UseFont = true;
            this.lbSearch.LineVisible = true;
            this.lbSearch.Location = new System.Drawing.Point(478, 110);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(41, 13);
            this.lbSearch.TabIndex = 21;
            this.lbSearch.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(537, 107);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 20);
            this.txtSearch.TabIndex = 20;
            // 
            // grThongTinHoaDon
            // 
            this.grThongTinHoaDon.Controls.Add(this.txtGio);
            this.grThongTinHoaDon.Controls.Add(this.labelControl3);
            this.grThongTinHoaDon.Controls.Add(this.cmbMaMH);
            this.grThongTinHoaDon.Controls.Add(this.labelControl2);
            this.grThongTinHoaDon.Controls.Add(this.cmbNhaCungCap);
            this.grThongTinHoaDon.Controls.Add(this.labelControl1);
            this.grThongTinHoaDon.Controls.Add(this.txtNgay);
            this.grThongTinHoaDon.Controls.Add(this.lbNgay);
            this.grThongTinHoaDon.Controls.Add(this.txtNhanVien);
            this.grThongTinHoaDon.Controls.Add(this.lbThuNgan);
            this.grThongTinHoaDon.Controls.Add(this.txtMaPhieu);
            this.grThongTinHoaDon.Controls.Add(this.lbSoHoaDon);
            this.grThongTinHoaDon.Location = new System.Drawing.Point(12, 168);
            this.grThongTinHoaDon.Name = "grThongTinHoaDon";
            this.grThongTinHoaDon.Size = new System.Drawing.Size(1225, 141);
            this.grThongTinHoaDon.TabIndex = 24;
            this.grThongTinHoaDon.Text = "Thông tin phiếu nhập";
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(788, 97);
            this.txtGio.MenuManager = this.ribbon;
            this.txtGio.Name = "txtGio";
            this.txtGio.Properties.ReadOnly = true;
            this.txtGio.Size = new System.Drawing.Size(185, 20);
            this.txtGio.TabIndex = 19;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(729, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(19, 16);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Giờ";
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaMH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaMH.DisplayMember = "Text";
            this.cmbMaMH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.ItemHeight = 16;
            this.cmbMaMH.Location = new System.Drawing.Point(502, 92);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(185, 22);
            this.cmbMaMH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbMaMH.TabIndex = 17;
            this.cmbMaMH.SelectedIndexChanged += new System.EventHandler(this.cmbMaMH_SelectedIndexChanged_1);
            this.cmbMaMH.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmbMaMH_PreviewKeyDown_1);
            this.cmbMaMH.Validated += new System.EventHandler(this.cmbMaMH_Validated);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(402, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 16);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Mã Mặt Hàng";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNhaCungCap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNhaCungCap.DisplayMember = "Text";
            this.cmbNhaCungCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.ItemHeight = 16;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(175, 90);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(165, 22);
            this.cmbNhaCungCap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbNhaCungCap.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 92);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 16);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Nhà Cung Cấp";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(788, 47);
            this.txtNgay.MenuManager = this.ribbon;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(185, 20);
            this.txtNgay.TabIndex = 13;
            // 
            // lbNgay
            // 
            this.lbNgay.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Appearance.Options.UseFont = true;
            this.lbNgay.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbNgay.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbNgay.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbNgay.LineVisible = true;
            this.lbNgay.Location = new System.Drawing.Point(729, 48);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(41, 16);
            this.lbNgay.TabIndex = 6;
            this.lbNgay.Text = "Ngày: ";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(175, 45);
            this.txtNhanVien.MenuManager = this.ribbon;
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Properties.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(165, 20);
            this.txtNhanVien.TabIndex = 3;
            // 
            // lbThuNgan
            // 
            this.lbThuNgan.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuNgan.Appearance.Options.UseFont = true;
            this.lbThuNgan.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbThuNgan.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbThuNgan.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbThuNgan.LineVisible = true;
            this.lbThuNgan.Location = new System.Drawing.Point(15, 46);
            this.lbThuNgan.Name = "lbThuNgan";
            this.lbThuNgan.Size = new System.Drawing.Size(128, 16);
            this.lbThuNgan.TabIndex = 2;
            this.lbThuNgan.Text = "Nhân Viên Nhập Kho";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(502, 45);
            this.txtMaPhieu.MenuManager = this.ribbon;
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Properties.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(185, 20);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // lbSoHoaDon
            // 
            this.lbSoHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoHoaDon.Appearance.Options.UseFont = true;
            this.lbSoHoaDon.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbSoHoaDon.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbSoHoaDon.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbSoHoaDon.LineVisible = true;
            this.lbSoHoaDon.Location = new System.Drawing.Point(402, 46);
            this.lbSoHoaDon.Name = "lbSoHoaDon";
            this.lbSoHoaDon.Size = new System.Drawing.Size(58, 16);
            this.lbSoHoaDon.TabIndex = 0;
            this.lbSoHoaDon.Text = "Mã Phiếu";
            // 
            // dataGridViewChiTietPhieuNhapKho
            // 
            this.dataGridViewChiTietPhieuNhapKho.AllowUserToAddRows = false;
            this.dataGridViewChiTietPhieuNhapKho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewChiTietPhieuNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewChiTietPhieuNhapKho.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChiTietPhieuNhapKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewChiTietPhieuNhapKho.Location = new System.Drawing.Point(12, 315);
            this.dataGridViewChiTietPhieuNhapKho.Name = "dataGridViewChiTietPhieuNhapKho";
            this.dataGridViewChiTietPhieuNhapKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTietPhieuNhapKho.Size = new System.Drawing.Size(1225, 297);
            this.dataGridViewChiTietPhieuNhapKho.TabIndex = 25;
            this.dataGridViewChiTietPhieuNhapKho.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiTietPhieuNhapKho_CellLeave);
            // 
            // PrintPath
            // 
            this.PrintPath.Name = "PrintPath";
            this.PrintPath.Text = "Nơi Lưu Trữ Hóa Đơn";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Nơi Lưu Trữ Hóa Đơn";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Nơi Lưu Trữ Hóa Đơn";
            // 
            // txtTienTongCong
            // 
            this.txtTienTongCong.Location = new System.Drawing.Point(1020, 101);
            this.txtTienTongCong.MenuManager = this.ribbon;
            this.txtTienTongCong.Name = "txtTienTongCong";
            this.txtTienTongCong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienTongCong.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtTienTongCong.Properties.Appearance.Options.UseFont = true;
            this.txtTienTongCong.Properties.Appearance.Options.UseForeColor = true;
            this.txtTienTongCong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTienTongCong.Properties.ReadOnly = true;
            this.txtTienTongCong.Size = new System.Drawing.Size(217, 26);
            this.txtTienTongCong.TabIndex = 28;
            // 
            // lbTongCong
            // 
            this.lbTongCong.BackColor = System.Drawing.SystemColors.ControlLight;
            // 
            // 
            // 
            this.lbTongCong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTongCong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongCong.ForeColor = System.Drawing.Color.Red;
            this.lbTongCong.Location = new System.Drawing.Point(910, 93);
            this.lbTongCong.Name = "lbTongCong";
            this.lbTongCong.SingleLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTongCong.Size = new System.Drawing.Size(104, 41);
            this.lbTongCong.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lbTongCong.TabIndex = 27;
            this.lbTongCong.Text = "Tổng Cộng:";
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 648);
            this.ControlBox = false;
            this.Controls.Add(this.txtTienTongCong);
            this.Controls.Add(this.lbTongCong);
            this.Controls.Add(this.dataGridViewChiTietPhieuNhapKho);
            this.Controls.Add(this.grThongTinHoaDon);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhapKho";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phiếu Nhập Kho";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinHoaDon)).EndInit();
            this.grThongTinHoaDon.ResumeLayout(false);
            this.grThongTinHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienTongCong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemThem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemXoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLuu;
        private DevExpress.XtraBars.BarButtonItem barButtonItemXuatPhieu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.LabelControl lbSearch;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.GroupControl grThongTinHoaDon;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNhaCungCap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNgay;
        private DevExpress.XtraEditors.LabelControl lbNgay;
        private DevExpress.XtraEditors.TextEdit txtNhanVien;
        private DevExpress.XtraEditors.LabelControl lbThuNgan;
        private DevExpress.XtraEditors.TextEdit txtMaPhieu;
        private DevExpress.XtraEditors.LabelControl lbSoHoaDon;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewChiTietPhieuNhapKho;
        private DevExpress.XtraBars.BarButtonItem barButtonItemThuMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PrintPath;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraEditors.TextEdit txtGio;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaMH;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTienTongCong;
        private DevComponents.DotNetBar.LabelX lbTongCong;
    }
}