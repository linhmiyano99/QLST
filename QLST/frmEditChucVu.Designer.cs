namespace QLST
{
    partial class frmEditChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditChucVu));
            this.grThongTinChucVu = new DevExpress.XtraEditors.GroupControl();
            this.cmbTenChucVu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtLuongCa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCV = new DevExpress.XtraEditors.TextEdit();
            this.lbLuongCa = new DevExpress.XtraEditors.LabelControl();
            this.lbTenChucVu = new DevExpress.XtraEditors.LabelControl();
            this.lbMaCV = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinChucVu)).BeginInit();
            this.grThongTinChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongTinChucVu
            // 
            this.grThongTinChucVu.Controls.Add(this.cmbTenChucVu);
            this.grThongTinChucVu.Controls.Add(this.txtLuongCa);
            this.grThongTinChucVu.Controls.Add(this.txtMaCV);
            this.grThongTinChucVu.Controls.Add(this.lbLuongCa);
            this.grThongTinChucVu.Controls.Add(this.lbTenChucVu);
            this.grThongTinChucVu.Controls.Add(this.lbMaCV);
            this.grThongTinChucVu.Location = new System.Drawing.Point(12, 12);
            this.grThongTinChucVu.Name = "grThongTinChucVu";
            this.grThongTinChucVu.Size = new System.Drawing.Size(1047, 90);
            this.grThongTinChucVu.TabIndex = 3;
            this.grThongTinChucVu.Text = "Thông tin chức vụ";
            // 
            // cmbTenChucVu
            // 
            this.cmbTenChucVu.DisplayMember = "Text";
            this.cmbTenChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenChucVu.FormattingEnabled = true;
            this.cmbTenChucVu.ItemHeight = 16;
            this.cmbTenChucVu.Location = new System.Drawing.Point(488, 35);
            this.cmbTenChucVu.Name = "cmbTenChucVu";
            this.cmbTenChucVu.Size = new System.Drawing.Size(196, 22);
            this.cmbTenChucVu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbTenChucVu.TabIndex = 6;
            // 
            // txtLuongCa
            // 
            this.txtLuongCa.Location = new System.Drawing.Point(841, 34);
            this.txtLuongCa.Name = "txtLuongCa";
            this.txtLuongCa.Size = new System.Drawing.Size(159, 20);
            this.txtLuongCa.TabIndex = 5;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Enabled = false;
            this.txtMaCV.Location = new System.Drawing.Point(150, 33);
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
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(841, 116);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(937, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 151);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grThongTinChucVu);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditChucVu";
            this.Text = "Edit Chức Vụ";
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinChucVu)).EndInit();
            this.grThongTinChucVu.ResumeLayout(false);
            this.grThongTinChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grThongTinChucVu;
        private DevExpress.XtraEditors.TextEdit txtLuongCa;
        private DevExpress.XtraEditors.TextEdit txtMaCV;
        private DevExpress.XtraEditors.LabelControl lbLuongCa;
        private DevExpress.XtraEditors.LabelControl lbTenChucVu;
        private DevExpress.XtraEditors.LabelControl lbMaCV;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTenChucVu;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}