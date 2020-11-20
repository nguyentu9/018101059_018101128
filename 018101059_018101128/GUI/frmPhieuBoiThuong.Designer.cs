namespace _018101059_018101128
{
    partial class frmPhieuBoiThuong
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvboithuong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.cbonhanvien = new System.Windows.Forms.ComboBox();
            this.cbotinhtrang = new System.Windows.Forms.ComboBox();
            this.cbogiaiquyet = new System.Windows.Forms.ComboBox();
            this.txtsobt = new System.Windows.Forms.TextBox();
            this.cbosinhvien = new System.Windows.Forms.ComboBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHIẾU BỒI THƯỜNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bồi thường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giải quyết";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên sinh viên";
            // 
            // lvboithuong
            // 
            this.lvboithuong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
            this.lvboithuong.FullRowSelect = true;
            this.lvboithuong.GridLines = true;
            this.lvboithuong.HideSelection = false;
            this.lvboithuong.Location = new System.Drawing.Point(20, 186);
            this.lvboithuong.Margin = new System.Windows.Forms.Padding(2);
            this.lvboithuong.Name = "lvboithuong";
            this.lvboithuong.Size = new System.Drawing.Size(752, 103);
            this.lvboithuong.TabIndex = 3;
            this.lvboithuong.UseCompatibleStateImageBehavior = false;
            this.lvboithuong.View = System.Windows.Forms.View.Details;
            this.lvboithuong.SelectedIndexChanged += new System.EventHandler(this.lvboithuong_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã bồi thường";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên sinh viên";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên nhân viên";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tình trạng";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giải quyết";
            this.columnHeader3.Width = 173;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(156, 308);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 47);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(269, 308);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(109, 47);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(382, 308);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(109, 47);
            this.btncapnhat.TabIndex = 4;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(495, 308);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(109, 47);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // cbonhanvien
            // 
            this.cbonhanvien.FormattingEnabled = true;
            this.cbonhanvien.Location = new System.Drawing.Point(452, 103);
            this.cbonhanvien.Name = "cbonhanvien";
            this.cbonhanvien.Size = new System.Drawing.Size(192, 21);
            this.cbonhanvien.TabIndex = 5;
            // 
            // cbotinhtrang
            // 
            this.cbotinhtrang.FormattingEnabled = true;
            this.cbotinhtrang.Location = new System.Drawing.Point(121, 106);
            this.cbotinhtrang.Name = "cbotinhtrang";
            this.cbotinhtrang.Size = new System.Drawing.Size(130, 21);
            this.cbotinhtrang.TabIndex = 6;
            // 
            // cbogiaiquyet
            // 
            this.cbogiaiquyet.FormattingEnabled = true;
            this.cbogiaiquyet.Location = new System.Drawing.Point(121, 148);
            this.cbogiaiquyet.Name = "cbogiaiquyet";
            this.cbogiaiquyet.Size = new System.Drawing.Size(210, 21);
            this.cbogiaiquyet.TabIndex = 6;
            // 
            // txtsobt
            // 
            this.txtsobt.Location = new System.Drawing.Point(121, 62);
            this.txtsobt.Name = "txtsobt";
            this.txtsobt.Size = new System.Drawing.Size(130, 20);
            this.txtsobt.TabIndex = 7;
            // 
            // cbosinhvien
            // 
            this.cbosinhvien.FormattingEnabled = true;
            this.cbosinhvien.Location = new System.Drawing.Point(452, 62);
            this.cbosinhvien.Name = "cbosinhvien";
            this.cbosinhvien.Size = new System.Drawing.Size(192, 21);
            this.cbosinhvien.TabIndex = 8;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã sinh viên";
            this.columnHeader6.Width = 100;
            // 
            // frmPhieuBoiThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 393);
            this.Controls.Add(this.cbosinhvien);
            this.Controls.Add(this.txtsobt);
            this.Controls.Add(this.cbogiaiquyet);
            this.Controls.Add(this.cbotinhtrang);
            this.Controls.Add(this.cbonhanvien);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lvboithuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPhieuBoiThuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuBoiThuong";
            this.Load += new System.EventHandler(this.frmPhieuBoiThuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvboithuong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ComboBox cbonhanvien;
        private System.Windows.Forms.ComboBox cbotinhtrang;
        private System.Windows.Forms.ComboBox cbogiaiquyet;
        private System.Windows.Forms.TextBox txtsobt;
        private System.Windows.Forms.ComboBox cbosinhvien;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}