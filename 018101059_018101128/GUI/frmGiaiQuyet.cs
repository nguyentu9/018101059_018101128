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
    public partial class frmGiaiQuyet : Form
    {
        public frmGiaiQuyet()
        {
            InitializeComponent();
        }

        private void frmGiaiQuyet_Load(object sender, EventArgs e)
        {
            Load_LvGQ();
            txtmagiaiquyet.Enabled = false;
        }
        public void Load_LvGQ()
        {
            lvgiaiquyet.Items.Clear();
            DataTable dt = new DataTable();
            dt = GiaiQuyetBUS.ThongTin_GQ();
            int n = dt.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                lvgiaiquyet.Items.Add(dt.Rows[i]["MAGQ"].ToString());
                lvgiaiquyet.Items[i].SubItems.Add(dt.Rows[i]["TENGQ"].ToString());
            }

        }

        private void lvgiaiquyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvgiaiquyet.SelectedIndices.Count > 0)
            {
                txtmagiaiquyet.Text = lvgiaiquyet.SelectedItems[0].SubItems[0].Text;
                txttengiaiquyet.Text = lvgiaiquyet.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmagiaiquyet.Text = txttengiaiquyet.Text = "";
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;
            GiaiQuyetDTO gq = new GiaiQuyetDTO() { ten = txttengiaiquyet.Text };
            GiaiQuyetBUS.Them(gq);
            Load_LvGQ();
            btnthem.PerformClick();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvgiaiquyet.SelectedIndices.Count > 0)
            {
                GiaiQuyetDTO t = new GiaiQuyetDTO()
                {
                    ma = lvgiaiquyet.SelectedItems[0].SubItems[0].Text
                };
                GiaiQuyetBUS.Xoa(t);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo");
            }
            Load_LvGQ();
            btnthem.PerformClick();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;
            GiaiQuyetDTO t = new GiaiQuyetDTO()
            {
                ma = lvgiaiquyet.SelectedItems[0].SubItems[0].Text,
                ten = txttengiaiquyet.Text
            };
            GiaiQuyetBUS.Capnhat(t);
            Load_LvGQ();
            btnthem.PerformClick();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool KiemTraDuLieu()
        {
            if (txttengiaiquyet.Text == "")
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông báo");
                return false;
            }
            for (int i = 0; i < lvgiaiquyet.Items.Count; i++)
            {
                if (lvgiaiquyet.Items[i].SubItems[1].Text == txttengiaiquyet.Text)
                {
                    MessageBox.Show("Tên giải quyết đã tồn tại!");
                    return false;
                }
            }
            return true;
        }
    }
}
