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
            this.gridKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridViewKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
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
            this.btnThemKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemKhachHang_ItemClick);
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.Caption = "Xóa Khách Hàng";
            this.btnXoaKhachHang.Id = 4;
            this.btnXoaKhachHang.ImageOptions.Image = global::QLST.Properties.Resources.delete_16x16;
            this.btnXoaKhachHang.ImageOptions.LargeImage = global::QLST.Properties.Resources.delete_32x32;
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
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
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
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
            this.barButtonItem4.Caption = "Xuất Thông Tin";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // gridKhachHang
            // 
            this.gridKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKhachHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridKhachHang.Location = new System.Drawing.Point(0, 0);
            this.gridKhachHang.MainView = this.gridViewKhachHang;
            this.gridKhachHang.MenuManager = this.ribbonControlKhachHang;
            this.gridKhachHang.Name = "gridKhachHang";
            this.gridKhachHang.Size = new System.Drawing.Size(1225, 440);
            this.gridKhachHang.TabIndex = 13;
            this.gridKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKhachHang});
            // 
            // gridViewKhachHang
            // 
            this.gridViewKhachHang.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewKhachHang.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewKhachHang.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewKhachHang.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridViewKhachHang.ChildGridLevelName = "Detail";
            this.gridViewKhachHang.GridControl = this.gridKhachHang;
            this.gridViewKhachHang.Name = "gridViewKhachHang";
            this.gridViewKhachHang.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewKhachHang.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewKhachHang.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewKhachHang.OptionsEditForm.EditFormColumnCount = 4;
            this.gridViewKhachHang.OptionsView.ShowFooter = true;
            this.gridViewKhachHang.ViewCaption = "Danh Sách Khách Hàng";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridKhachHang;
            this.gridSplitContainer1.Horizontal = true;
            this.gridSplitContainer1.Location = new System.Drawing.Point(12, 166);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridKhachHang);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1225, 440);
            this.gridSplitContainer1.TabIndex = 15;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 618);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.ribbonControlKhachHang);
            this.Name = "frmKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.GridControl gridKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKhachHang;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
       
    }
}