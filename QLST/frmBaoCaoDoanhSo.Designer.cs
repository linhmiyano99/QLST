namespace QLST
{
    partial class frmBaoCaoDoanhSo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBaoCaoDoanhSo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTienTongCong = new DevExpress.XtraEditors.TextEdit();
            this.lbTienKhachDua = new DevComponents.DotNetBar.LabelX();
            this.dtiTuNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblTuNgay = new DevComponents.DotNetBar.LabelX();
            this.lblDenNgay = new DevComponents.DotNetBar.LabelX();
            this.dtiDenNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoDoanhSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienTongCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiTuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiDenNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBaoCaoDoanhSo
            // 
            this.dataGridViewBaoCaoDoanhSo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBaoCaoDoanhSo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBaoCaoDoanhSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewBaoCaoDoanhSo.Location = new System.Drawing.Point(20, 212);
            this.dataGridViewBaoCaoDoanhSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBaoCaoDoanhSo.Name = "dataGridViewBaoCaoDoanhSo";
            this.dataGridViewBaoCaoDoanhSo.RowHeadersWidth = 51;
            this.dataGridViewBaoCaoDoanhSo.RowTemplate.Height = 24;
            this.dataGridViewBaoCaoDoanhSo.Size = new System.Drawing.Size(1218, 357);
            this.dataGridViewBaoCaoDoanhSo.TabIndex = 8;
            this.dataGridViewBaoCaoDoanhSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBaoCaoDoanhSo_CellClick);
            // 
            // txtTienTongCong
            // 
            this.txtTienTongCong.Location = new System.Drawing.Point(728, 101);
            this.txtTienTongCong.Name = "txtTienTongCong";
            this.txtTienTongCong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienTongCong.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtTienTongCong.Properties.Appearance.Options.UseFont = true;
            this.txtTienTongCong.Properties.Appearance.Options.UseForeColor = true;
            this.txtTienTongCong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTienTongCong.Properties.ReadOnly = true;
            this.txtTienTongCong.Size = new System.Drawing.Size(255, 26);
            this.txtTienTongCong.TabIndex = 27;
            // 
            // lbTienKhachDua
            // 
            // 
            // 
            // 
            this.lbTienKhachDua.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTienKhachDua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienKhachDua.ForeColor = System.Drawing.Color.Green;
            this.lbTienKhachDua.Location = new System.Drawing.Point(644, 101);
            this.lbTienKhachDua.Name = "lbTienKhachDua";
            this.lbTienKhachDua.SingleLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTienKhachDua.Size = new System.Drawing.Size(80, 28);
            this.lbTienKhachDua.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lbTienKhachDua.TabIndex = 28;
            this.lbTienKhachDua.Text = "Doanh thu";
            // 
            // dtiTuNgay
            // 
            // 
            // 
            // 
            this.dtiTuNgay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiTuNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiTuNgay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiTuNgay.ButtonDropDown.Visible = true;
            this.dtiTuNgay.IsPopupCalendarOpen = false;
            this.dtiTuNgay.Location = new System.Drawing.Point(370, 104);
            this.dtiTuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtiTuNgay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiTuNgay.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtiTuNgay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiTuNgay.MonthCalendar.DisplayMonth = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtiTuNgay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiTuNgay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiTuNgay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiTuNgay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiTuNgay.MonthCalendar.TodayButtonVisible = true;
            this.dtiTuNgay.Name = "dtiTuNgay";
            this.dtiTuNgay.Size = new System.Drawing.Size(160, 21);
            this.dtiTuNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiTuNgay.TabIndex = 34;
            this.dtiTuNgay.Click += new System.EventHandler(this.dtiTuNgay_Click);
            // 
            // lblTuNgay
            // 
            // 
            // 
            // 
            this.lblTuNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTuNgay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.ForeColor = System.Drawing.Color.Green;
            this.lblTuNgay.Location = new System.Drawing.Point(285, 95);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.SingleLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTuNgay.Size = new System.Drawing.Size(80, 28);
            this.lblTuNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lblTuNgay.TabIndex = 35;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // lblDenNgay
            // 
            // 
            // 
            // 
            this.lblDenNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDenNgay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.ForeColor = System.Drawing.Color.Green;
            this.lblDenNgay.Location = new System.Drawing.Point(285, 153);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.SingleLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDenNgay.Size = new System.Drawing.Size(80, 28);
            this.lblDenNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lblDenNgay.TabIndex = 37;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // dtiDenNgay
            // 
            // 
            // 
            // 
            this.dtiDenNgay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiDenNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDenNgay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiDenNgay.ButtonDropDown.Visible = true;
            this.dtiDenNgay.IsPopupCalendarOpen = false;
            this.dtiDenNgay.Location = new System.Drawing.Point(370, 162);
            this.dtiDenNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtiDenNgay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDenNgay.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtiDenNgay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDenNgay.MonthCalendar.DisplayMonth = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtiDenNgay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiDenNgay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiDenNgay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiDenNgay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDenNgay.MonthCalendar.TodayButtonVisible = true;
            this.dtiDenNgay.Name = "dtiDenNgay";
            this.dtiDenNgay.Size = new System.Drawing.Size(160, 21);
            this.dtiDenNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiDenNgay.TabIndex = 36;
            this.dtiDenNgay.Click += new System.EventHandler(this.dtiDenNgay_Click);
            // 
            // frmBaoCaoDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 580);
            this.ControlBox = false;
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.dtiDenNgay);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.dtiTuNgay);
            this.Controls.Add(this.lbTienKhachDua);
            this.Controls.Add(this.txtTienTongCong);
            this.Controls.Add(this.dataGridViewBaoCaoDoanhSo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBaoCaoDoanhSo";
            this.Text = "Báo Cáo Doanh Số";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoDoanhSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienTongCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiTuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiDenNgay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewBaoCaoDoanhSo;
        private DevExpress.XtraEditors.TextEdit txtTienTongCong;
        private DevComponents.DotNetBar.LabelX lbTienKhachDua;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiTuNgay;
        private DevComponents.DotNetBar.LabelX lblTuNgay;
        private DevComponents.DotNetBar.LabelX lblDenNgay;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiDenNgay;
    }
}