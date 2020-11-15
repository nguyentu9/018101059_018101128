using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _018101059_018101128.BUS;
using _018101059_018101128.DTO;
namespace _018101059_018101128.GUI
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            Load_LvNhacc();
        }
        public void Load_LvNhacc()
        {
            DataTable dt = new DataTable();
            dt = NhaccBUS.TT_Nhacc();
            int n = dt.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                lvncc.Items.Add(dt.Rows[i]["MANCC"].ToString());
                lvncc.Items[i].SubItems.Add(dt.Rows[i]["TENNCC"].ToString());
                lvncc.Items[i].SubItems.Add(dt.Rows[i]["DIACHI"].ToString());
                lvncc.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            KiemTraDuLieuNhapVao();
            NhaccDTO nhacc = new NhaccDTO();
            nhacc.manhacc = txtmancc.Text;
            nhacc.tennhacc= txttenncc.Text;
            nhacc.diachi = txtdiachi.Text;
            nhacc.sdt = txtsdt.Text;
            NhaccBUS.Them(nhacc);
            lvncc.Items.Clear();
            Load_LvNhacc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhaccDTO nhacc = new NhaccDTO();
            nhacc.manhacc = txtmancc.Text;
            NhaccBUS.Xoa(nhacc);
            lvncc.Items.Clear();
            Load_LvNhacc();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            KiemTraDuLieuNhapVao();
            NhaccDTO nhacc = new NhaccDTO();
            nhacc.manhacc = txtmancc.Text;
            nhacc.tennhacc = txttenncc.Text;
            nhacc.diachi = txtdiachi.Text;
            nhacc.sdt = txtsdt.Text;
            NhaccBUS.Capnhat(nhacc);
            lvncc.Items.Clear();
            Load_LvNhacc();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KiemTraDuLieuNhapVao()
        {
            if (txtmancc.Text == "" && txttenncc.Text == "")
            {
                MessageBox.Show("Các trường thông tin không được để trống!");
                return;
            }
        }
        private void lvncc_Click(object sender, EventArgs e)
        {
            txtmancc.Text = lvncc.SelectedItems[0].SubItems[0].Text;
            txttenncc.Text = lvncc.SelectedItems[0].SubItems[1].Text;
            txtdiachi.Text = lvncc.SelectedItems[0].SubItems[2].Text;
            txtsdt.Text = lvncc.SelectedItems[0].SubItems[3].Text;
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }
    }
}
