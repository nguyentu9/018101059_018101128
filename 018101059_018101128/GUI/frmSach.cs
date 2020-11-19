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
namespace _018101059_018101128
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            Load_tacgia();
            Load_theloai();
            Load_lv();
            txtmasach.Enabled = false;
        }
        public void Load_lv()
        {
            lvsach.Items.Clear();
            DataTable dt = LoaisachBUS.Load_lv();
            int n = dt.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["MASH"].ToString());
                item.SubItems.Add(dt.Rows[i]["TENSACH"].ToString());
                item.SubItems.Add(dt.Rows[i]["TENTHELOAI"].ToString());
                item.SubItems.Add(dt.Rows[i]["TENTACGIA"].ToString());
                item.SubItems.Add(dt.Rows[i]["NXB"].ToString());
                item.SubItems.Add(dt.Rows[i]["NAMSX"].ToString());
                item.SubItems.Add(dt.Rows[i]["SOLUONG"].ToString());
                lvsach.Items.Add(item);
            }
        }
        private void Load_tacgia()
        {
            DataTable dt = TacgiaBUS.TT_Tacgia();
            cbotacgia.DataSource = dt;
            cbotacgia.DisplayMember = "TENTACGIA";
            cbotacgia.ValueMember = "MATG";
        }
        private void Load_theloai()
        {
            DataTable dt = LoaisachBUS.Load_TTSach();
            cbotheloai.DataSource = dt;
            cbotheloai.DisplayMember = "TENTHELOAI";
            cbotheloai.ValueMember = "MATL";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmasach.Text = txttensach.Text = txtnhaxuatban.Text = "";
            numsoluong.Value = numnamxuatban.Value = 0;
            cbotheloai.SelectedIndex = cbotacgia.SelectedIndex = 0;
            txtmasach.Enabled = true;
        }
        // Note: dùng chung class với loaisach
        private void btnghi_Click(object sender, EventArgs e)
        {
            txtmasach.Enabled = false;
            KiemTraDuLieuDauVao();
            SachDTO sach = new SachDTO()
            {
                mash = txtmasach.Text,
                maTG = cbotacgia.SelectedValue.ToString() != "" ? cbotacgia.SelectedValue.ToString() :
                    cbotacgia.ValueMember.ToString(),
                maTL = cbotheloai.SelectedValue.ToString() != "" ? cbotheloai.SelectedValue.ToString() :
                    cbotheloai.ValueMember.ToString(),
                namSX =  numnamxuatban.Value.ToString(),
                NXB = txtnhaxuatban.Text,
                tensach = txttensach.Text,
                soluong = numsoluong.Value.ToString()
            };
            LoaisachBUS.ThemSach(sach);
            Load_lv();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtmasach.Enabled = false;
            SachDTO sach = new SachDTO()
            {
                mash = txtmasach.Text
            };
            LoaisachBUS.ThemSach(sach);
            Load_lv();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            txtmasach.Enabled = false;
            KiemTraDuLieuDauVao();
            SachDTO sach = new SachDTO()
            {
                mash = txtmasach.Text,
                maTG = cbotacgia.SelectedValue.ToString() != "" ? cbotacgia.SelectedValue.ToString() :
                    cbotacgia.ValueMember.ToString(),
                maTL = cbotheloai.SelectedValue.ToString() != "" ? cbotheloai.SelectedValue.ToString() :
                    cbotheloai.ValueMember.ToString(),
                namSX =  numnamxuatban.Value.ToString(),
                NXB = txtnhaxuatban.Text,
                tensach = txttensach.Text,
                soluong = numsoluong.Value.ToString()
            };
            LoaisachBUS.SuaSach(sach);
            Load_lv();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KiemTraDuLieuDauVao()
        {
            if (txtmasach.Text == "" || txttensach.Text == "" || txtnhaxuatban.Text == "" ||
                cbotacgia.Text == "" || cbotheloai.Text == "")
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo");
                return;
            }

            if (numsoluong.Value == 0)
            {
                MessageBox.Show("Phải nhập số lượng cho sách!", "Thông báo");
                return;
            }

           
            if (DateTime.Now.Year < numnamxuatban.Value)
            {
                MessageBox.Show("Năm xuất bản lớn hơn năm hiện tại", "Lỗi");
                return;
            }
        }

        private void lvsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsach.SelectedIndices.Count > 0)
            {
                txtmasach.Text = lvsach.SelectedItems[0].SubItems[0].Text;
                txttensach.Text = lvsach.SelectedItems[0].SubItems[1].Text;
                cbotheloai.Text = lvsach.SelectedItems[0].SubItems[2].Text;
                cbotacgia.Text = lvsach.SelectedItems[0].SubItems[3].Text;
                txtnhaxuatban.Text = lvsach.SelectedItems[0].SubItems[4].Text;
                numnamxuatban.Value = int.Parse(lvsach.SelectedItems[0].SubItems[5].Text);
                numsoluong.Value = int.Parse(lvsach.SelectedItems[0].SubItems[6].Text);
            }
        }
    }
}
