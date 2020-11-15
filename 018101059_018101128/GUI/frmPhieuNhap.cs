using _018101059_018101128.BUS;
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
        public void LoadcbbPN()
        {
            DataTable dt = new DataTable();
            dt = PhieunhapBUS.Cbb_Phieunhap();
            cbbPN.DataSource = dt;
            cbbPN.DisplayMember = "MAPN";
            cbbPN.ValueMember = "MAPN";

        }
        public void Chitiet_PN()
        {
            DataTable dt = new DataTable();
            dt = PhieunhapDAO.CT_Phieunhap(cbbPN.SelectedValue.ToString());
            txtphieunhap.Text = dt.Rows[0]["MAPN"].ToString();
            dtpngaynhap.Text = dt.Rows[0]["NGAYNHAP"].ToString();
            cbbncc.Text= dt.Rows[0]["TENNCC"].ToString();
            cbbnv.Text = dt.Rows[0]["HOTEN"].ToString();
        }
       /* public void Loadlvphieunhap()
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
        }*/
        public void LoadcbbNV()
        {
            DataTable dt = new DataTable();
            dt = PhieunhapDAO.LoadcbbNhanvien();
            cbbnv.DataSource = dt;
            cbbnv.DisplayMember = "HOTEN";
            cbbnv.ValueMember = "MANV";
        }

        public void LoadcbbNcc()
        {
            DataTable dt = new DataTable();
            dt = PhieunhapDAO.LoadcbbNCC();
            cbbncc.DataSource = dt;
            cbbncc.DisplayMember = "TENNCC";
            cbbncc.ValueMember = "MANCC";

        }
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadcbbPN();
            LoadcbbNcc();
            LoadcbbNV();
        }    
      
        private void btnthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PhieunhapBUS.Cbb_Phieunhap();
            int sopn = dt.Rows.Count+1;
            txtphieunhap.Text ="PN" + String.Format("{0:000}", sopn);
            cbbnv.Text = "";
            cbbncc.Text = "";
        }
        private void btnghi_Click(object sender, EventArgs e)
        {
            PhieunhapDTO pn = new PhieunhapDTO();
            pn.mapn = txtphieunhap.Text;
            pn.ngaynhap = dtpngaynhap.Value.ToString();
            pn.mancc = cbbncc.SelectedValue.ToString();
            pn.manv = cbbnv.SelectedValue.ToString();
            PhieunhapBUS.ThemPN(pn);
            LoadcbbPN();
        }
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            PhieunhapDTO pn = new PhieunhapDTO();
            pn.mapn = txtphieunhap.Text;
            pn.ngaynhap = dtpngaynhap.Value.ToString();
            pn.mancc = cbbncc.SelectedValue.ToString();
            pn.manv = cbbnv.SelectedValue.ToString();
            PhieunhapBUS.CapnhatPN(pn);
            LoadcbbPN();

        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            PhieunhapDTO pn = new PhieunhapDTO();
            pn.mapn = txtphieunhap.Text;
            PhieunhapBUS.Xoapn(pn);
            LoadcbbPN();

        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPN.SelectedValue.ToString() != "System.Data.DataRowView")
                Chitiet_PN();
        }
    }
}
