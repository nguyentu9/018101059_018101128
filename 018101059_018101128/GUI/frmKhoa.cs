using _018101059_018101128.DAO;
using _018101059_018101128.DTO;
using _018101059_018101128.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018101059_018101128.GUI
{
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            Load_LvKhoa();
        }
        public void Load_LvKhoa()
        {
            DataTable dt = new DataTable();
            dt = KhoaBUS.TT_Khoa();
            int n = dt.Rows.Count;
            for(int i=0;i<n;i++)
            {
                lvkhoa.Items.Add(dt.Rows[i]["MAKHOA"].ToString());
                lvkhoa.Items[i].SubItems.Add(dt.Rows[i]["TENKHOA"].ToString());
            }

        }

        private void lvkhoa_Click(object sender, EventArgs e)
        {
            txtmakhoa.Text = lvkhoa.SelectedItems[0].SubItems[0].Text;
            txttenkhoa.Text = lvkhoa.SelectedItems[0].SubItems[1].Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmakhoa.Text = "";
            txttenkhoa.Text = "";
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            KiemTraDuLieuNhapVao();
            KhoaDTO k = new KhoaDTO();
            k.makhoa = txtmakhoa.Text;
            k.tenkhoa = txttenkhoa.Text;
            KhoaBUS.Them(k);
            lvkhoa.Items.Clear();
            Load_LvKhoa();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            KiemTraDuLieuNhapVao();
            KhoaDTO k = new KhoaDTO();
            k.makhoa = txtmakhoa.Text;
            k.tenkhoa = txttenkhoa.Text;
            KhoaBUS.Capnhat(k);
            lvkhoa.Items.Clear();
            Load_LvKhoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhoaDTO k = new KhoaDTO();
            k.makhoa = txtmakhoa.Text;
            KhoaBUS.Xoa(k);
            lvkhoa.Items.Clear();
            Load_LvKhoa();
        }
        private void KiemTraDuLieuNhapVao()
        {
            if (txtmakhoa.Text == "" && txttenkhoa.Text == "")
            {
                MessageBox.Show("Các trường thông tin không được để trống!");
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
