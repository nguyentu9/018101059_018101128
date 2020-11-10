using _018101059_018101128.DAO;
using _018101059_018101128.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018101059_018101128
{
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        public void Loadlvphieunhap()
        {
            lvphieunhap.Items.Clear();
            DataTable dt = new DataTable();
            dt = PhieunhapDAO.Phieunhap();
            int sopn = dt.Rows.Count;
            for (int i = 0; i < sopn; i++)
            {
                lvphieunhap.Items.Add(dt.Rows[i]["MAPN"].ToString());
                lvphieunhap.Items[i].SubItems.Add(dt.Rows[i]["NGAYNHAP"].ToString());
                lvphieunhap.Items[i].SubItems.Add(dt.Rows[i]["MANCC"].ToString());
                lvphieunhap.Items[i].SubItems.Add(dt.Rows[i]["HOTEN"].ToString());
            }
        }
        public void cbbNhanvien()
        {
            DataTable dt = new DataTable();
            dt = PhieunhapDAO.LoadcbbNhanvien();
            cbbnv.DataSource = dt;
            cbbnv.DisplayMember = "HOTEN";
            cbbnv.ValueMember = "MANV";
        }
        public void cbbNcc()
        {
            DataTable dt = new DataTable();
            dt = PhieunhapDAO.LoadcbbNCC();
            cbbncc.DataSource = dt;
            cbbncc.DisplayMember = "TENNCC";
            cbbncc.ValueMember = "MANCC";
        }
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
        }    
        private void lvphieunhap_Click(object sender, EventArgs e)
        {
            txtphieunhap.Text = lvphieunhap.SelectedItems[0].SubItems[0].Text;
            dtpngaynhap.Text = lvphieunhap.SelectedItems[0].SubItems[1].Text;
            cbbncc.Text = lvphieunhap.SelectedItems[0].SubItems[2].Text;
            cbbnv.Text = lvphieunhap.SelectedItems[0].SubItems[3].Text;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            int sopn = lvphieunhap.Items.Count;
            txtphieunhap.Text = "PN" + String.Format("{0:00}", sopn + 1);
        }
        private void btnghi_Click(object sender, EventArgs e)
        {
            PhieunhapDTO pn = new PhieunhapDTO();
            pn.mapn = txtphieunhap.Text;
            pn.ngaynhap = dtpngaynhap.Value.ToString();
            pn.mancc = cbbncc.SelectedValue.ToString();
            pn.manv = cbbnv.SelectedValue.ToString();
            PhieunhapDAO.ThemPn(pn);
            lvphieunhap.Items.Clear();
            Loadlvphieunhap();
        }
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            PhieunhapDTO pn = new PhieunhapDTO();
            pn.mapn = txtphieunhap.Text;
            pn.ngaynhap = dtpngaynhap.Value.ToString();
            pn.mancc = cbbncc.SelectedValue.ToString();
            pn.manv = cbbnv.SelectedValue.ToString();
            PhieunhapDAO.CapnhatPn(pn);
            lvphieunhap.Items.Clear();
            Loadlvphieunhap();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            PhieunhapDTO pn = new PhieunhapDTO();
            pn.mapn = txtphieunhap.Text;
            PhieunhapDAO.XoaPn(pn);
            lvphieunhap.Items.Clear();
            Loadlvphieunhap();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
