
﻿using System.Drawing;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
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
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonControlKhachHang = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnGroup_ = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.lbSearch = new DevExpress.XtraEditors.LabelControl();
            this.gridViewKhachHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewKhachHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).BeginInit();
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
            this.ribbonPageGroup4});
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
            this.btnXoaKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaKhachHang_ItemClick);
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
            this.btnXuatThongTin.ImageOptions.Image = global::QLST.Properties.Resources.exporttopdf_16x162;
            this.btnXuatThongTin.ImageOptions.LargeImage = global::QLST.Properties.Resources.exporttopdf_32x323;
            this.btnXuatThongTin.Name = "btnXuatThongTin";
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
            this.btnXuatThongTin});
            this.ribbonControlKhachHang.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlKhachHang.MaxItemId = 11;
            this.ribbonControlKhachHang.Name = "ribbonControlKhachHang";
            this.ribbonControlKhachHang.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonThaoTac});
            this.ribbonControlKhachHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbonControlKhachHang.Size = new System.Drawing.Size(1249, 162);
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(428, 104);
            this.txtSearch.MenuManager = this.ribbonControlKhachHang;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 20);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Appearance.Options.UseFont = true;
            this.lbSearch.LineVisible = true;
            this.lbSearch.Location = new System.Drawing.Point(369, 107);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(41, 13);
            this.lbSearch.TabIndex = 19;
            this.lbSearch.Text = "Tìm Kiếm";
            // 
            // gridViewKhachHang
            // 
            this.gridViewKhachHang.Location = new System.Drawing.Point(0, 0);
            this.gridViewKhachHang.Name = "gridViewKhachHang";
            this.gridViewKhachHang.Size = new System.Drawing.Size(240, 150);
            this.gridViewKhachHang.TabIndex = 0;
            // 
            // dataGridViewKhachHang
            // 
            this.dataGridViewKhachHang.AllowUserToAddRows = false;
            this.dataGridViewKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKhachHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewKhachHang.Location = new System.Drawing.Point(12, 168);
            this.dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            this.dataGridViewKhachHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhachHang.Size = new System.Drawing.Size(1225, 438);
            this.dataGridViewKhachHang.TabIndex = 25;
            this.dataGridViewKhachHang.AllowUserToAddRowsChanged += new System.EventHandler(this.dataGridViewKhachHang_AllowUserToAddRowsChanged);
            this.dataGridViewKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhachHang_CellClick);
            this.dataGridViewKhachHang.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhachHang_CellContentDoubleClick);
            this.dataGridViewKhachHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhachHang_CellValueChanged);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 615);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewKhachHang);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ribbonControlKhachHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhachHang";
            this.Ribbon = this.ribbonControlKhachHang;
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).EndInit();
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

        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl lbSearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridViewKhachHang;

        public DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewKhachHang;

    }
}