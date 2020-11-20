namespace _018101059_018101128
{
    partial class frmGiaiQuyet
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
            this.lvgiaiquyet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.txtmagiaiquyet = new System.Windows.Forms.TextBox();
            this.txttengiaiquyet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHIẾU GIẢI QUYẾT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã giải quyết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên giải quyết";
            // 
            // lvgiaiquyet
            // 
            this.lvgiaiquyet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvgiaiquyet.FullRowSelect = true;
            this.lvgiaiquyet.GridLines = true;
            this.lvgiaiquyet.HideSelection = false;
            this.lvgiaiquyet.Location = new System.Drawing.Point(131, 141);
            this.lvgiaiquyet.Margin = new System.Windows.Forms.Padding(2);
            this.lvgiaiquyet.Name = "lvgiaiquyet";
            this.lvgiaiquyet.Size = new System.Drawing.Size(324, 131);
            this.lvgiaiquyet.TabIndex = 1;
            this.lvgiaiquyet.UseCompatibleStateImageBehavior = false;
            this.lvgiaiquyet.View = System.Windows.Forms.View.Details;
            this.lvgiaiquyet.SelectedIndexChanged += new System.EventHandler(this.lvgiaiquyet_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã giải quyết";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên giải quyết";
            this.columnHeader2.Width = 208;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(18, 307);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 47);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(245, 307);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(109, 47);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(358, 307);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(109, 47);
            this.btncapnhat.TabIndex = 2;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(368, 307);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 0);
            this.button4.TabIndex = 2;
            this.button4.Text = "Cập nhật";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(471, 307);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(109, 47);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(131, 307);
            this.btnghi.Margin = new System.Windows.Forms.Padding(2);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(109, 47);
            this.btnghi.TabIndex = 2;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // txtmagiaiquyet
            // 
            this.txtmagiaiquyet.Location = new System.Drawing.Point(245, 65);
            this.txtmagiaiquyet.Margin = new System.Windows.Forms.Padding(2);
            this.txtmagiaiquyet.Name = "txtmagiaiquyet";
            this.txtmagiaiquyet.Size = new System.Drawing.Size(170, 20);
            this.txtmagiaiquyet.TabIndex = 3;
            // 
            // txttengiaiquyet
            // 
            this.txttengiaiquyet.Location = new System.Drawing.Point(245, 100);
            this.txttengiaiquyet.Margin = new System.Windows.Forms.Padding(2);
            this.txttengiaiquyet.Name = "txttengiaiquyet";
            this.txttengiaiquyet.Size = new System.Drawing.Size(170, 20);
            this.txttengiaiquyet.TabIndex = 3;
            // 
            // frmGiaiQuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txttengiaiquyet);
            this.Controls.Add(this.txtmagiaiquyet);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lvgiaiquyet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGiaiQuyet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaiQuyet";
            this.Load += new System.EventHandler(this.frmGiaiQuyet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvgiaiquyet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.TextBox txtmagiaiquyet;
        private System.Windows.Forms.TextBox txttengiaiquyet;
    }
}