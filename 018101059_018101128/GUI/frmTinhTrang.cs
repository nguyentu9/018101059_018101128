using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _018101059_018101128.DTO;
using _018101059_018101128.BUS;

namespace _018101059_018101128
{
    public partial class frmTinhTrang : Form
    {
        public frmTinhTrang()
        {
            InitializeComponent();
        }

        private void frmTinhTrang_Load(object sender, EventArgs e)
        {
            Load_LvTinhTrang();
            txttinhtrang.Enabled = false;
        }
        public void Load_LvTinhTrang()
        {
            lvtinhtrang.Items.Clear();
            DataTable dt = new DataTable();
            dt = TinhTrangBUS.ThongTin_TT();
            int n = dt.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                lvtinhtrang.Items.Add(dt.Rows[i]["MATT"].ToString());
                lvtinhtrang.Items[i].SubItems.Add(dt.Rows[i]["TENTT"].ToString());
            }

        }
        private void lvtinhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvtinhtrang.SelectedIndices.Count > 0)
            {
                txttinhtrang.Text = lvtinhtrang.SelectedItems[0].SubItems[0].Text;
                txttentinhtrang.Text = lvtinhtrang.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txttinhtrang.Text = txttentinhtrang.Text = "";
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;
            TinhTrangDTO t = new TinhTrangDTO() { ten = txttentinhtrang.Text };
            TinhTrangBUS.Them(t);
            Load_LvTinhTrang();
            btnthem.PerformClick();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvtinhtrang.SelectedIndices.Count > 0)
            {
                TinhTrangDTO t = new TinhTrangDTO()
                {
                    ma = lvtinhtrang.SelectedItems[0].SubItems[0].Text
                };
                TinhTrangBUS.Xoa(t);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo");
            }
            Load_LvTinhTrang();
            btnthem.PerformClick();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            if (!KiemTraDuLieu()) return;
            TinhTrangDTO t = new TinhTrangDTO()
            {
                ma = lvtinhtrang.SelectedItems[0].SubItems[0].Text,
                ten = txttentinhtrang.Text
            };
            TinhTrangBUS.Capnhat(t);
            Load_LvTinhTrang();
            btnthem.PerformClick();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool KiemTraDuLieu()
        {
            if (txttentinhtrang.Text == "")
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông báo");
                return false;
            }
            for (int i = 0; i < lvtinhtrang.Items.Count; i++)
            {
                if (lvtinhtrang.Items[i].SubItems[1].Text == txttentinhtrang.Text)
                {
                    MessageBox.Show("Tên tình trạng đã tồn tại!");
                    return false;
                }
            }
            return true;
        }
    }
}
