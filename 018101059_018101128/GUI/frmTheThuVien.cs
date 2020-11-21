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

namespace _018101059_018101128.GUI
{
    public partial class frmTheThuVien : Form
    {
        public frmTheThuVien()
        {
            InitializeComponent();
        }

        private void frmTheThuVien_Load(object sender, EventArgs e)
        {
            Load_theTV();
            Load_SV();
        }
        public void Load_SV()
        {
            DataTable dt = new DataTable();
            dt = ThethuvienBUS.SV();
            cbbSV.DataSource = dt;
            cbbSV.DisplayMember = "Hoten";
            cbbSV.ValueMember = "masv";
        }
        public void Load_theTV()
        {
            DataTable dt = new DataTable();
            dt = ThethuvienBUS.Lvthethuvien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvthethuvien.Items.Add(dt.Rows[i]["mathe"].ToString());
                lvthethuvien.Items[i].SubItems.Add(dt.Rows[i]["hoten"].ToString());
                lvthethuvien.Items[i].SubItems.Add(dt.Rows[i]["ngaycap"].ToString());
                lvthethuvien.Items[i].SubItems.Add(dt.Rows[i]["ngayhethan"].ToString());
            }
         }

        private void lvthethuvien_Click(object sender, EventArgs e)
        {
            txtmathe.Text = lvthethuvien.SelectedItems[0].SubItems[0].Text;
            cbbSV.Text = lvthethuvien.SelectedItems[0].SubItems[1].Text;
            dtpngaycap.Text = lvthethuvien.SelectedItems[0].SubItems[2].Text;
            dtpngayhethan.Text = lvthethuvien.SelectedItems[0].SubItems[3].Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbbSV.Text = "";
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            ThethuvienDTO t = new ThethuvienDTO();
            t.masv = cbbSV.SelectedValue.ToString();
            t.ngaycap = string.Format("{0:MM/dd/yyyy}", dtpngaycap.Value);
            t.ngayhethan = string.Format("{0:MM/dd/yyyy}", dtpngayhethan.Value);
            ThethuvienBUS.Them(t);
            lvthethuvien.Items.Clear();
            Load_theTV();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ThethuvienDTO t = new ThethuvienDTO();
            t.mathe = lvthethuvien.SelectedItems[0].SubItems[0].Text;
            t.masv = cbbSV.SelectedValue.ToString();
            t.ngaycap = string.Format("{0:MM/dd/yyyy}", dtpngaycap.Value);
            t.ngayhethan = string.Format("{0:MM/dd/yyyy}", dtpngayhethan.Value);
            ThethuvienBUS.Capnhat(t);
            lvthethuvien.Items.Clear();
            Load_theTV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThethuvienDTO t = new ThethuvienDTO();
            t.mathe = lvthethuvien.SelectedItems[0].SubItems[0].Text;
            ThethuvienBUS.Xoa(t);
            lvthethuvien.Items.Clear();
            Load_theTV();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

