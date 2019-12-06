namespace QLST
{
    partial class frmEditHang
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
            this.cmbTenHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtDiem = new DevExpress.XtraEditors.TextEdit();
            this.txtChietKhau = new DevExpress.XtraEditors.TextEdit();
            this.lbLuongTheoCa = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaHang = new DevExpress.XtraEditors.TextEdit();
            this.lbChietKhauHangBac = new DevExpress.XtraEditors.LabelControl();
            this.lbChietKhauHangVang = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTIn)).BeginInit();
            this.groupThongTIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChietKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupThongTIn
            // 
            this.groupThongTIn.Controls.Add(this.cmbTenHang);
            this.groupThongTIn.Controls.Add(this.txtDiem);
            this.groupThongTIn.Controls.Add(this.txtChietKhau);
            this.groupThongTIn.Controls.Add(this.lbLuongTheoCa);
            this.groupThongTIn.Controls.Add(this.labelControl2);
            this.groupThongTIn.Controls.Add(this.txtMaHang);
            this.groupThongTIn.Controls.Add(this.lbChietKhauHangBac);
            this.groupThongTIn.Controls.Add(this.lbChietKhauHangVang);
            this.groupThongTIn.Location = new System.Drawing.Point(12, 12);
            this.groupThongTIn.Name = "groupThongTIn";
            this.groupThongTIn.Size = new System.Drawing.Size(731, 223);
            this.groupThongTIn.TabIndex = 15;
            this.groupThongTIn.Text = "Quy Định";
            // 
            // cmbTenHang
            // 
            this.cmbTenHang.DisplayMember = "Text";
            this.cmbTenHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenHang.FormattingEnabled = true;
            this.cmbTenHang.ItemHeight = 16;
            this.cmbTenHang.Location = new System.Drawing.Point(199, 81);
            this.cmbTenHang.Name = "cmbTenHang";
            this.cmbTenHang.Size = new System.Drawing.Size(214, 22);
            this.cmbTenHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbTenHang.TabIndex = 13;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(199, 188);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Properties.Mask.EditMask = "n";
            this.txtDiem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiem.Size = new System.Drawing.Size(214, 20);
            this.txtDiem.TabIndex = 12;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(199, 134);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Properties.Mask.EditMask = "n";
            this.txtChietKhau.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtChietKhau.Size = new System.Drawing.Size(214, 20);
            this.txtChietKhau.TabIndex = 11;
            // 
            // lbLuongTheoCa
            // 
            this.lbLuongTheoCa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuongTheoCa.Appearance.Options.UseFont = true;
            this.lbLuongTheoCa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbLuongTheoCa.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbLuongTheoCa.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbLuongTheoCa.LineVisible = true;
            this.lbLuongTheoCa.Location = new System.Drawing.Point(13, 192);
            this.lbLuongTheoCa.Name = "lbLuongTheoCa";
            this.lbLuongTheoCa.Size = new System.Drawing.Size(32, 16);
            this.lbLuongTheoCa.TabIndex = 10;
            this.lbLuongTheoCa.Text = "Điểm";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 16);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Chiết Khấu (%)";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Location = new System.Drawing.Point(199, 32);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Properties.Mask.BeepOnError = true;
            this.txtMaHang.Properties.Mask.EditMask = "n";
            this.txtMaHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMaHang.Size = new System.Drawing.Size(214, 20);
            this.txtMaHang.TabIndex = 7;
            // 
            // lbChietKhauHangBac
            // 
            this.lbChietKhauHangBac.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChietKhauHangBac.Appearance.Options.UseFont = true;
            this.lbChietKhauHangBac.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbChietKhauHangBac.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbChietKhauHangBac.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbChietKhauHangBac.LineVisible = true;
            this.lbChietKhauHangBac.Location = new System.Drawing.Point(13, 87);
            this.lbChietKhauHangBac.Name = "lbChietKhauHangBac";
            this.lbChietKhauHangBac.Size = new System.Drawing.Size(60, 16);
            this.lbChietKhauHangBac.TabIndex = 6;
            this.lbChietKhauHangBac.Text = "Tên Hạng";
            // 
            // lbChietKhauHangVang
            // 
            this.lbChietKhauHangVang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChietKhauHangVang.Appearance.Options.UseFont = true;
            this.lbChietKhauHangVang.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbChietKhauHangVang.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbChietKhauHangVang.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbChietKhauHangVang.LineVisible = true;
            this.lbChietKhauHangVang.Location = new System.Drawing.Point(13, 33);
            this.lbChietKhauHangVang.Name = "lbChietKhauHangVang";
            this.lbChietKhauHangVang.Size = new System.Drawing.Size(56, 16);
            this.lbChietKhauHangVang.TabIndex = 5;
            this.lbChietKhauHangVang.Text = "Mã Hạng";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(572, 254);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(668, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // frmEditHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 284);
            this.Controls.Add(this.groupThongTIn);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmEditHang";
            this.Text = "Edit Hạng";
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTIn)).EndInit();
            this.groupThongTIn.ResumeLayout(false);
            this.groupThongTIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChietKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupThongTIn;
        private DevExpress.XtraEditors.TextEdit txtDiem;
        private DevExpress.XtraEditors.TextEdit txtChietKhau;
        private DevExpress.XtraEditors.LabelControl lbLuongTheoCa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaHang;
        private DevExpress.XtraEditors.LabelControl lbChietKhauHangBac;
        private DevExpress.XtraEditors.LabelControl lbChietKhauHangVang;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTenHang;
    }
}

