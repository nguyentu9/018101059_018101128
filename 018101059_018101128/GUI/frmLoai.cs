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
    public partial class frmLoai : Form
    {
        public frmLoai()
        {
            InitializeComponent();
        }
        public void Load_listBox()
        {
            DataTable dt = new DataTable();
            dt = LoaisachBUS.Loaisach();
            for (int i = 0; i < dt.Rows.Count; i++)
             listBox1.Items.Add(dt.Rows[i]["TENTHELOAI"].ToString());
        }
        private void frmLoai_Load(object sender, EventArgs e)
        {
            Load_listBox();
            LoadcbbKhoa();
        }
        public void LoadcbbKhoa()
        {
            DataTable dt = new DataTable();
            dt = LoaisachBUS.khoa();
            cbbKhoa.DataSource = dt;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "MAKHOA";
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = LoaisachBUS.Loaisach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (listBox1.SelectedItems[0].ToString() == dt.Rows[i]["TENTHELOAI"].ToString())
                {
                    txtmaloai.Text = dt.Rows[i]["MATL"].ToString();
                    txttenloai.Text = dt.Rows[i]["TENTHELOAI"].ToString();
                    cbbKhoa.Text = dt.Rows[i]["TENKHOA"].ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmaloai.Text = "";
            txttenloai.Text = "";
            cbbKhoa.Text = "";
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            LoaisachDTO ls = new LoaisachDTO();
            ls.matl = txtmaloai.Text;
            ls.tentl = txttenloai.Text;
            ls.makhoa = cbbKhoa.SelectedValue.ToString();
            LoaisachBUS.ThemLS(ls);
            listBox1.Items.Clear();
            Load_listBox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LoaisachDTO ls = new LoaisachDTO();
            ls.matl = txtmaloai.Text;
            LoaisachBUS.XoaLS(ls);
            listBox1.Items.Clear();
            Load_listBox();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoaisachDTO ls = new LoaisachDTO();
            ls.matl = txtmaloai.Text;
            ls.tentl = txttenloai.Text;
            ls.makhoa = cbbKhoa.SelectedValue.ToString();
            LoaisachBUS.CapnhatLS(ls);
            listBox1.Items.Clear();
            Load_listBox();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
