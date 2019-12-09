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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBaoCaoDoanhSo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTienTongCong = new DevExpress.XtraEditors.TextEdit();
            this.lbTienKhachDua = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoDoanhSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienTongCong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBaoCaoDoanhSo
            // 
            this.dataGridViewBaoCaoDoanhSo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBaoCaoDoanhSo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBaoCaoDoanhSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewBaoCaoDoanhSo.Location = new System.Drawing.Point(26, 261);
            this.dataGridViewBaoCaoDoanhSo.Name = "dataGridViewBaoCaoDoanhSo";
            this.dataGridViewBaoCaoDoanhSo.RowHeadersWidth = 51;
            this.dataGridViewBaoCaoDoanhSo.RowTemplate.Height = 24;
            this.dataGridViewBaoCaoDoanhSo.Size = new System.Drawing.Size(897, 288);
            this.dataGridViewBaoCaoDoanhSo.TabIndex = 8;
            // 
            // txtTienTongCong
            // 
            this.txtTienTongCong.Location = new System.Drawing.Point(138, 215);
            this.txtTienTongCong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTienTongCong.Name = "txtTienTongCong";
            this.txtTienTongCong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienTongCong.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtTienTongCong.Properties.Appearance.Options.UseFont = true;
            this.txtTienTongCong.Properties.Appearance.Options.UseForeColor = true;
            this.txtTienTongCong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTienTongCong.Properties.ReadOnly = true;
            this.txtTienTongCong.Size = new System.Drawing.Size(153, 30);
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
            this.lbTienKhachDua.Location = new System.Drawing.Point(26, 214);
            this.lbTienKhachDua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTienKhachDua.Name = "lbTienKhachDua";
            this.lbTienKhachDua.SingleLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTienKhachDua.Size = new System.Drawing.Size(106, 34);
            this.lbTienKhachDua.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lbTienKhachDua.TabIndex = 28;
            this.lbTienKhachDua.Text = "Doanh thu";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Green;
            this.labelX1.Location = new System.Drawing.Point(389, 45);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelX1.Size = new System.Drawing.Size(216, 34);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX1.TabIndex = 29;
            this.labelX1.Text = "Báo cáo doanh số";
            // 
            // frmBaoCaoDoanhSoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 645);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lbTienKhachDua);
            this.Controls.Add(this.txtTienTongCong);
            this.Controls.Add(this.dataGridViewBaoCaoDoanhSo);
            this.Name = "frmBaoCaoDoanhSoGUI";
            this.Text = "BaoCaoDoanhSoGUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoDoanhSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienTongCong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewBaoCaoDoanhSo;
        private DevExpress.XtraEditors.TextEdit txtTienTongCong;
        private DevComponents.DotNetBar.LabelX lbTienKhachDua;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}