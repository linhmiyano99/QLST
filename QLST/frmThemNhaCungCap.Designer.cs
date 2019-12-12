namespace QLST
{
    partial class frmThemNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhaCungCap));
            this.groupThongTIn = new DevExpress.XtraEditors.GroupControl();
            this.txtTenNhaCungCap = new DevExpress.XtraEditors.TextEdit();
            this.lbLuongTheoCa = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNCC = new DevExpress.XtraEditors.TextEdit();
            this.lbChietKhauHangVang = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTIn)).BeginInit();
            this.groupThongTIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNCC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupThongTIn
            // 
            this.groupThongTIn.Controls.Add(this.txtTenNhaCungCap);
            this.groupThongTIn.Controls.Add(this.lbLuongTheoCa);
            this.groupThongTIn.Controls.Add(this.txtMaNCC);
            this.groupThongTIn.Controls.Add(this.lbChietKhauHangVang);
            this.groupThongTIn.Location = new System.Drawing.Point(12, 12);
            this.groupThongTIn.Name = "groupThongTIn";
            this.groupThongTIn.Size = new System.Drawing.Size(731, 223);
            this.groupThongTIn.TabIndex = 21;
            this.groupThongTIn.Text = "Quy Định";
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(199, 71);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(214, 20);
            this.txtTenNhaCungCap.TabIndex = 12;
            // 
            // lbLuongTheoCa
            // 
            this.lbLuongTheoCa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuongTheoCa.Appearance.Options.UseFont = true;
            this.lbLuongTheoCa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbLuongTheoCa.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbLuongTheoCa.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbLuongTheoCa.LineVisible = true;
            this.lbLuongTheoCa.Location = new System.Drawing.Point(13, 75);
            this.lbLuongTheoCa.Name = "lbLuongTheoCa";
            this.lbLuongTheoCa.Size = new System.Drawing.Size(115, 16);
            this.lbLuongTheoCa.TabIndex = 10;
            this.lbLuongTheoCa.Text = "Tên Nhà Cung Cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.Location = new System.Drawing.Point(199, 32);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Properties.Mask.BeepOnError = true;
            this.txtMaNCC.Properties.Mask.EditMask = "n";
            this.txtMaNCC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMaNCC.Size = new System.Drawing.Size(214, 20);
            this.txtMaNCC.TabIndex = 7;
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
            this.lbChietKhauHangVang.Size = new System.Drawing.Size(111, 16);
            this.lbChietKhauHangVang.TabIndex = 5;
            this.lbChietKhauHangVang.Text = "Mã Nhà Cung Cấp";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(668, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(572, 254);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmThemNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 294);
            this.Controls.Add(this.groupThongTIn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLuu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemNhaCungCap";
            this.Text = "Thêm Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTIn)).EndInit();
            this.groupThongTIn.ResumeLayout(false);
            this.groupThongTIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNCC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupThongTIn;
        private DevExpress.XtraEditors.TextEdit txtTenNhaCungCap;
        private DevExpress.XtraEditors.LabelControl lbLuongTheoCa;
        private DevExpress.XtraEditors.TextEdit txtMaNCC;
        private DevExpress.XtraEditors.LabelControl lbChietKhauHangVang;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}