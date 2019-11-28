namespace QLST
{
    partial class frmKhachHang
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
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonThaoTac = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnThemKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnXuatThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonControlKhachHang = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnGroup_ = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.grThongTinKhachHang = new DevExpress.XtraEditors.GroupControl();
            this.txtDiemKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.lbHangKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.lbDiemKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.txtMaKjhachHang = new DevExpress.XtraEditors.TextEdit();
            this.lbTenKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.lbMaKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.cmbHangKhachHang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.gridKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinKhachHang)).BeginInit();
            this.grThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKjhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHangKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThemKhachHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnXoaKhachHang);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thao Tác";
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Caption = "Thêm Khách Hàng";
            this.btnThemKhachHang.Id = 3;
            this.btnThemKhachHang.ImageOptions.Image = global::QLST.Properties.Resources.addfile_16x16;
            this.btnThemKhachHang.ImageOptions.LargeImage = global::QLST.Properties.Resources.addfile_32x321;
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.Caption = "Xóa Khách Hàng";
            this.btnXoaKhachHang.Id = 4;
            this.btnXoaKhachHang.ImageOptions.Image = global::QLST.Properties.Resources.delete_16x16;
            this.btnXoaKhachHang.ImageOptions.LargeImage = global::QLST.Properties.Resources.delete_32x32;
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLuu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Lưu Trữ";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu Thay Đổi";
            this.btnLuu.Id = 5;
            this.btnLuu.ImageOptions.Image = global::QLST.Properties.Resources.save_16x16;
            this.btnLuu.ImageOptions.LargeImage = global::QLST.Properties.Resources.save_32x32;
            this.btnLuu.Name = "btnLuu";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnXuatThongTin);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Xuất File";
            // 
            // btnXuatThongTin
            // 
            this.btnXuatThongTin.Caption = "Xuất Thông Tin Khách Hàng";
            this.btnXuatThongTin.Id = 7;
            this.btnXuatThongTin.ImageOptions.Image = global::QLST.Properties.Resources.exporttopdf_16x16;
            this.btnXuatThongTin.ImageOptions.LargeImage = global::QLST.Properties.Resources.exporttopdf_32x321;
            this.btnXuatThongTin.Name = "btnXuatThongTin";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ImageOptions.SvgImage = global::QLST.Properties.Resources.actions_zoom2;
            this.ribbonPageGroup5.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tìm Kiếm";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Tìm Kiếm";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.EditWidth = 200;
            this.barEditItem1.Hint = "Tìm Kiếm Khách Hàng";
            this.barEditItem1.Id = 10;
            this.barEditItem1.ImageOptions.SvgImage = global::QLST.Properties.Resources.actions_zoom1;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barEditItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItem1_ItemClick);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ribbonControlKhachHang
            // 
            this.ribbonControlKhachHang.ExpandCollapseItem.Id = 0;
            this.ribbonControlKhachHang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlKhachHang.ExpandCollapseItem,
            this.ribbonControlKhachHang.SearchEditItem,
            this.btnGroup_,
            this.btnThemKhachHang,
            this.btnXoaKhachHang,
            this.btnLuu,
            this.barButtonItem4,
            this.btnXuatThongTin,
            this.barEditItem1});
            this.ribbonControlKhachHang.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlKhachHang.MaxItemId = 11;
            this.ribbonControlKhachHang.Name = "ribbonControlKhachHang";
            this.ribbonControlKhachHang.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonThaoTac});
            this.ribbonControlKhachHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbonControlKhachHang.Size = new System.Drawing.Size(1249, 160);
            // 
            // btnGroup_
            // 
            this.btnGroup_.Caption = "barButtonGroup1";
            this.btnGroup_.Id = 1;
            this.btnGroup_.Name = "btnGroup_";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xuất Phiếu Nhập";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // grThongTinKhachHang
            // 
            this.grThongTinKhachHang.Controls.Add(this.txtDiemKhachHang);
            this.grThongTinKhachHang.Controls.Add(this.lbHangKhachHang);
            this.grThongTinKhachHang.Controls.Add(this.lbDiemKhachHang);
            this.grThongTinKhachHang.Controls.Add(this.txtMaKjhachHang);
            this.grThongTinKhachHang.Controls.Add(this.lbTenKhachHang);
            this.grThongTinKhachHang.Controls.Add(this.lbMaKhachHang);
            this.grThongTinKhachHang.Controls.Add(this.cmbHangKhachHang);
            this.grThongTinKhachHang.Controls.Add(this.txtTenKhachHang);
            this.grThongTinKhachHang.Location = new System.Drawing.Point(12, 182);
            this.grThongTinKhachHang.Name = "grThongTinKhachHang";
            this.grThongTinKhachHang.Size = new System.Drawing.Size(1225, 146);
            this.grThongTinKhachHang.TabIndex = 2;
            this.grThongTinKhachHang.Text = "Thông Tin Khách Hàng";
            // 
            // txtDiemKhachHang
            // 
            this.txtDiemKhachHang.Location = new System.Drawing.Point(566, 35);
            this.txtDiemKhachHang.MenuManager = this.ribbonControlKhachHang;
            this.txtDiemKhachHang.Name = "txtDiemKhachHang";
            this.txtDiemKhachHang.Properties.Mask.BeepOnError = true;
            this.txtDiemKhachHang.Properties.Mask.EditMask = "d";
            this.txtDiemKhachHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiemKhachHang.Size = new System.Drawing.Size(179, 20);
            this.txtDiemKhachHang.TabIndex = 8;
            // 
            // lbHangKhachHang
            // 
            this.lbHangKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHangKhachHang.Appearance.Options.UseFont = true;
            this.lbHangKhachHang.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbHangKhachHang.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbHangKhachHang.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbHangKhachHang.LineVisible = true;
            this.lbHangKhachHang.Location = new System.Drawing.Point(448, 87);
            this.lbHangKhachHang.Name = "lbHangKhachHang";
            this.lbHangKhachHang.Size = new System.Drawing.Size(33, 16);
            this.lbHangKhachHang.TabIndex = 7;
            this.lbHangKhachHang.Text = "Hạng";
            // 
            // lbDiemKhachHang
            // 
            this.lbDiemKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemKhachHang.Appearance.Options.UseFont = true;
            this.lbDiemKhachHang.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbDiemKhachHang.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbDiemKhachHang.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbDiemKhachHang.LineVisible = true;
            this.lbDiemKhachHang.Location = new System.Drawing.Point(448, 33);
            this.lbDiemKhachHang.Name = "lbDiemKhachHang";
            this.lbDiemKhachHang.Size = new System.Drawing.Size(32, 16);
            this.lbDiemKhachHang.TabIndex = 6;
            this.lbDiemKhachHang.Text = "Điểm";
            // 
            // txtMaKjhachHang
            // 
            this.txtMaKjhachHang.Location = new System.Drawing.Point(123, 35);
            this.txtMaKjhachHang.MenuManager = this.ribbonControlKhachHang;
            this.txtMaKjhachHang.Name = "txtMaKjhachHang";
            this.txtMaKjhachHang.Properties.Mask.EditMask = "\\d?\\d?/\\d?\\d?/\\d\\d";
            this.txtMaKjhachHang.Size = new System.Drawing.Size(214, 20);
            this.txtMaKjhachHang.TabIndex = 3;
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhachHang.Appearance.Options.UseFont = true;
            this.lbTenKhachHang.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbTenKhachHang.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbTenKhachHang.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbTenKhachHang.LineVisible = true;
            this.lbTenKhachHang.Location = new System.Drawing.Point(5, 87);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(103, 16);
            this.lbTenKhachHang.TabIndex = 1;
            this.lbTenKhachHang.Text = "Tên Khách Hàng";
            // 
            // lbMaKhachHang
            // 
            this.lbMaKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhachHang.Appearance.Options.UseFont = true;
            this.lbMaKhachHang.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbMaKhachHang.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbMaKhachHang.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbMaKhachHang.LineVisible = true;
            this.lbMaKhachHang.Location = new System.Drawing.Point(5, 33);
            this.lbMaKhachHang.Name = "lbMaKhachHang";
            this.lbMaKhachHang.Size = new System.Drawing.Size(99, 16);
            this.lbMaKhachHang.TabIndex = 0;
            this.lbMaKhachHang.Text = "Mã Khách Hàng";
            // 
            // cmbHangKhachHang
            // 
            this.cmbHangKhachHang.Location = new System.Drawing.Point(566, 89);
            this.cmbHangKhachHang.MenuManager = this.ribbonControlKhachHang;
            this.cmbHangKhachHang.Name = "cmbHangKhachHang";
            this.cmbHangKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbHangKhachHang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cmbHangKhachHang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cmbHangKhachHang.Size = new System.Drawing.Size(179, 20);
            this.cmbHangKhachHang.TabIndex = 9;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(123, 89);
            this.txtTenKhachHang.MenuManager = this.ribbonControlKhachHang;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTenKhachHang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTenKhachHang.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtTenKhachHang.Properties.Mask.BeepOnError = true;
            this.txtTenKhachHang.Properties.Mask.EditMask = "@\"^[a-zA-Z ]*$\"";
            this.txtTenKhachHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTenKhachHang.Size = new System.Drawing.Size(214, 20);
            this.txtTenKhachHang.TabIndex = 4;
            // 
            // gridKhachHang
            // 
            this.gridKhachHang.Location = new System.Drawing.Point(12, 350);
            this.gridKhachHang.MainView = this.gridView1;
            this.gridKhachHang.MenuManager = this.ribbonControlKhachHang;
            this.gridKhachHang.Name = "gridKhachHang";
            this.gridKhachHang.Size = new System.Drawing.Size(1225, 256);
            this.gridKhachHang.TabIndex = 3;
            this.gridKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridKhachHang;
            this.gridView1.Name = "gridView1";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 618);
            this.Controls.Add(this.gridKhachHang);
            this.Controls.Add(this.grThongTinKhachHang);
            this.Controls.Add(this.ribbonControlKhachHang);
            this.Name = "frmKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinKhachHang)).EndInit();
            this.grThongTinKhachHang.ResumeLayout(false);
            this.grThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKjhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHangKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonThaoTac;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnThemKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnXoaKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnXuatThongTin;
        private DevExpress.XtraBars.BarButtonGroup btnGroup_;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlKhachHang;
        private DevExpress.XtraEditors.GroupControl grThongTinKhachHang;
        private DevExpress.XtraEditors.TextEdit txtDiemKhachHang;
        private DevExpress.XtraEditors.LabelControl lbHangKhachHang;
        private DevExpress.XtraEditors.LabelControl lbDiemKhachHang;
        private DevExpress.XtraEditors.TextEdit txtMaKjhachHang;
        private DevExpress.XtraEditors.LabelControl lbTenKhachHang;
        private DevExpress.XtraEditors.LabelControl lbMaKhachHang;
        private DevExpress.XtraEditors.ComboBoxEdit cmbHangKhachHang;
        private DevExpress.XtraEditors.TextEdit txtTenKhachHang;
        private DevExpress.XtraGrid.GridControl gridKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}