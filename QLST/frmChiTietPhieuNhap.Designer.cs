namespace DX_SIEUTHI_MINI
{
    partial class frmChiTietPhieuNhap
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietPhieuNhap));
            this.grThongTinPhieuNhap = new DevExpress.XtraEditors.GroupControl();
            this.txtKhoNhap = new DevExpress.XtraEditors.TextEdit();
            this.ribbonControl_ChiTietPhieuNhap = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnGroup_ = new DevExpress.XtraBars.BarButtonGroup();
            this.btnThemMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuMH = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonThaoTac = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lbNhanVienNhap = new DevExpress.XtraEditors.LabelControl();
            this.lbKhoNhap = new DevExpress.XtraEditors.LabelControl();
            this.txtSoPhieu = new DevExpress.XtraEditors.TextEdit();
            this.lbNhaCungCap = new DevExpress.XtraEditors.LabelControl();
            this.lbNgay = new DevExpress.XtraEditors.LabelControl();
            this.lbSoPhieu = new DevExpress.XtraEditors.LabelControl();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.cmbNhaCungCap = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbNhanVienNhap = new DevExpress.XtraEditors.ComboBoxEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridThongTinMatHang = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltblCHITIETPHIEUXUATKHO_MaSoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCHITIETPHIEUXUATKHO_MaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCHITIETPHIEUXUATKHO_SoLuongYeuCau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCHITIETPHIEUXUATKHO_SoLuongThucXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCHITIETPHIEUXUATKHO_DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblCHITIETPHIEUXUATKHO_ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongYeuCau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongThucXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinPhieuNhap)).BeginInit();
            this.grThongTinPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl_ChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhanVienNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongTinPhieuNhap
            // 
            this.grThongTinPhieuNhap.Controls.Add(this.txtKhoNhap);
            this.grThongTinPhieuNhap.Controls.Add(this.lbNhanVienNhap);
            this.grThongTinPhieuNhap.Controls.Add(this.lbKhoNhap);
            this.grThongTinPhieuNhap.Controls.Add(this.txtSoPhieu);
            this.grThongTinPhieuNhap.Controls.Add(this.lbNhaCungCap);
            this.grThongTinPhieuNhap.Controls.Add(this.lbNgay);
            this.grThongTinPhieuNhap.Controls.Add(this.lbSoPhieu);
            this.grThongTinPhieuNhap.Controls.Add(this.txtNgay);
            this.grThongTinPhieuNhap.Controls.Add(this.cmbNhaCungCap);
            this.grThongTinPhieuNhap.Controls.Add(this.cmbNhanVienNhap);
            this.grThongTinPhieuNhap.Location = new System.Drawing.Point(12, 198);
            this.grThongTinPhieuNhap.Name = "grThongTinPhieuNhap";
            this.grThongTinPhieuNhap.Size = new System.Drawing.Size(1366, 194);
            this.grThongTinPhieuNhap.TabIndex = 1;
            this.grThongTinPhieuNhap.Text = "Thông Tin Phiếu Nhập";
            // 
            // txtKhoNhap
            // 
            this.txtKhoNhap.Location = new System.Drawing.Point(566, 35);
            this.txtKhoNhap.MenuManager = this.ribbonControl_ChiTietPhieuNhap;
            this.txtKhoNhap.Name = "txtKhoNhap";
            this.txtKhoNhap.Properties.Mask.EditMask = "\\d?\\d?/\\d?\\d?/\\d\\d";
            this.txtKhoNhap.Size = new System.Drawing.Size(179, 20);
            this.txtKhoNhap.TabIndex = 8;
            // 
            // ribbonControl_ChiTietPhieuNhap
            // 
            this.ribbonControl_ChiTietPhieuNhap.ExpandCollapseItem.Id = 0;
            this.ribbonControl_ChiTietPhieuNhap.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl_ChiTietPhieuNhap.ExpandCollapseItem,
            this.ribbonControl_ChiTietPhieuNhap.SearchEditItem,
            this.btnGroup_,
            this.btnThemMH,
            this.btnXoaMH,
            this.btnLuuMH,
            this.barButtonItem4,
            this.btnXuatPhieu,
            this.barEditItem1});
            this.ribbonControl_ChiTietPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl_ChiTietPhieuNhap.MaxItemId = 9;
            this.ribbonControl_ChiTietPhieuNhap.Name = "ribbonControl_ChiTietPhieuNhap";
            this.ribbonControl_ChiTietPhieuNhap.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonThaoTac});
            this.ribbonControl_ChiTietPhieuNhap.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbonControl_ChiTietPhieuNhap.Size = new System.Drawing.Size(1390, 160);
            // 
            // btnGroup_
            // 
            this.btnGroup_.Caption = "barButtonGroup1";
            this.btnGroup_.Id = 1;
            this.btnGroup_.Name = "btnGroup_";
            // 
            // btnThemMH
            // 
            this.btnThemMH.Caption = "Thêm Mặt Hàng";
            this.btnThemMH.Id = 3;
            this.btnThemMH.ImageOptions.Image = global::DX_SIEUTHI_MINI.Properties.Resources.addfile_16x16;
            this.btnThemMH.ImageOptions.LargeImage = global::DX_SIEUTHI_MINI.Properties.Resources.addfile_32x321;
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Caption = "Xóa";
            this.btnXoaMH.Id = 4;
            this.btnXoaMH.ImageOptions.Image = global::DX_SIEUTHI_MINI.Properties.Resources.delete_16x16;
            this.btnXoaMH.ImageOptions.LargeImage = global::DX_SIEUTHI_MINI.Properties.Resources.delete_32x32;
            this.btnXoaMH.Name = "btnXoaMH";
            // 
            // btnLuuMH
            // 
            this.btnLuuMH.Caption = "Lưu";
            this.btnLuuMH.Id = 5;
            this.btnLuuMH.ImageOptions.Image = global::DX_SIEUTHI_MINI.Properties.Resources.save_16x16;
            this.btnLuuMH.ImageOptions.LargeImage = global::DX_SIEUTHI_MINI.Properties.Resources.save_32x32;
            this.btnLuuMH.Name = "btnLuuMH";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xuất Phiếu Nhập";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnXuatPhieu
            // 
            this.btnXuatPhieu.Caption = "Xuất Phiếu Nhập";
            this.btnXuatPhieu.Id = 7;
            this.btnXuatPhieu.ImageOptions.Image = global::DX_SIEUTHI_MINI.Properties.Resources.exporttopdf_16x16;
            this.btnXuatPhieu.ImageOptions.LargeImage = global::DX_SIEUTHI_MINI.Properties.Resources.exporttopdf_32x321;
            this.btnXuatPhieu.Name = "btnXuatPhieu";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Tìm Kiếm";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.EditWidth = 200;
            this.barEditItem1.Id = 8;
            this.barEditItem1.ImageOptions.SvgImage = global::DX_SIEUTHI_MINI.Properties.Resources.actions_zoom4;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.barEditItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barEditItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItem1_ItemClick);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ribbonThaoTac
            // 
            this.ribbonThaoTac.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbon,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup1});
            this.ribbonThaoTac.ImageOptions.SvgImage = global::DX_SIEUTHI_MINI.Properties.Resources.bo_appointment;
            this.ribbonThaoTac.Name = "ribbonThaoTac";
            this.ribbonThaoTac.Text = "Thao Tác";
            // 
            // ribbon
            // 
            this.ribbon.ItemLinks.Add(this.btnThemMH);
            this.ribbon.ItemLinks.Add(this.btnXoaMH);
            this.ribbon.Name = "ribbon";
            this.ribbon.Text = "Thao Tác";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLuuMH);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Lưu Trữ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnXuatPhieu);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Xuất File";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.SvgImage = global::DX_SIEUTHI_MINI.Properties.Resources.actions_zoom3;
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tìm Kiếm";
            // 
            // lbNhanVienNhap
            // 
            this.lbNhanVienNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVienNhap.Appearance.Options.UseFont = true;
            this.lbNhanVienNhap.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbNhanVienNhap.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbNhanVienNhap.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbNhanVienNhap.LineVisible = true;
            this.lbNhanVienNhap.Location = new System.Drawing.Point(448, 87);
            this.lbNhanVienNhap.Name = "lbNhanVienNhap";
            this.lbNhanVienNhap.Size = new System.Drawing.Size(100, 16);
            this.lbNhanVienNhap.TabIndex = 7;
            this.lbNhanVienNhap.Text = "Nhân Viên Nhập";
            // 
            // lbKhoNhap
            // 
            this.lbKhoNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoNhap.Appearance.Options.UseFont = true;
            this.lbKhoNhap.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbKhoNhap.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbKhoNhap.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbKhoNhap.LineVisible = true;
            this.lbKhoNhap.Location = new System.Drawing.Point(448, 33);
            this.lbKhoNhap.Name = "lbKhoNhap";
            this.lbKhoNhap.Size = new System.Drawing.Size(60, 16);
            this.lbKhoNhap.TabIndex = 6;
            this.lbKhoNhap.Text = "Kho Nhập";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(123, 35);
            this.txtSoPhieu.MenuManager = this.ribbonControl_ChiTietPhieuNhap;
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Properties.Mask.EditMask = "\\d?\\d?/\\d?\\d?/\\d\\d";
            this.txtSoPhieu.Size = new System.Drawing.Size(214, 20);
            this.txtSoPhieu.TabIndex = 3;
            // 
            // lbNhaCungCap
            // 
            this.lbNhaCungCap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaCungCap.Appearance.Options.UseFont = true;
            this.lbNhaCungCap.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbNhaCungCap.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbNhaCungCap.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbNhaCungCap.LineVisible = true;
            this.lbNhaCungCap.Location = new System.Drawing.Point(5, 145);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(88, 16);
            this.lbNhaCungCap.TabIndex = 2;
            this.lbNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // lbNgay
            // 
            this.lbNgay.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Appearance.Options.UseFont = true;
            this.lbNgay.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbNgay.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbNgay.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbNgay.LineVisible = true;
            this.lbNgay.Location = new System.Drawing.Point(5, 87);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(32, 16);
            this.lbNgay.TabIndex = 1;
            this.lbNgay.Text = "Ngày";
            this.lbNgay.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // lbSoPhieu
            // 
            this.lbSoPhieu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoPhieu.Appearance.Options.UseFont = true;
            this.lbSoPhieu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbSoPhieu.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbSoPhieu.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbSoPhieu.LineVisible = true;
            this.lbSoPhieu.Location = new System.Drawing.Point(5, 33);
            this.lbSoPhieu.Name = "lbSoPhieu";
            this.lbSoPhieu.Size = new System.Drawing.Size(55, 16);
            this.lbSoPhieu.TabIndex = 0;
            this.lbSoPhieu.Text = "Số Phiếu";
            // 
            // txtNgay
            // 
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(123, 89);
            this.txtNgay.MenuManager = this.ribbonControl_ChiTietPhieuNhap;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.txtNgay.Properties.DisplayFormat.FormatString = "";
            this.txtNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgay.Properties.EditFormat.FormatString = "";
            this.txtNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgay.Properties.Mask.BeepOnError = true;
            this.txtNgay.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.txtNgay.Size = new System.Drawing.Size(214, 20);
            this.txtNgay.TabIndex = 4;
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.Location = new System.Drawing.Point(123, 144);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNhaCungCap.Size = new System.Drawing.Size(214, 20);
            this.cmbNhaCungCap.TabIndex = 5;
            // 
            // cmbNhanVienNhap
            // 
            this.cmbNhanVienNhap.Location = new System.Drawing.Point(566, 89);
            this.cmbNhanVienNhap.MenuManager = this.ribbonControl_ChiTietPhieuNhap;
            this.cmbNhanVienNhap.Name = "cmbNhanVienNhap";
            this.cmbNhanVienNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNhanVienNhap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cmbNhanVienNhap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cmbNhanVienNhap.Size = new System.Drawing.Size(179, 20);
            this.cmbNhanVienNhap.TabIndex = 9;
            // 
            // gridThongTinMatHang
            // 
            this.gridThongTinMatHang.DataMember = "tblCHITIETPHIEUXUATKHO";
            this.gridThongTinMatHang.DataSource = this.sqlDataSource1;
            this.gridThongTinMatHang.Location = new System.Drawing.Point(0, 431);
            this.gridThongTinMatHang.MainView = this.gridView1;
            this.gridThongTinMatHang.MenuManager = this.ribbonControl_ChiTietPhieuNhap;
            this.gridThongTinMatHang.Name = "gridThongTinMatHang";
            this.gridThongTinMatHang.Size = new System.Drawing.Size(1378, 385);
            this.gridThongTinMatHang.TabIndex = 3;
            this.gridThongTinMatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_dbQLST_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"172\" />";
            table1.Name = "tblCHITIETPHIEUXUATKHO";
            allColumns1.Table = table1;
            columnExpression1.ColumnName = "MaSoPhieu";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "MaMH";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "SoLuongYeuCau";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "SoLuongThucXuat";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "DonGia";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "ThanhTien";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Name = "tblCHITIETPHIEUXUATKHO";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltblCHITIETPHIEUXUATKHO_MaSoPhieu,
            this.coltblCHITIETPHIEUXUATKHO_MaMH,
            this.coltblCHITIETPHIEUXUATKHO_SoLuongYeuCau,
            this.coltblCHITIETPHIEUXUATKHO_SoLuongThucXuat,
            this.coltblCHITIETPHIEUXUATKHO_DonGia,
            this.coltblCHITIETPHIEUXUATKHO_ThanhTien,
            this.colMaSoPhieu,
            this.colMaMH,
            this.colSoLuongYeuCau,
            this.colSoLuongThucXuat,
            this.colDonGia,
            this.colThanhTien});
            this.gridView1.GridControl = this.gridThongTinMatHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // coltblCHITIETPHIEUXUATKHO_MaSoPhieu
            // 
            this.coltblCHITIETPHIEUXUATKHO_MaSoPhieu.FieldName = "tblCHITIETPHIEUXUATKHO_MaSoPhieu";
            this.coltblCHITIETPHIEUXUATKHO_MaSoPhieu.Name = "coltblCHITIETPHIEUXUATKHO_MaSoPhieu";
            this.coltblCHITIETPHIEUXUATKHO_MaSoPhieu.Visible = true;
            this.coltblCHITIETPHIEUXUATKHO_MaSoPhieu.VisibleIndex = 0;
            // 
            // coltblCHITIETPHIEUXUATKHO_MaMH
            // 
            this.coltblCHITIETPHIEUXUATKHO_MaMH.FieldName = "tblCHITIETPHIEUXUATKHO_MaMH";
            this.coltblCHITIETPHIEUXUATKHO_MaMH.Name = "coltblCHITIETPHIEUXUATKHO_MaMH";
            this.coltblCHITIETPHIEUXUATKHO_MaMH.Visible = true;
            this.coltblCHITIETPHIEUXUATKHO_MaMH.VisibleIndex = 1;
            // 
            // coltblCHITIETPHIEUXUATKHO_SoLuongYeuCau
            // 
            this.coltblCHITIETPHIEUXUATKHO_SoLuongYeuCau.FieldName = "tblCHITIETPHIEUXUATKHO_SoLuongYeuCau";
            this.coltblCHITIETPHIEUXUATKHO_SoLuongYeuCau.Name = "coltblCHITIETPHIEUXUATKHO_SoLuongYeuCau";
            this.coltblCHITIETPHIEUXUATKHO_SoLuongYeuCau.Visible = true;
            this.coltblCHITIETPHIEUXUATKHO_SoLuongYeuCau.VisibleIndex = 2;
            // 
            // coltblCHITIETPHIEUXUATKHO_SoLuongThucXuat
            // 
            this.coltblCHITIETPHIEUXUATKHO_SoLuongThucXuat.FieldName = "tblCHITIETPHIEUXUATKHO_SoLuongThucXuat";
            this.coltblCHITIETPHIEUXUATKHO_SoLuongThucXuat.Name = "coltblCHITIETPHIEUXUATKHO_SoLuongThucXuat";
            this.coltblCHITIETPHIEUXUATKHO_SoLuongThucXuat.Visible = true;
            this.coltblCHITIETPHIEUXUATKHO_SoLuongThucXuat.VisibleIndex = 3;
            // 
            // coltblCHITIETPHIEUXUATKHO_DonGia
            // 
            this.coltblCHITIETPHIEUXUATKHO_DonGia.FieldName = "tblCHITIETPHIEUXUATKHO_DonGia";
            this.coltblCHITIETPHIEUXUATKHO_DonGia.Name = "coltblCHITIETPHIEUXUATKHO_DonGia";
            this.coltblCHITIETPHIEUXUATKHO_DonGia.Visible = true;
            this.coltblCHITIETPHIEUXUATKHO_DonGia.VisibleIndex = 4;
            // 
            // coltblCHITIETPHIEUXUATKHO_ThanhTien
            // 
            this.coltblCHITIETPHIEUXUATKHO_ThanhTien.FieldName = "tblCHITIETPHIEUXUATKHO_ThanhTien";
            this.coltblCHITIETPHIEUXUATKHO_ThanhTien.Name = "coltblCHITIETPHIEUXUATKHO_ThanhTien";
            this.coltblCHITIETPHIEUXUATKHO_ThanhTien.Visible = true;
            this.coltblCHITIETPHIEUXUATKHO_ThanhTien.VisibleIndex = 5;
            // 
            // colMaSoPhieu
            // 
            this.colMaSoPhieu.FieldName = "MaSoPhieu";
            this.colMaSoPhieu.Name = "colMaSoPhieu";
            this.colMaSoPhieu.Visible = true;
            this.colMaSoPhieu.VisibleIndex = 6;
            // 
            // colMaMH
            // 
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 7;
            // 
            // colSoLuongYeuCau
            // 
            this.colSoLuongYeuCau.FieldName = "SoLuongYeuCau";
            this.colSoLuongYeuCau.Name = "colSoLuongYeuCau";
            this.colSoLuongYeuCau.Visible = true;
            this.colSoLuongYeuCau.VisibleIndex = 8;
            // 
            // colSoLuongThucXuat
            // 
            this.colSoLuongThucXuat.FieldName = "SoLuongThucXuat";
            this.colSoLuongThucXuat.Name = "colSoLuongThucXuat";
            this.colSoLuongThucXuat.Visible = true;
            this.colSoLuongThucXuat.VisibleIndex = 9;
            // 
            // colDonGia
            // 
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 10;
            // 
            // colThanhTien
            // 
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 11;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // frmChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 828);
            this.Controls.Add(this.gridThongTinMatHang);
            this.Controls.Add(this.grThongTinPhieuNhap);
            this.Controls.Add(this.ribbonControl_ChiTietPhieuNhap);
            this.Name = "frmChiTietPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Phiếu Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinPhieuNhap)).EndInit();
            this.grThongTinPhieuNhap.ResumeLayout(false);
            this.grThongTinPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl_ChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhanVienNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl grThongTinPhieuNhap;
        private DevExpress.XtraEditors.LabelControl lbSoPhieu;
        private DevExpress.XtraEditors.LabelControl lbNgay;
        private DevExpress.XtraEditors.LabelControl lbNhaCungCap;
        private DevExpress.XtraEditors.TextEdit txtSoPhieu;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.ComboBoxEdit cmbNhaCungCap;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit txtKhoNhap;
        private DevExpress.XtraEditors.LabelControl lbNhanVienNhap;
        private DevExpress.XtraEditors.LabelControl lbKhoNhap;
        private DevExpress.XtraEditors.ComboBoxEdit cmbNhanVienNhap;
        private DevExpress.XtraGrid.GridControl gridThongTinMatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCHITIETPHIEUXUATKHO_MaSoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCHITIETPHIEUXUATKHO_MaMH;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCHITIETPHIEUXUATKHO_SoLuongYeuCau;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCHITIETPHIEUXUATKHO_SoLuongThucXuat;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCHITIETPHIEUXUATKHO_DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn coltblCHITIETPHIEUXUATKHO_ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongYeuCau;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongThucXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl_ChiTietPhieuNhap;
        private DevExpress.XtraBars.BarButtonGroup btnGroup_;
        private DevExpress.XtraBars.BarButtonItem btnThemMH;
        private DevExpress.XtraBars.BarButtonItem btnXoaMH;
        private DevExpress.XtraBars.BarButtonItem btnLuuMH;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonThaoTac;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnXuatPhieu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}