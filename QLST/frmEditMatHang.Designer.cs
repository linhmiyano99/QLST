namespace QLST
{
    partial class frmEditMatHang
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
            this.groupThongTIn = new DevExpress.XtraEditors.GroupControl();
            this.txtGiaNhap = new DevExpress.XtraEditors.TextEdit();
            this.lbLuongTheoCa = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.lbChietKhauHangBac = new DevExpress.XtraEditors.LabelControl();
            this.lbChietKhauHangVang = new DevExpress.XtraEditors.LabelControl();
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtGiaBan = new DevExpress.XtraEditors.TextEdit();
            this.txtTonToiDa = new DevExpress.XtraEditors.TextEdit();
            this.txtTonToiThieu = new DevExpress.XtraEditors.TextEdit();
            this.lblTonToiDa = new DevExpress.XtraEditors.LabelControl();
            this.lblTonToiThieu = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTIn)).BeginInit();
            this.groupThongTIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTonToiDa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTonToiThieu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupThongTIn
            // 
            this.groupThongTIn.Controls.Add(this.txtTonToiDa);
            this.groupThongTIn.Controls.Add(this.txtTonToiThieu);
            this.groupThongTIn.Controls.Add(this.lblTonToiDa);
            this.groupThongTIn.Controls.Add(this.lblTonToiThieu);
            this.groupThongTIn.Controls.Add(this.txtGiaBan);
            this.groupThongTIn.Controls.Add(this.txtGiaNhap);
            this.groupThongTIn.Controls.Add(this.lbLuongTheoCa);
            this.groupThongTIn.Controls.Add(this.labelControl2);
            this.groupThongTIn.Controls.Add(this.txtMaMH);
            this.groupThongTIn.Controls.Add(this.lbChietKhauHangBac);
            this.groupThongTIn.Controls.Add(this.lbChietKhauHangVang);
            this.groupThongTIn.Controls.Add(this.txtTenMH);
            this.groupThongTIn.Location = new System.Drawing.Point(59, 54);
            this.groupThongTIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupThongTIn.Name = "groupThongTIn";
            this.groupThongTIn.Size = new System.Drawing.Size(992, 274);
            this.groupThongTIn.TabIndex = 15;
            this.groupThongTIn.Text = "Quy Định";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(232, 169);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Properties.Mask.EditMask = "n";
            this.txtGiaNhap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGiaNhap.Size = new System.Drawing.Size(250, 22);
            this.txtGiaNhap.TabIndex = 11;
            // 
            // lbLuongTheoCa
            // 
            this.lbLuongTheoCa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuongTheoCa.Appearance.Options.UseFont = true;
            this.lbLuongTheoCa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbLuongTheoCa.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbLuongTheoCa.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbLuongTheoCa.LineVisible = true;
            this.lbLuongTheoCa.Location = new System.Drawing.Point(15, 236);
            this.lbLuongTheoCa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbLuongTheoCa.Name = "lbLuongTheoCa";
            this.lbLuongTheoCa.Size = new System.Drawing.Size(62, 19);
            this.lbLuongTheoCa.TabIndex = 10;
            this.lbLuongTheoCa.Text = "Giá bán";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 170);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 21);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Giá nhập";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(232, 39);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Properties.Mask.BeepOnError = true;
            this.txtMaMH.Properties.Mask.EditMask = "n";
            this.txtMaMH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMaMH.Size = new System.Drawing.Size(250, 22);
            this.txtMaMH.TabIndex = 7;
            // 
            // lbChietKhauHangBac
            // 
            this.lbChietKhauHangBac.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChietKhauHangBac.Appearance.Options.UseFont = true;
            this.lbChietKhauHangBac.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbChietKhauHangBac.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbChietKhauHangBac.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbChietKhauHangBac.LineVisible = true;
            this.lbChietKhauHangBac.Location = new System.Drawing.Point(15, 107);
            this.lbChietKhauHangBac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbChietKhauHangBac.Name = "lbChietKhauHangBac";
            this.lbChietKhauHangBac.Size = new System.Drawing.Size(117, 21);
            this.lbChietKhauHangBac.TabIndex = 6;
            this.lbChietKhauHangBac.Text = "Tên mặt hàng";
            // 
            // lbChietKhauHangVang
            // 
            this.lbChietKhauHangVang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChietKhauHangVang.Appearance.Options.UseFont = true;
            this.lbChietKhauHangVang.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbChietKhauHangVang.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbChietKhauHangVang.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbChietKhauHangVang.LineVisible = true;
            this.lbChietKhauHangVang.Location = new System.Drawing.Point(15, 41);
            this.lbChietKhauHangVang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbChietKhauHangVang.Name = "lbChietKhauHangVang";
            this.lbChietKhauHangVang.Size = new System.Drawing.Size(111, 21);
            this.lbChietKhauHangVang.TabIndex = 5;
            this.lbChietKhauHangVang.Text = "Mã mặt hàng";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(232, 106);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTenMH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTenMH.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtTenMH.Properties.Mask.BeepOnError = true;
            this.txtTenMH.Size = new System.Drawing.Size(250, 22);
            this.txtTenMH.TabIndex = 8;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(712, 352);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 28);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(btnLuu_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(824, 352);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 28);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(232, 233);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Properties.Mask.EditMask = "n";
            this.txtGiaBan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGiaBan.Size = new System.Drawing.Size(250, 22);
            this.txtGiaBan.TabIndex = 12;
            // 
            // txtTonToiDa
            // 
            this.txtTonToiDa.Location = new System.Drawing.Point(737, 102);
            this.txtTonToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTonToiDa.Name = "txtTonToiDa";
            this.txtTonToiDa.Properties.Mask.EditMask = "n";
            this.txtTonToiDa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTonToiDa.Size = new System.Drawing.Size(250, 22);
            this.txtTonToiDa.TabIndex = 16;
            // 
            // txtTonToiThieu
            // 
            this.txtTonToiThieu.Location = new System.Drawing.Point(737, 38);
            this.txtTonToiThieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTonToiThieu.Name = "txtTonToiThieu";
            this.txtTonToiThieu.Properties.Mask.EditMask = "n";
            this.txtTonToiThieu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTonToiThieu.Size = new System.Drawing.Size(250, 22);
            this.txtTonToiThieu.TabIndex = 15;
            // 
            // lblTonToiDa
            // 
            this.lblTonToiDa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonToiDa.Appearance.Options.UseFont = true;
            this.lblTonToiDa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblTonToiDa.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblTonToiDa.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lblTonToiDa.LineVisible = true;
            this.lblTonToiDa.Location = new System.Drawing.Point(520, 105);
            this.lblTonToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTonToiDa.Name = "lblTonToiDa";
            this.lblTonToiDa.Size = new System.Drawing.Size(86, 21);
            this.lblTonToiDa.TabIndex = 14;
            this.lblTonToiDa.Text = "Tồn tối đa";
            // 
            // lblTonToiThieu
            // 
            this.lblTonToiThieu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonToiThieu.Appearance.Options.UseFont = true;
            this.lblTonToiThieu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblTonToiThieu.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblTonToiThieu.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lblTonToiThieu.LineVisible = true;
            this.lblTonToiThieu.Location = new System.Drawing.Point(520, 39);
            this.lblTonToiThieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTonToiThieu.Name = "lblTonToiThieu";
            this.lblTonToiThieu.Size = new System.Drawing.Size(109, 21);
            this.lblTonToiThieu.TabIndex = 13;
            this.lblTonToiThieu.Text = "Tồn tối thiểu";
            // 
            // frmEditMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 452);
            this.Controls.Add(this.groupThongTIn);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmEditMatHang";
            this.Text = "frmEditMatHang";
            this.Load += new System.EventHandler(this.frmEditMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTIn)).EndInit();
            this.groupThongTIn.ResumeLayout(false);
            this.groupThongTIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTonToiDa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTonToiThieu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupThongTIn;
        private DevExpress.XtraEditors.TextEdit txtGiaNhap;
        private DevExpress.XtraEditors.LabelControl lbLuongTheoCa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.LabelControl lbChietKhauHangBac;
        private DevExpress.XtraEditors.LabelControl lbChietKhauHangVang;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtTonToiDa;
        private DevExpress.XtraEditors.TextEdit txtTonToiThieu;
        private DevExpress.XtraEditors.LabelControl lblTonToiDa;
        private DevExpress.XtraEditors.LabelControl lblTonToiThieu;
        private DevExpress.XtraEditors.TextEdit txtGiaBan;
    }
}