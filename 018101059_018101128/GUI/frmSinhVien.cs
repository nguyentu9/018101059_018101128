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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

       
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            Load_dataGridView();
            Load_Cbb();
        }

        public void Load_dataGridView()
        {
            DataTable dt = new DataTable();
            dt = SinhvienBUS.Thongtin_sv1();
            dataGridView1.DataSource = dt;
         }
        public void Load_Cbb()
        {
            DataTable dt = new DataTable();
            dt = SinhvienBUS.Thongtin_Khoa();
            cbbKhoa.DataSource = dt;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "MAKHOA";
        }
       
        private void btnghi_Click(object sender, EventArgs e)
        {
            
            SinhvienDTO sv = new SinhvienDTO();
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpngaysinh.Value);
            string gt;
            if (rdnam.Checked == true)
                gt = "1";
            else gt = "0";
            sv.masv = txtmasinhvien.Text;
            sv.hoten = txthoten.Text;
            sv.gioitinh = gt;
            sv.ngaysinh = ngay;
            sv.diachi = txtdiachi.Text;
            sv.makhoa = cbbKhoa.SelectedValue.ToString();
            sv.sdt = txtsodienthoai.Text;
            SinhvienBUS.ThemSV(sv);
            
            Load_dataGridView();
         
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = SinhvienBUS.Thongtin_sv1();
            int sosv = dt.Rows.Count;
            txtmasinhvien.Text = "SV" + String.Format("{0:000 }", sosv + 1);
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtsodienthoai.Text = "";
           
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SinhvienDTO sv = new SinhvienDTO();
            sv.masv = txtmasinhvien.Text;
            sv.makhoa = cbbKhoa.Text;
            SinhvienBUS.XoaSV(sv);
            Load_dataGridView();
        }


        private void btncapnhat_Click(object sender, EventArgs e)
        {
           
            SinhvienDTO sv = new SinhvienDTO();
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpngaysinh.Value);
            string gt;
            if (rdnam.Checked == true)
                gt = "1";
            else gt = "0";
            sv.masv = txtmasinhvien.Text;
            sv.hoten = txthoten.Text;
            sv.gioitinh = gt;
            sv.ngaysinh = ngay;
            sv.diachi = txtdiachi.Text;
            sv.makhoa = cbbKhoa.SelectedValue.ToString();
            sv.sdt = txtsodienthoai.Text;
            SinhvienBUS.CapnhatSV(sv);
            
            Load_dataGridView();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Số điện thoại không hợp lệ","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasinhvien.Text = dataGridView1.Rows[e.RowIndex].Cells["MASV"].FormattedValue.ToString();
            txthoten.Text = dataGridView1.Rows[e.RowIndex].Cells["HOTEN"].FormattedValue.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells["GIOITINH"].FormattedValue.ToString() == "True")
                rdnam.Checked = true;
            else rdnu.Checked = true;
            dtpngaysinh.Text = dataGridView1.Rows[e.RowIndex].Cells["NGAYSINH"].FormattedValue.ToString();
            txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells["DIACHI"].FormattedValue.ToString();
            cbbKhoa.Text = dataGridView1.Rows[e.RowIndex].Cells["TENKHOA"].FormattedValue.ToString();
            txtsodienthoai.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].FormattedValue.ToString();
        }
    }
    }

