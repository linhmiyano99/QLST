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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMatHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtSoHoaDon = new DevExpress.XtraEditors.TextEdit();
            this.lbGiaNhap = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHoaDon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatHang
            // 
            this.dataGridViewMatHang.AllowUserToAddRows = false;
            this.dataGridViewMatHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMatHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewMatHang.Location = new System.Drawing.Point(10, 214);
            this.dataGridViewMatHang.Name = "dataGridViewMatHang";
            this.dataGridViewMatHang.RowHeadersWidth = 51;
            this.dataGridViewMatHang.RowTemplate.Height = 24;
            this.dataGridViewMatHang.Size = new System.Drawing.Size(1221, 342);
            this.dataGridViewMatHang.TabIndex = 15;
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Location = new System.Drawing.Point(510, 167);
            this.txtSoHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(192, 22);
            this.txtSoHoaDon.TabIndex = 16;
            // 
            // lbGiaNhap
            // 
            this.lbGiaNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaNhap.Appearance.Options.UseFont = true;
            this.lbGiaNhap.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbGiaNhap.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbGiaNhap.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lbGiaNhap.LineVisible = true;
            this.lbGiaNhap.Location = new System.Drawing.Point(417, 170);
            this.lbGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbGiaNhap.Name = "lbGiaNhap";
            this.lbGiaNhap.Size = new System.Drawing.Size(64, 21);
            this.lbGiaNhap.TabIndex = 17;
            this.lbGiaNhap.Text = "Tra cứu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(510, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(165, 34);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Báo cáo tồn";
            // 
            // frmBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 580);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbGiaNhap);
            this.Controls.Add(this.txtSoHoaDon);
            this.Controls.Add(this.dataGridViewMatHang);
            this.Name = "frmBaoCaoTon";
            this.Text = "frmBaoCaoTon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHoaDon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewMatHang;
        private DevExpress.XtraEditors.TextEdit txtSoHoaDon;
        private DevExpress.XtraEditors.LabelControl lbGiaNhap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}