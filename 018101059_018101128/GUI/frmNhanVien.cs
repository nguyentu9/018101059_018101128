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
          
            loadDatagridview();
        }
       
       public void loadDatagridview()
        {
            DataTable dt = new DataTable();
            dt = NhanvienBUS.Nhanvien();
            dataGridNV.DataSource = dt;
        }
            
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            int sonv = dataGridNV.Rows.Count;
            txtmanv.Text = "NV" + String.Format("{0:00}", sonv + 1);
            txtmanv.Enabled = false;
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
            loadDatagridview();
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
            loadDatagridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanvienDTO nv = new NhanvienDTO();
            nv.manv = txtmanv.Text;
            NhanvienBUS.XoaNV(nv);
            loadDatagridview();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void dataGridNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dataGridNV.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            txthoten.Text = dataGridNV.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            dtpngaysinh.Text = dataGridNV.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
            txtdiachi.Text = dataGridNV.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            txtsdt.Text = dataGridNV.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            if (dataGridNV.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "True")
                radnam.Checked = true;
            else radnu.Checked = true;
        }
    }
}
