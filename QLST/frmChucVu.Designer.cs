namespace QLST
{
    partial class frmChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grThongTinChucVu = new DevExpress.XtraEditors.GroupControl();
            this.txtLuongCa = new DevExpress.XtraEditors.TextEdit();
            this.txtTenChucVu = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCV = new DevExpress.XtraEditors.TextEdit();
            this.lbLuongCa = new DevExpress.XtraEditors.LabelControl();
            this.lbTenChucVu = new DevExpress.XtraEditors.LabelControl();
            this.lbMaCV = new DevExpress.XtraEditors.LabelControl();
            this.dataGridViewChucVu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lbSearch = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinChucVu)).BeginInit();
            this.grThongTinChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
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
            this.btnXuatDanhSach});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1250, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = global::QLST.Properties.Resources.addfile_16x16;
            this.btnThem.ImageOptions.LargeImage = global::QLST.Properties.Resources.addfile_32x321;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::QLST.Properties.Resources.delete_16x16;
            this.btnXoa.ImageOptions.LargeImage = global::QLST.Properties.Resources.delete_32x32;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu thông tin";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = global::QLST.Properties.Resources.save_16x16;
            this.btnLuu.ImageOptions.LargeImage = global::QLST.Properties.Resources.save_32x32;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnXuatDanhSach
            // 
            this.btnXuatDanhSach.Caption = "Xuất danh sách";
            this.btnXuatDanhSach.Id = 4;
            this.btnXuatDanhSach.ImageOptions.Image = global::QLST.Properties.Resources.exporttopdf_16x16;
            this.btnXuatDanhSach.ImageOptions.LargeImage = global::QLST.Properties.Resources.exporttopdf_32x321;
            this.btnXuatDanhSach.Name = "btnXuatDanhSach";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.ImageOptions.SvgImage = global::QLST.Properties.Resources.bo_appointment4;
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
            this.ribbonPageGroup3.ItemLinks.Add(this.btnXuatDanhSach, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Xuất file";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 588);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1250, 31);
            // 
            // grThongTinChucVu
            // 
            this.grThongTinChucVu.Controls.Add(this.txtLuongCa);
            this.grThongTinChucVu.Controls.Add(this.txtTenChucVu);
            this.grThongTinChucVu.Controls.Add(this.txtMaCV);
            this.grThongTinChucVu.Controls.Add(this.lbLuongCa);
            this.grThongTinChucVu.Controls.Add(this.lbTenChucVu);
            this.grThongTinChucVu.Controls.Add(this.lbMaCV);
            this.grThongTinChucVu.Location = new System.Drawing.Point(12, 168);
            this.grThongTinChucVu.Name = "grThongTinChucVu";
            this.grThongTinChucVu.Size = new System.Drawing.Size(1226, 90);
            this.grThongTinChucVu.TabIndex = 2;
            this.grThongTinChucVu.Text = "Thông tin chức vụ";
            // 
            // txtLuongCa
            // 
            this.txtLuongCa.Location = new System.Drawing.Point(841, 34);
            this.txtLuongCa.MenuManager = this.ribbon;
            this.txtLuongCa.Name = "txtLuongCa";
            this.txtLuongCa.Size = new System.Drawing.Size(159, 20);
            this.txtLuongCa.TabIndex = 5;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Location = new System.Drawing.Point(502, 34);
            this.txtTenChucVu.MenuManager = this.ribbon;
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(159, 20);
            this.txtTenChucVu.TabIndex = 4;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(150, 33);
            this.txtMaCV.MenuManager = this.ribbon;
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(159, 20);
            this.txtMaCV.TabIndex = 3;
            // 
            // lbLuongCa
            // 
            this.lbLuongCa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuongCa.Appearance.Options.UseFont = true;
            this.lbLuongCa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbLuongCa.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbLuongCa.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbLuongCa.LineVisible = true;
            this.lbLuongCa.Location = new System.Drawing.Point(735, 34);
            this.lbLuongCa.Name = "lbLuongCa";
            this.lbLuongCa.Size = new System.Drawing.Size(64, 16);
            this.lbLuongCa.TabIndex = 2;
            this.lbLuongCa.Text = "Lương ca:";
            // 
            // lbTenChucVu
            // 
            this.lbTenChucVu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenChucVu.Appearance.Options.UseFont = true;
            this.lbTenChucVu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbTenChucVu.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbTenChucVu.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbTenChucVu.LineVisible = true;
            this.lbTenChucVu.Location = new System.Drawing.Point(386, 35);
            this.lbTenChucVu.Name = "lbTenChucVu";
            this.lbTenChucVu.Size = new System.Drawing.Size(83, 16);
            this.lbTenChucVu.TabIndex = 1;
            this.lbTenChucVu.Text = "Tên chức vụ:";
            // 
            // lbMaCV
            // 
            this.lbMaCV.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaCV.Appearance.Options.UseFont = true;
            this.lbMaCV.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbMaCV.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbMaCV.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbMaCV.LineVisible = true;
            this.lbMaCV.Location = new System.Drawing.Point(35, 34);
            this.lbMaCV.Name = "lbMaCV";
            this.lbMaCV.Size = new System.Drawing.Size(79, 16);
            this.lbMaCV.TabIndex = 0;
            this.lbMaCV.Text = "Mã chức vụ:";
            // 
            // dataGridViewChucVu
            // 
            this.dataGridViewChucVu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewChucVu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChucVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewChucVu.Location = new System.Drawing.Point(12, 277);
            this.dataGridViewChucVu.Name = "dataGridViewChucVu";
            this.dataGridViewChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChucVu.Size = new System.Drawing.Size(1226, 300);
            this.dataGridViewChucVu.TabIndex = 8;
            this.dataGridViewChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChucVu_CellClick);
            // 
            // lbSearch
            // 
            this.lbSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Appearance.Options.UseFont = true;
            this.lbSearch.LineVisible = true;
            this.lbSearch.Location = new System.Drawing.Point(313, 96);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(41, 13);
            this.lbSearch.TabIndex = 21;
            this.lbSearch.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(372, 93);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged_1);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 619);
            this.ControlBox = false;
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridViewChucVu);
            this.Controls.Add(this.grThongTinChucVu);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChucVu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Chức vụ";
            this.Load += new System.EventHandler(this.frmChucVu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinChucVu)).EndInit();
            this.grThongTinChucVu.ResumeLayout(false);
            this.grThongTinChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnXuatDanhSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.GroupControl grThongTinChucVu;
        private DevExpress.XtraEditors.LabelControl lbLuongCa;
        private DevExpress.XtraEditors.LabelControl lbTenChucVu;
        private DevExpress.XtraEditors.LabelControl lbMaCV;
        private DevExpress.XtraEditors.TextEdit txtLuongCa;
        private DevExpress.XtraEditors.TextEdit txtTenChucVu;
        private DevExpress.XtraEditors.TextEdit txtMaCV;
        public DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewChucVu;
        private DevExpress.XtraEditors.LabelControl lbSearch;
        private DevExpress.XtraEditors.TextEdit txtSearch;
    }
}