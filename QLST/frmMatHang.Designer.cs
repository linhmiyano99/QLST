namespace QLST
{
    partial class frmMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lbBarcode = new DevExpress.XtraEditors.LabelControl();
            this.txtSoHoaDon = new DevExpress.XtraEditors.TextEdit();
            this.lbMaMH = new DevExpress.XtraEditors.LabelControl();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.lbTenMH = new DevExpress.XtraEditors.LabelControl();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.lbSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.lbGiaNhap = new DevExpress.XtraEditors.LabelControl();
            this.grThongTinMatHang = new DevExpress.XtraEditors.GroupControl();
            this.txtNhaCungCap = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new DevExpress.XtraEditors.TextEdit();
            this.lbNhaCungCap = new DevExpress.XtraEditors.LabelControl();
            this.lbGiaBan = new DevExpress.XtraEditors.LabelControl();
            this.dataGridViewMatHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHoaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinMatHang)).BeginInit();
            this.grThongTinMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnLuu,
            this.btnXuatThongTin,
            this.btnDelete,
            this.barButtonItem4,
            this.btnThem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5,
            this.repositoryItemTextEdit6});
            this.ribbon.Size = new System.Drawing.Size(1249, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu thông tin";
            this.btnLuu.Id = 1;
            this.btnLuu.ImageOptions.Image = global::QLST.Properties.Resources.save_16x16;
            this.btnLuu.ImageOptions.LargeImage = global::QLST.Properties.Resources.save_32x32;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnXuatThongTin
            // 
            this.btnXuatThongTin.Caption = "Xuất thông tin";
            this.btnXuatThongTin.Id = 2;
            this.btnXuatThongTin.ImageOptions.Image = global::QLST.Properties.Resources.exporttopdf_16x16;
            this.btnXuatThongTin.ImageOptions.LargeImage = global::QLST.Properties.Resources.exporttopdf_32x321;
            this.btnXuatThongTin.Name = "btnXuatThongTin";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa ";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.Image = global::QLST.Properties.Resources.delete_16x16;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xuất hóa đơn";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 12;
            this.btnThem.ImageOptions.Image = global::QLST.Properties.Resources.addfile_16x16;
            this.btnThem.ImageOptions.LargeImage = global::QLST.Properties.Resources.addfile_32x321;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);

            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao tác";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup3.ImageOptions.SvgImage")));
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThem, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDelete, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thao tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLuu, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Lưu trữ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXuatThongTin, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Xuất file";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // repositoryItemTextEdit6
            // 
            this.repositoryItemTextEdit6.AutoHeight = false;
            this.repositoryItemTextEdit6.Name = "repositoryItemTextEdit6";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 762);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1249, 37);
            // 
            // lbBarcode
            // 
            this.lbBarcode.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcode.Appearance.Options.UseFont = true;
            this.lbBarcode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbBarcode.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbBarcode.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbBarcode.LineVisible = true;
            this.lbBarcode.Location = new System.Drawing.Point(41, 33);
            this.lbBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(77, 19);
            this.lbBarcode.TabIndex = 0;
            this.lbBarcode.Text = "Barcode: ";
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Location = new System.Drawing.Point(184, 32);
            this.txtSoHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoHoaDon.MenuManager = this.ribbon;
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(192, 22);
            this.txtSoHoaDon.TabIndex = 1;
            // 
            // lbMaMH
            // 
            this.lbMaMH.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaMH.Appearance.Options.UseFont = true;
            this.lbMaMH.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbMaMH.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbMaMH.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbMaMH.LineVisible = true;
            this.lbMaMH.Location = new System.Drawing.Point(41, 85);
            this.lbMaMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(122, 21);
            this.lbMaMH.TabIndex = 2;
            this.lbMaMH.Text = "Mã mặt hàng: ";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(184, 79);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaMH.MenuManager = this.ribbon;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(192, 22);
            this.txtMaMH.TabIndex = 2;
            // 
            // lbTenMH
            // 
            this.lbTenMH.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMH.Appearance.Options.UseFont = true;
            this.lbTenMH.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbTenMH.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbTenMH.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbTenMH.LineVisible = true;
            this.lbTenMH.Location = new System.Drawing.Point(41, 135);
            this.lbTenMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTenMH.Name = "lbTenMH";
            this.lbTenMH.Size = new System.Drawing.Size(128, 21);
            this.lbTenMH.TabIndex = 4;
            this.lbTenMH.Text = "Tên mặt hàng: ";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(184, 130);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarcode.MenuManager = this.ribbon;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(192, 22);
            this.txtBarcode.TabIndex = 3;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Appearance.Options.UseFont = true;
            this.lbSoLuong.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbSoLuong.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbSoLuong.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbSoLuong.LineVisible = true;
            this.lbSoLuong.Location = new System.Drawing.Point(915, 37);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(88, 21);
            this.lbSoLuong.TabIndex = 10;
            this.lbSoLuong.Text = "Số lượng: ";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(1016, 33);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.MenuManager = this.ribbon;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(168, 22);
            this.txtSoLuong.TabIndex = 7;
            // 
            // lbGiaNhap
            // 
            this.lbGiaNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaNhap.Appearance.Options.UseFont = true;
            this.lbGiaNhap.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbGiaNhap.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbGiaNhap.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbGiaNhap.LineVisible = true;
            this.lbGiaNhap.Location = new System.Drawing.Point(475, 36);
            this.lbGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbGiaNhap.Name = "lbGiaNhap";
            this.lbGiaNhap.Size = new System.Drawing.Size(87, 21);
            this.lbGiaNhap.TabIndex = 12;
            this.lbGiaNhap.Text = "Giá nhập: ";
            // 
            // grThongTinMatHang
            // 
            this.grThongTinMatHang.Controls.Add(this.txtNhaCungCap);
            this.grThongTinMatHang.Controls.Add(this.txtGiaBan);
            this.grThongTinMatHang.Controls.Add(this.txtGiaNhap);
            this.grThongTinMatHang.Controls.Add(this.lbNhaCungCap);
            this.grThongTinMatHang.Controls.Add(this.lbGiaBan);
            this.grThongTinMatHang.Controls.Add(this.lbGiaNhap);
            this.grThongTinMatHang.Controls.Add(this.txtSoLuong);
            this.grThongTinMatHang.Controls.Add(this.lbSoLuong);
            this.grThongTinMatHang.Controls.Add(this.txtBarcode);
            this.grThongTinMatHang.Controls.Add(this.lbTenMH);
            this.grThongTinMatHang.Controls.Add(this.txtMaMH);
            this.grThongTinMatHang.Controls.Add(this.lbMaMH);
            this.grThongTinMatHang.Controls.Add(this.txtSoHoaDon);
            this.grThongTinMatHang.Controls.Add(this.lbBarcode);
            this.grThongTinMatHang.Location = new System.Drawing.Point(14, 176);
            this.grThongTinMatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grThongTinMatHang.Name = "grThongTinMatHang";
            this.grThongTinMatHang.Size = new System.Drawing.Size(1221, 193);
            this.grThongTinMatHang.TabIndex = 2;
            this.grThongTinMatHang.Text = "Thông tin mặt hàng";
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.Location = new System.Drawing.Point(631, 132);
            this.txtNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhaCungCap.MenuManager = this.ribbon;
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(185, 22);
            this.txtNhaCungCap.TabIndex = 6;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(631, 82);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(185, 23);
            this.txtGiaBan.TabIndex = 5;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(631, 32);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaNhap.MenuManager = this.ribbon;
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(185, 22);
            this.txtGiaNhap.TabIndex = 4;
            // 
            // lbNhaCungCap
            // 
            this.lbNhaCungCap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaCungCap.Appearance.Options.UseFont = true;
            this.lbNhaCungCap.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbNhaCungCap.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbNhaCungCap.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbNhaCungCap.LineVisible = true;
            this.lbNhaCungCap.Location = new System.Drawing.Point(475, 132);
            this.lbNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(127, 21);
            this.lbNhaCungCap.TabIndex = 14;
            this.lbNhaCungCap.Text = "Nhà cung cấp: ";
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaBan.Appearance.Options.UseFont = true;
            this.lbGiaBan.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbGiaBan.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbGiaBan.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbGiaBan.LineVisible = true;
            this.lbGiaBan.Location = new System.Drawing.Point(475, 80);
            this.lbGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(68, 19);
            this.lbGiaBan.TabIndex = 13;
            this.lbGiaBan.Text = "Giá bán:";
            // 
            // dataGridViewMatHang
            // 
            this.dataGridViewMatHang.AllowUserToAddRows = false;
            this.dataGridViewMatHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMatHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMatHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewMatHang.Location = new System.Drawing.Point(14, 395);
            this.dataGridViewMatHang.Name = "dataGridViewMatHang";
            this.dataGridViewMatHang.RowHeadersWidth = 51;
            this.dataGridViewMatHang.RowTemplate.Height = 24;
            this.dataGridViewMatHang.Size = new System.Drawing.Size(1221, 342);
            this.dataGridViewMatHang.TabIndex = 14;
            this.dataGridViewMatHang.AllowUserToAddRowsChanged += new System.EventHandler(this.dataGridViewMatHang_AllowUserToAddRowsChanged);
            this.dataGridViewMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellClick);
            this.dataGridViewMatHang.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellContentDoubleClick);
            this.dataGridViewMatHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellValueChanged);
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 799);
            this.Controls.Add(this.dataGridViewMatHang);
            this.Controls.Add(this.grThongTinMatHang);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMatHang";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Danh sách mặt hàng";
            this.Load += new System.EventHandler(this.frmMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHoaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinMatHang)).EndInit();
            this.grThongTinMatHang.ResumeLayout(false);
            this.grThongTinMatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnXuatThongTin;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit6;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraEditors.LabelControl lbBarcode;
        private DevExpress.XtraEditors.TextEdit txtSoHoaDon;
        private DevExpress.XtraEditors.LabelControl lbMaMH;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.LabelControl lbTenMH;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.LabelControl lbSoLuong;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.LabelControl lbGiaNhap;
        private DevExpress.XtraEditors.GroupControl grThongTinMatHang;
        private DevExpress.XtraEditors.TextEdit txtNhaCungCap;
        private System.Windows.Forms.TextBox txtGiaBan;
        private DevExpress.XtraEditors.TextEdit txtGiaNhap;
        private DevExpress.XtraEditors.LabelControl lbNhaCungCap;
        private DevExpress.XtraEditors.LabelControl lbGiaBan;
        public DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewMatHang;
    }
}