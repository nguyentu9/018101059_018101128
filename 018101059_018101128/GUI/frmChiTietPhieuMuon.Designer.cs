namespace _018101059_018101128
{
    partial class frmChiTietPhieuMuon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvchitietphieumuon = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.cbbsach = new System.Windows.Forms.ComboBox();
            this.txtsopm = new System.Windows.Forms.TextBox();
            this.numSoluong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHI TIẾT PHIẾU MƯỢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên sách";
            // 
            // lvchitietphieumuon
            // 
            this.lvchitietphieumuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader2});
            this.lvchitietphieumuon.FullRowSelect = true;
            this.lvchitietphieumuon.GridLines = true;
            this.lvchitietphieumuon.HideSelection = false;
            this.lvchitietphieumuon.Location = new System.Drawing.Point(117, 266);
            this.lvchitietphieumuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvchitietphieumuon.Name = "lvchitietphieumuon";
            this.lvchitietphieumuon.Size = new System.Drawing.Size(599, 125);
            this.lvchitietphieumuon.TabIndex = 3;
            this.lvchitietphieumuon.UseCompatibleStateImageBehavior = false;
            this.lvchitietphieumuon.View = System.Windows.Forms.View.Details;
            this.lvchitietphieumuon.Click += new System.EventHandler(this.lvchitietphieumuon_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số phiếu mượn";
            this.columnHeader5.Width = 211;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên sách";
            this.columnHeader4.Width = 205;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 122;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(36, 437);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(145, 58);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(339, 437);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(145, 58);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(488, 437);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(145, 58);
            this.btncapnhat.TabIndex = 4;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(639, 437);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(145, 58);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(187, 437);
            this.btnghi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(145, 58);
            this.btnghi.TabIndex = 4;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // cbbsach
            // 
            this.cbbsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbsach.FormattingEnabled = true;
            this.cbbsach.Location = new System.Drawing.Point(335, 157);
            this.cbbsach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbsach.Name = "cbbsach";
            this.cbbsach.Size = new System.Drawing.Size(205, 28);
            this.cbbsach.TabIndex = 5;
            // 
            // txtsopm
            // 
            this.txtsopm.Enabled = false;
            this.txtsopm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsopm.Location = new System.Drawing.Point(328, 90);
            this.txtsopm.Name = "txtsopm";
            this.txtsopm.Size = new System.Drawing.Size(212, 27);
            this.txtsopm.TabIndex = 6;
            // 
            // numSoluong
            // 
            this.numSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoluong.Location = new System.Drawing.Point(335, 218);
            this.numSoluong.Name = "numSoluong";
            this.numSoluong.Size = new System.Drawing.Size(205, 27);
            this.numSoluong.TabIndex = 7;
            // 
            // frmChiTietPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 513);
            this.Controls.Add(this.numSoluong);
            this.Controls.Add(this.txtsopm);
            this.Controls.Add(this.cbbsach);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lvchitietphieumuon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChiTietPhieuMuon";
            this.Text = "frmChiTietPhieuMuon";
            this.Load += new System.EventHandler(this.frmChiTietPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvchitietphieumuon;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.ComboBox cbbsach;
        private System.Windows.Forms.TextBox txtsopm;
        private System.Windows.Forms.NumericUpDown numSoluong;
    }
}