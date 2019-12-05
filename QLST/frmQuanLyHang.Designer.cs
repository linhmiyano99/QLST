namespace QLST
{
    partial class frmQuanLyHang
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridKhachHang = new DevExpress.XtraGrid.GridControl();
            this.ribbonControlQLHang = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnGroup_ = new DevExpress.XtraBars.BarButtonGroup();
            this.btnThemHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimKiem = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonThaoTac = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txtDiemKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.lbChietKhau = new DevExpress.XtraEditors.LabelControl();
            this.lbDiemHang = new DevExpress.XtraEditors.LabelControl();
            this.txtMaHang = new DevExpress.XtraEditors.TextEdit();
            this.lbTenHang = new DevExpress.XtraEditors.LabelControl();
            this.lbMaHang = new DevExpress.XtraEditors.LabelControl();
            this.txtTenHang = new DevExpress.XtraEditors.TextEdit();
            this.grThongTinHang = new DevExpress.XtraEditors.GroupControl();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cmbChieuKhau = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlQLHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinHang)).BeginInit();
            this.grThongTinHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridKhachHang;
            this.gridView1.Name = "gridView1";
            // 
            // gridKhachHang
            // 
            this.gridKhachHang.Location = new System.Drawing.Point(12, 353);
            this.gridKhachHang.MainView = this.gridView1;
            this.gridKhachHang.MenuManager = this.ribbonControlQLHang;
            this.gridKhachHang.Name = "gridKhachHang";
            this.gridKhachHang.Size = new System.Drawing.Size(1225, 256);
            this.gridKhachHang.TabIndex = 6;
            this.gridKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ribbonControlQLHang
            // 
            this.ribbonControlQLHang.ExpandCollapseItem.Id = 0;
            this.ribbonControlQLHang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlQLHang.ExpandCollapseItem,
            this.btnGroup_,
            this.btnThemHang,
            this.btnXoaHang,
            this.btnLuu,
            this.barButtonItem4,
            this.btnXuatThongTin,
            this.btnTimKiem,
            this.ribbonControlQLHang.SearchEditItem});
            this.ribbonControlQLHang.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlQLHang.MaxItemId = 11;
            this.ribbonControlQLHang.Name = "ribbonControlQLHang";
            this.ribbonControlQLHang.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonThaoTac});
            this.ribbonControlQLHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbonControlQLHang.Size = new System.Drawing.Size(1243, 160);
            // 
            // btnGroup_
            // 
            this.btnGroup_.Caption = "barButtonGroup1";
            this.btnGroup_.Id = 1;
            this.btnGroup_.Name = "btnGroup_";
            // 
            // btnThemHang
            // 
            this.btnThemHang.Caption = "Thêm Hạng";
            this.btnThemHang.Id = 3;
            this.btnThemHang.ImageOptions.Image = global::QLST.Properties.Resources.addfile_16x16;
            this.btnThemHang.ImageOptions.LargeImage = global::QLST.Properties.Resources.addfile_32x321;
            this.btnThemHang.Name = "btnThemHang";
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.Caption = "Xóa Hạng";
            this.btnXoaHang.Id = 4;
            this.btnXoaHang.ImageOptions.Image = global::QLST.Properties.Resources.delete_16x16;
            this.btnXoaHang.ImageOptions.LargeImage = global::QLST.Properties.Resources.delete_32x32;
            this.btnXoaHang.Name = "btnXoaHang";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu Thay Đổi";
            this.btnLuu.Id = 5;
            this.btnLuu.ImageOptions.Image = global::QLST.Properties.Resources.save_16x16;
            this.btnLuu.ImageOptions.LargeImage = global::QLST.Properties.Resources.save_32x32;
            this.btnLuu.Name = "btnLuu";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xuất Phiếu Nhập";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnXuatThongTin
            // 
            this.btnXuatThongTin.Caption = "Xuất Thông Tin";
            this.btnXuatThongTin.Id = 7;
            this.btnXuatThongTin.ImageOptions.Image = global::QLST.Properties.Resources.exporttopdf_16x16;
            this.btnXuatThongTin.ImageOptions.LargeImage = global::QLST.Properties.Resources.exporttopdf_32x321;
            this.btnXuatThongTin.Name = "btnXuatThongTin";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Caption = "Tìm Kiếm";
            this.btnTimKiem.Edit = this.repositoryItemTextEdit1;
            this.btnTimKiem.EditWidth = 200;
            this.btnTimKiem.Hint = "Tìm Kiếm";
            this.btnTimKiem.Id = 10;
            this.btnTimKiem.ImageOptions.SvgImage = global::QLST.Properties.Resources.actions_zoom1;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ribbonThaoTac
            // 
            this.ribbonThaoTac.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonThaoTac.ImageOptions.SvgImage = global::QLST.Properties.Resources.bo_appointment;
            this.ribbonThaoTac.Name = "ribbonThaoTac";
            this.ribbonThaoTac.Text = "Thao Tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThemHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnXoaHang);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thao Tác";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLuu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Lưu Trữ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnXuatThongTin);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Xuất File";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ImageOptions.SvgImage = global::QLST.Properties.Resources.actions_zoom2;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTimKiem);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tìm Kiếm";
            // 
            // txtDiemKhachHang
            // 
            this.txtDiemKhachHang.Location = new System.Drawing.Point(568, 89);
            this.txtDiemKhachHang.MenuManager = this.ribbonControlQLHang;
            this.txtDiemKhachHang.Name = "txtDiemKhachHang";
            this.txtDiemKhachHang.Properties.Mask.BeepOnError = true;
            this.txtDiemKhachHang.Properties.Mask.EditMask = "d";
            this.txtDiemKhachHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiemKhachHang.Size = new System.Drawing.Size(179, 20);
            this.txtDiemKhachHang.TabIndex = 8;
            // 
            // lbChietKhau
            // 
            this.lbChietKhau.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChietKhau.Appearance.Options.UseFont = true;
            this.lbChietKhau.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbChietKhau.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbChietKhau.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbChietKhau.LineVisible = true;
            this.lbChietKhau.Location = new System.Drawing.Point(450, 33);
            this.lbChietKhau.Name = "lbChietKhau";
            this.lbChietKhau.Size = new System.Drawing.Size(69, 16);
            this.lbChietKhau.TabIndex = 7;
            this.lbChietKhau.Text = "Chiết Khấu";
            // 
            // lbDiemHang
            // 
            this.lbDiemHang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemHang.Appearance.Options.UseFont = true;
            this.lbDiemHang.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbDiemHang.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbDiemHang.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbDiemHang.LineVisible = true;
            this.lbDiemHang.Location = new System.Drawing.Point(450, 87);
            this.lbDiemHang.Name = "lbDiemHang";
            this.lbDiemHang.Size = new System.Drawing.Size(32, 16);
            this.lbDiemHang.TabIndex = 6;
            this.lbDiemHang.Text = "Điểm";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(123, 35);
            this.txtMaHang.MenuManager = this.ribbonControlQLHang;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Properties.Mask.EditMask = "\\d?\\d?/\\d?\\d?/\\d\\d";
            this.txtMaHang.Size = new System.Drawing.Size(214, 20);
            this.txtMaHang.TabIndex = 3;
            // 
            // lbTenHang
            // 
            this.lbTenHang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHang.Appearance.Options.UseFont = true;
            this.lbTenHang.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbTenHang.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbTenHang.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbTenHang.LineVisible = true;
            this.lbTenHang.Location = new System.Drawing.Point(5, 87);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(60, 16);
            this.lbTenHang.TabIndex = 1;
            this.lbTenHang.Text = "Tên Hạng";
            // 
            // lbMaHang
            // 
            this.lbMaHang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHang.Appearance.Options.UseFont = true;
            this.lbMaHang.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbMaHang.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbMaHang.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbMaHang.LineVisible = true;
            this.lbMaHang.Location = new System.Drawing.Point(5, 33);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(56, 16);
            this.lbMaHang.TabIndex = 0;
            this.lbMaHang.Text = "Mã Hạng";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(123, 89);
            this.txtTenHang.MenuManager = this.ribbonControlQLHang;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTenHang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTenHang.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtTenHang.Properties.Mask.BeepOnError = true;
            this.txtTenHang.Properties.Mask.EditMask = "@\"^[a-zA-Z ]*$\"";
            this.txtTenHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTenHang.Size = new System.Drawing.Size(214, 20);
            this.txtTenHang.TabIndex = 4;
            // 
            // grThongTinHang
            // 
            this.grThongTinHang.Controls.Add(this.cmbChieuKhau);
            this.grThongTinHang.Controls.Add(this.txtDiemKhachHang);
            this.grThongTinHang.Controls.Add(this.lbChietKhau);
            this.grThongTinHang.Controls.Add(this.lbDiemHang);
            this.grThongTinHang.Controls.Add(this.txtMaHang);
            this.grThongTinHang.Controls.Add(this.lbTenHang);
            this.grThongTinHang.Controls.Add(this.lbMaHang);
            this.grThongTinHang.Controls.Add(this.txtTenHang);
            this.grThongTinHang.Location = new System.Drawing.Point(12, 185);
            this.grThongTinHang.Name = "grThongTinHang";
            this.grThongTinHang.Size = new System.Drawing.Size(1225, 146);
            this.grThongTinHang.TabIndex = 5;
            this.grThongTinHang.Text = "Thông Tin Chung";
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
            // cmbChieuKhau
            // 
            this.cmbChieuKhau.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChieuKhau.FormattingEnabled = true;
            this.cmbChieuKhau.ItemHeight = 15;
            this.cmbChieuKhau.Items.AddRange(new object[] {
            this.comboItem5,
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.cmbChieuKhau.Location = new System.Drawing.Point(568, 33);
            this.cmbChieuKhau.Name = "cmbChieuKhau";
            this.cmbChieuKhau.Size = new System.Drawing.Size(179, 21);
            this.cmbChieuKhau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbChieuKhau.TabIndex = 9;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "10";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "15";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "20";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "25";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "5";
            // 
            // frmQuanLyHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 612);
            this.Controls.Add(this.grThongTinHang);
            this.Controls.Add(this.gridKhachHang);
            this.Controls.Add(this.ribbonControlQLHang);
            this.Name = "frmQuanLyHang";
            this.Text = "Quản Lý Hạng";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlQLHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinHang)).EndInit();
            this.grThongTinHang.ResumeLayout(false);
            this.grThongTinHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlQLHang;
        private DevExpress.XtraBars.BarButtonGroup btnGroup_;
        private DevExpress.XtraBars.BarButtonItem btnThemHang;
        private DevExpress.XtraBars.BarButtonItem btnXoaHang;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnXuatThongTin;
        private DevExpress.XtraBars.BarEditItem btnTimKiem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonThaoTac;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraEditors.TextEdit txtDiemKhachHang;
        private DevExpress.XtraEditors.LabelControl lbChietKhau;
        private DevExpress.XtraEditors.LabelControl lbDiemHang;
        private DevExpress.XtraEditors.TextEdit txtMaHang;
        private DevExpress.XtraEditors.LabelControl lbTenHang;
        private DevExpress.XtraEditors.LabelControl lbMaHang;
        private DevExpress.XtraEditors.TextEdit txtTenHang;
        private DevExpress.XtraEditors.GroupControl grThongTinHang;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbChieuKhau;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
    }
}