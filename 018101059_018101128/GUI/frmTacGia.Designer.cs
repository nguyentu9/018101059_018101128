namespace _018101059_018101128
{
    partial class frmTacGia
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
            this.lvtacgia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthem = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttentacgia = new System.Windows.Forms.TextBox();
            this.txtmatacgia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÁC GIẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên tác giả";
            // 
            // lvtacgia
            // 
            this.lvtacgia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvtacgia.FullRowSelect = true;
            this.lvtacgia.GridLines = true;
            this.lvtacgia.HideSelection = false;
            this.lvtacgia.Location = new System.Drawing.Point(100, 158);
            this.lvtacgia.Margin = new System.Windows.Forms.Padding(2);
            this.lvtacgia.Name = "lvtacgia";
            this.lvtacgia.Size = new System.Drawing.Size(350, 95);
            this.lvtacgia.TabIndex = 1;
            this.lvtacgia.UseCompatibleStateImageBehavior = false;
            this.lvtacgia.View = System.Windows.Forms.View.Details;
            this.lvtacgia.SelectedIndexChanged += new System.EventHandler(this.lvtacgia_SelectedIndexChanged);
            this.lvtacgia.Click += new System.EventHandler(this.lvtacgia_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Tác Giả";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Tác Giả";
            this.columnHeader2.Width = 200;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(22, 272);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 47);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(135, 272);
            this.btnghi.Margin = new System.Windows.Forms.Padding(2);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(109, 47);
            this.btnghi.TabIndex = 2;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(248, 272);
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
            this.btncapnhat.Location = new System.Drawing.Point(362, 272);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(109, 47);
            this.btncapnhat.TabIndex = 2;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(475, 272);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(109, 47);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttentacgia
            // 
            this.txttentacgia.Location = new System.Drawing.Point(211, 106);
            this.txttentacgia.Margin = new System.Windows.Forms.Padding(2);
            this.txttentacgia.Name = "txttentacgia";
            this.txttentacgia.Size = new System.Drawing.Size(170, 20);
            this.txttentacgia.TabIndex = 3;
            // 
            // txtmatacgia
            // 
            this.txtmatacgia.Location = new System.Drawing.Point(211, 61);
            this.txtmatacgia.Margin = new System.Windows.Forms.Padding(2);
            this.txtmatacgia.Name = "txtmatacgia";
            this.txtmatacgia.Size = new System.Drawing.Size(170, 20);
            this.txtmatacgia.TabIndex = 3;
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 366);
            this.Controls.Add(this.txtmatacgia);
            this.Controls.Add(this.txttentacgia);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lvtacgia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTacGia";
            this.Text = "frmTacGia";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvtacgia;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttentacgia;
        private System.Windows.Forms.TextBox txtmatacgia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}