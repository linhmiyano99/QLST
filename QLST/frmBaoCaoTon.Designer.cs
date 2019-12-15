namespace QLST
{
    partial class frmBaoCaoTon
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
            this.dataGridViewMatHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.lbGiaNhap = new DevExpress.XtraEditors.LabelControl();
            this.lblBaoCaoTon = new DevExpress.XtraEditors.LabelControl();
            this.btnBaoCao = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatHang
            // 
            this.dataGridViewMatHang.AllowUserToAddRows = false;
            this.dataGridViewMatHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMatHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewMatHang.Location = new System.Drawing.Point(9, 214);
            this.dataGridViewMatHang.Name = "dataGridViewMatHang";
            this.dataGridViewMatHang.RowHeadersWidth = 51;
            this.dataGridViewMatHang.RowTemplate.Height = 24;
            this.dataGridViewMatHang.Size = new System.Drawing.Size(1068, 342);
            this.dataGridViewMatHang.TabIndex = 15;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(357, 156);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(168, 22);
            this.txtMaMH.TabIndex = 16;
            this.txtMaMH.EditValueChanged += new System.EventHandler(this.txtSoHoaDon_EditValueChanged);
            // 
            // lbGiaNhap
            // 
            this.lbGiaNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaNhap.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lbGiaNhap.Appearance.Options.UseFont = true;
            this.lbGiaNhap.Appearance.Options.UseForeColor = true;
            this.lbGiaNhap.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbGiaNhap.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbGiaNhap.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbGiaNhap.LineVisible = true;
            this.lbGiaNhap.Location = new System.Drawing.Point(276, 159);
            this.lbGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbGiaNhap.Name = "lbGiaNhap";
            this.lbGiaNhap.Size = new System.Drawing.Size(64, 21);
            this.lbGiaNhap.TabIndex = 17;
            this.lbGiaNhap.Text = "Tra cứu";
            // 
            // lblBaoCaoTon
            // 
            this.lblBaoCaoTon.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCaoTon.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblBaoCaoTon.Appearance.Options.UseFont = true;
            this.lblBaoCaoTon.Appearance.Options.UseForeColor = true;
            this.lblBaoCaoTon.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblBaoCaoTon.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblBaoCaoTon.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lblBaoCaoTon.LineVisible = true;
            this.lblBaoCaoTon.Location = new System.Drawing.Point(453, 46);
            this.lblBaoCaoTon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblBaoCaoTon.Name = "lblBaoCaoTon";
            this.lblBaoCaoTon.Size = new System.Drawing.Size(165, 34);
            this.lblBaoCaoTon.TabIndex = 18;
            this.lblBaoCaoTon.Text = "Báo cáo tồn";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBaoCao.Location = new System.Drawing.Point(641, 155);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(96, 23);
            this.btnBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBaoCao.TabIndex = 19;
            this.btnBaoCao.Text = "Xuất báo cáo";
            // 
            // frmBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 580);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.lblBaoCaoTon);
            this.Controls.Add(this.lbGiaNhap);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.dataGridViewMatHang);
            this.Name = "frmBaoCaoTon";
            this.Text = "frmBaoCaoTon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewMatHang;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.LabelControl lbGiaNhap;
        private DevExpress.XtraEditors.LabelControl lblBaoCaoTon;
        private DevComponents.DotNetBar.ButtonX btnBaoCao;
    }
}