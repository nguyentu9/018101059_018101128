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
    public partial class frmChiTietPhieuMuon : Form
    {
        public frmChiTietPhieuMuon()
        {
            InitializeComponent();
        }

        
        public void Load_lv()
        {
            DataTable dt = new DataTable();
            dt = CTPMDAO.CT_PM();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                lvchitietphieumuon.Items.Add(dt.Rows[i]["sopm"].ToString());
                lvchitietphieumuon.Items[i].SubItems.Add(dt.Rows[i]["tensach"].ToString());
                lvchitietphieumuon.Items[i].SubItems.Add(dt.Rows[i]["soluong"].ToString());
            }
        }
        public void load_CBB()
        {
            DataTable dt = new DataTable();
            dt = CTPMBUS.Sach();
            cbbsach.DataSource = dt;
            cbbsach.ValueMember = "mash";
            cbbsach.DisplayMember = "Tensach";
        }
        private void frmChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
           Load_lv();
            load_CBB();
        }

        private void lvchitietphieumuon_Click(object sender, EventArgs e)
        {
            txtsopm.Text = lvchitietphieumuon.SelectedItems[0].SubItems[0].Text;
            cbbsach.Text = lvchitietphieumuon.SelectedItems[0].SubItems[1].Text;
            numSoluong.Value = Convert.ToInt32(lvchitietphieumuon.SelectedItems[0].SubItems[2].Text);
            
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            CTPMDTO c = new CTPMDTO();
            c.mash = cbbsach.SelectedValue.ToString();
            c.soluong = numSoluong.Value.ToString();
            CTPMDAO.Them(c);
            lvchitietphieumuon.Items.Clear();
            Load_lv();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            CTPMDTO c = new CTPMDTO();
            c.sopm = lvchitietphieumuon.SelectedItems[0].SubItems[0].Text;
            c.mash = cbbsach.SelectedValue.ToString();
            c.soluong = numSoluong.Value.ToString();
            CTPMDAO.Capnhat(c);
            lvchitietphieumuon.Items.Clear();
            Load_lv();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            CTPMDTO c = new CTPMDTO();
            c.sopm = lvchitietphieumuon.SelectedItems[0].SubItems[0].Text;
            c.mash = cbbsach.SelectedValue.ToString();
            CTPMBUS.Xoa(c);
            lvchitietphieumuon.Items.Clear();
            Load_lv();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
