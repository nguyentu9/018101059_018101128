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
    public partial class frmPhieuMuon : Form
    {
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void Load_Listview()
        {
            DataTable dt = new DataTable();
            dt = PhieumuonBUS.CTPM();
            DataTable dtnv = new DataTable();
            dtnv = PhieumuonDAO.NV();
            for (int i=0; i< dt.Rows.Count; i++)
            {
                lvphieumuon.Items.Add(dt.Rows[i]["SOPM"].ToString());
                lvphieumuon.Items[i].SubItems.Add(dt.Rows[i]["ngaymuon"].ToString());
                lvphieumuon.Items[i].SubItems.Add(dt.Rows[i]["ngaytra"].ToString());
                lvphieumuon.Items[i].SubItems.Add(dt.Rows[i]["hoten"].ToString());
                lvphieumuon.Items[i].SubItems.Add(dt.Rows[i]["tensach"].ToString());
                lvphieumuon.Items[i].SubItems.Add(dt.Rows[i]["mathe"].ToString());
                
                for (int j=0;j<dtnv.Rows.Count; j++)
                {
                    if (dt.Rows[i]["manv"].ToString() == dtnv.Rows[j]["manv"].ToString())
                        lvphieumuon.Items[i].SubItems.Add(dtnv.Rows[j]["hoten"].ToString());
                }
            
            }
            
        }
        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            Load_Listview();
            loadCBBnv();
            loadCBBsv();
            Load_CBBls();
        }

      
        private void btnthem_Click(object sender, EventArgs e)
        {
            cbbnhanvien.Text = cbbsinhvien.Text =cbbsach.Text= "";
        }

        private void lvphieumuon_Click(object sender, EventArgs e)
        {
            txtsopm.Text = lvphieumuon.SelectedItems[0].SubItems[0].Text;
            dtpngaymuon.Text = lvphieumuon.SelectedItems[0].SubItems[1].Text;
            dtpngaytra.Text=lvphieumuon.SelectedItems[0].SubItems[2].Text;
            cbbsinhvien.Text= lvphieumuon.SelectedItems[0].SubItems[3].Text ;
            cbbsach.Text= lvphieumuon.SelectedItems[0].SubItems[4].Text;
            txtmathe.Text = lvphieumuon.SelectedItems[0].SubItems[5].Text;
            cbbnhanvien.Text = lvphieumuon.SelectedItems[0].SubItems[6].Text;
           
        }
        public void loadCBBnv()
        {
            DataTable dt = new DataTable();
            dt = PhieumuonBUS.NV();
            cbbnhanvien.DataSource = dt;
            cbbnhanvien.DisplayMember = "hoten";
            cbbnhanvien.ValueMember = "manv";
        }
        public void loadCBBsv()
        {
            DataTable dt = new DataTable();
            dt = PhieumuonBUS.SV();
            cbbsinhvien.DataSource = dt;
            cbbsinhvien.DisplayMember = "hoten";
            cbbsinhvien.ValueMember = "masv";
        }
        public void Load_CBBls()
        {
            DataTable dt = new DataTable();
            dt = PhieumuonDAO.SACH();
            cbbsach.DataSource = dt;
            cbbsach.DisplayMember = "Tensach";
            cbbsach.ValueMember = "Mash";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            PhieumuonDTO pm = new PhieumuonDTO();
            pm.manv = cbbnhanvien.SelectedValue.ToString();
            pm.mash = cbbsach.SelectedValue.ToString();
            pm.mathe = txtmathe.Text;
            pm.ngaymuon = string.Format("{0:MM/dd/yyyy}", dtpngaymuon.Value);
            pm.ngaytra = string.Format("{0:MM/dd/yyyy}", dtpngaytra.Value);
            pm.masv = cbbsinhvien.SelectedValue.ToString();
            PhieumuonDAO.ThemPM(pm);
            lvphieumuon.Items.Clear();
            Load_Listview();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            PhieumuonDTO pm = new PhieumuonDTO();
            pm.sopm = lvphieumuon.SelectedItems[0].SubItems[0].Text;
            pm.manv = cbbnhanvien.SelectedValue.ToString();
            pm.mash = cbbsach.SelectedValue.ToString();
            pm.mathe = txtmathe.Text;
            pm.ngaymuon = string.Format("{0:MM/dd/yyyy}", dtpngaymuon.Value);
            pm.ngaytra = string.Format("{0:MM/dd/yyyy}", dtpngaytra.Value);
            pm.masv = cbbsinhvien.SelectedValue.ToString();
            PhieumuonDAO.CapnhatPM(pm);
            lvphieumuon.Items.Clear();
            Load_Listview();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            PhieumuonDTO pm = new PhieumuonDTO();
            pm.sopm = lvphieumuon.SelectedItems[0].SubItems[0].Text;
            PhieumuonBUS.XoaPM(pm);
            lvphieumuon.Items.Clear();
            Load_Listview();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
