namespace QLST
{
    partial class frmPrintInvoice
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
            this.lbInvoiceNum = new System.Windows.Forms.Label();
            this.lbSellerName = new System.Windows.Forms.Label();
            this.lbBranchTel = new System.Windows.Forms.Label();
            this.lbBranchAddr = new System.Windows.Forms.Label();
            this.lbCompanyTel = new System.Windows.Forms.Label();
            this.lbCompanyAddr = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.smbol1 = new System.Windows.Forms.Label();
            this.PrintPanel = new System.Windows.Forms.Panel();
            this.logoX = new System.Windows.Forms.PictureBox();
            this.Total = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.PrintPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoX)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInvoiceNum
            // 
            this.lbInvoiceNum.AutoSize = true;
            this.lbInvoiceNum.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvoiceNum.Location = new System.Drawing.Point(279, 281);
            this.lbInvoiceNum.Name = "lbInvoiceNum";
            this.lbInvoiceNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInvoiceNum.Size = new System.Drawing.Size(120, 22);
            this.lbInvoiceNum.TabIndex = 19;
            this.lbInvoiceNum.Text = "Số Hóa Đơn:";
            this.lbInvoiceNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbSellerName
            // 
            this.lbSellerName.AutoSize = true;
            this.lbSellerName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSellerName.Location = new System.Drawing.Point(25, 281);
            this.lbSellerName.Name = "lbSellerName";
            this.lbSellerName.Size = new System.Drawing.Size(100, 22);
            this.lbSellerName.TabIndex = 18;
            this.lbSellerName.Text = "Thu Ngân:";
            // 
            // lbBranchTel
            // 
            this.lbBranchTel.AutoSize = true;
            this.lbBranchTel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBranchTel.Location = new System.Drawing.Point(18, 137);
            this.lbBranchTel.Name = "lbBranchTel";
            this.lbBranchTel.Size = new System.Drawing.Size(90, 19);
            this.lbBranchTel.TabIndex = 17;
            this.lbBranchTel.Text = "branchTel";
            this.lbBranchTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBranchAddr
            // 
            this.lbBranchAddr.AutoSize = true;
            this.lbBranchAddr.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBranchAddr.Location = new System.Drawing.Point(18, 108);
            this.lbBranchAddr.Name = "lbBranchAddr";
            this.lbBranchAddr.Size = new System.Drawing.Size(99, 19);
            this.lbBranchAddr.TabIndex = 16;
            this.lbBranchAddr.Text = "branchAddr";
            this.lbBranchAddr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCompanyTel
            // 
            this.lbCompanyTel.AutoSize = true;
            this.lbCompanyTel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyTel.Location = new System.Drawing.Point(183, 111);
            this.lbCompanyTel.Name = "lbCompanyTel";
            this.lbCompanyTel.Size = new System.Drawing.Size(99, 19);
            this.lbCompanyTel.TabIndex = 15;
            this.lbCompanyTel.Text = "companyTel";
            this.lbCompanyTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCompanyAddr
            // 
            this.lbCompanyAddr.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyAddr.Location = new System.Drawing.Point(3, 92);
            this.lbCompanyAddr.Name = "lbCompanyAddr";
            this.lbCompanyAddr.Size = new System.Drawing.Size(476, 19);
            this.lbCompanyAddr.TabIndex = 14;
            this.lbCompanyAddr.Text = "companyAdress";
            this.lbCompanyAddr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCompany
            // 
            this.lbCompany.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompany.Location = new System.Drawing.Point(-1, 57);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(480, 28);
            this.lbCompany.TabIndex = 12;
            this.lbCompany.Text = "COMPANY NAME";
            this.lbCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smbol1
            // 
            this.smbol1.AutoSize = true;
            this.smbol1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smbol1.Location = new System.Drawing.Point(26, 358);
            this.smbol1.Name = "smbol1";
            this.smbol1.Size = new System.Drawing.Size(413, 15);
            this.smbol1.TabIndex = 11;
            this.smbol1.Text = "----------------------------------------------------------\r\n";
            // 
            // PrintPanel
            // 
            this.PrintPanel.AutoScroll = true;
            this.PrintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrintPanel.Controls.Add(this.lbInvoiceNum);
            this.PrintPanel.Controls.Add(this.lbSellerName);
            this.PrintPanel.Controls.Add(this.lbBranchTel);
            this.PrintPanel.Controls.Add(this.lbBranchAddr);
            this.PrintPanel.Controls.Add(this.lbCompanyTel);
            this.PrintPanel.Controls.Add(this.lbCompanyAddr);
            this.PrintPanel.Controls.Add(this.logoX);
            this.PrintPanel.Controls.Add(this.lbCompany);
            this.PrintPanel.Controls.Add(this.smbol1);
            this.PrintPanel.Controls.Add(this.Total);
            this.PrintPanel.Controls.Add(this.Price);
            this.PrintPanel.Controls.Add(this.Quantity);
            this.PrintPanel.Controls.Add(this.ItemName);
            this.PrintPanel.Controls.Add(this.Time);
            this.PrintPanel.Controls.Add(this.Employee);
            this.PrintPanel.Controls.Add(this.Date);
            this.PrintPanel.Controls.Add(this.ID);
            this.PrintPanel.Controls.Add(this.lbTitle);
            this.PrintPanel.Location = new System.Drawing.Point(132, 42);
            this.PrintPanel.Name = "PrintPanel";
            this.PrintPanel.Size = new System.Drawing.Size(484, 862);
            this.PrintPanel.TabIndex = 2;
            // 
            // logoX
            // 
            this.logoX.Location = new System.Drawing.Point(4, 4);
            this.logoX.Name = "logoX";
            this.logoX.Size = new System.Drawing.Size(100, 50);
            this.logoX.TabIndex = 13;
            this.logoX.TabStop = false;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(367, 336);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(70, 22);
            this.Total.TabIndex = 9;
            this.Total.Text = "T.TIỀN";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(165, 336);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(60, 22);
            this.Price.TabIndex = 8;
            this.Price.Text = "Đ.GIÁ";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(260, 336);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(80, 22);
            this.Quantity.TabIndex = 7;
            this.Quantity.Text = "S.LƯỢNG";
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(25, 336);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(90, 22);
            this.ItemName.TabIndex = 6;
            this.ItemName.Text = "TÊN HÀNG";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(279, 242);
            this.Time.Name = "Time";
            this.Time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Time.Size = new System.Drawing.Size(50, 22);
            this.Time.TabIndex = 5;
            this.Time.Text = "Giờ:";
            this.Time.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(258, 211);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(0, 22);
            this.Employee.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(25, 242);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(60, 22);
            this.Date.TabIndex = 3;
            this.Date.Text = "Ngày:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(30, 294);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 22);
            this.ID.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(120, 183);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(220, 28);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // frmPrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 930);
            this.Controls.Add(this.PrintPanel);
            this.Name = "frmPrintInvoice";
            this.Text = "frmPrintInvoice";
            this.Load += new System.EventHandler(this.frmPrintInvoice_Load);
            this.PrintPanel.ResumeLayout(false);
            this.PrintPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbInvoiceNum;
        private System.Windows.Forms.Label lbSellerName;
        private System.Windows.Forms.Label lbBranchTel;
        private System.Windows.Forms.Label lbBranchAddr;
        private System.Windows.Forms.Label lbCompanyTel;
        private System.Windows.Forms.Label lbCompanyAddr;
        private System.Windows.Forms.PictureBox logoX;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.Label smbol1;
        private System.Windows.Forms.Panel PrintPanel;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label lbTitle;
    }
}