using _018101059_018101128.DAO;
using _018101059_018101128.DTO;
using _018101059_018101128.BUS;
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
{   public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            Load_lvnhanvien();
        }
        public void Load_lvnhanvien()
        {
            lvnhanvien.Items.Clear();
            DataTable dt = new DataTable();
            dt = NhanvienBUS.Nhanvien();
            int sonv = dt.Rows.Count;
            string gt;
            for (int i = 0; i < sonv; i++)
            {
                if (dt.Rows[i]["GioiTinh"].ToString() == "True")
                    gt = "Nam";
                else gt = "Nu";
                lvnhanvien.Items.Add(dt.Rows[i]["MaNV"].ToString());
                lvnhanvien.Items[i].SubItems.Add(dt.Rows[i]["HoTen"].ToString());
                lvnhanvien.Items[i].SubItems.Add(dt.Rows[i]["NgaySinh"].ToString());
                lvnhanvien.Items[i].SubItems.Add(gt);
                lvnhanvien.Items[i].SubItems.Add(dt.Rows[i]["DiaChi"].ToString());
                lvnhanvien.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
            }
        }
            
        private void lvnhanvien_Click(object sender, EventArgs e)
        {
            txtmanv.Text = lvnhanvien.SelectedItems[0].SubItems[0].Text;
            txthoten.Text= lvnhanvien.SelectedItems[0].SubItems[1].Text;
            dtpngaysinh.Text = lvnhanvien.SelectedItems[0].SubItems[2].Text;
            if (lvnhanvien.SelectedItems[0].SubItems[3].Text == "Nam")
                radnam.Checked = true;
            else radnu.Checked = true;
            txtdiachi.Text = lvnhanvien.SelectedItems[0].SubItems[4].Text;
            txtsdt.Text = lvnhanvien.SelectedItems[0].SubItems[5].Text;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int sonv = lvnhanvien.Items.Count;
            txtmanv.Text = "NV" + String.Format("{0:000}", sonv + 1);
            txtdiachi.ResetText();
            txthoten.ResetText();
            txtsdt.ResetText();
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            string gt;
            if (radnam.Checked == true)
                gt = "1";
            else gt = "0";
            NhanvienDTO nv = new NhanvienDTO();
            nv.manv = txtmanv.Text;
            nv.hoten = txthoten.Text;
            nv.ngaysinh = dtpngaysinh.Value.ToString();
            nv.gioitinh = gt;
            nv.diachi = txtdiachi.Text;
            nv.sdt = txtsdt.Text;
            NhanvienBUS.ThemNV(nv);
            Load_lvnhanvien();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string gt;
            if (radnam.Checked == true)
                gt = "1";
            else gt = "0";
            NhanvienDTO nv = new NhanvienDTO();
            nv.manv = txtmanv.Text;
            nv.hoten = txthoten.Text;
            nv.ngaysinh = dtpngaysinh.Value.ToString();
            nv.gioitinh = gt;
            nv.diachi = txtdiachi.Text;
            nv.sdt = txtsdt.Text;
            NhanvienBUS.CapnhatNV(nv);
            Load_lvnhanvien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanvienDTO nv = new NhanvienDTO();
            nv.manv = txtmanv.Text;
            NhanvienBUS.XoaNV(nv);
            lvnhanvien.Items.Clear();
            Load_lvnhanvien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
