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
        }
        public void Load_lv()
        {
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
    }
}
