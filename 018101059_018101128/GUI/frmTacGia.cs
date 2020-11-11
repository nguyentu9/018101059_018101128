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
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            Load_LvTacgia();
        }
        public void Load_LvTacgia()
        {
            DataTable dt = new DataTable();
            dt = TacgiaBUS.TT_Tacgia();
            int n = dt.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                lvtacgia.Items.Add(dt.Rows[i]["MATG"].ToString());
                lvtacgia.Items[i].SubItems.Add(dt.Rows[i]["TENTACGIA"].ToString());
            }

        }

        private void lvtacgia_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void lvtacgia_Click(object sender, EventArgs e)
        {
            txtmatacgia.Text = lvtacgia.SelectedItems[0].SubItems[0].Text;
            txttentacgia.Text = lvtacgia.SelectedItems[0].SubItems[1].Text;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmatacgia.Text = "";
            txttentacgia.Text = "";
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            KiemTraDuLieuNhapVao();
            TacgiaDTO tg = new TacgiaDTO();
            tg.matacgia = txtmatacgia.Text;
            tg.tentacgia = txttentacgia.Text;
            TacgiaBUS.Them(tg);
            lvtacgia.Items.Clear();
            Load_LvTacgia();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            TacgiaDTO tg = new TacgiaDTO();
            tg.matacgia = txtmatacgia.Text;
            TacgiaBUS.Xoa(tg);
            lvtacgia.Items.Clear();
            Load_LvTacgia();

        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            KiemTraDuLieuNhapVao();
            TacgiaDTO tg = new TacgiaDTO();
            tg.matacgia = txtmatacgia.Text;
            tg.tentacgia = txttentacgia.Text;
            TacgiaBUS.Capnhat(tg);
            lvtacgia.Items.Clear();
            Load_LvTacgia();
        }
        private void KiemTraDuLieuNhapVao()
        {
            if (txtmatacgia.Text == "" && txttentacgia.Text == "")
            {
                MessageBox.Show("Các trường thông tin không được để trống!");
                return;
            }
        }
    }
}
