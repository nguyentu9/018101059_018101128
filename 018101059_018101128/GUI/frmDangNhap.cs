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
using _018101059_018101128.GUI;

namespace _018101059_018101128
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        int solan;
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(solan == 3)
            {
                MessageBox.Show("Nhập sai quá 3 lần thoát chương trình");
                System.Environment.Exit(0);
            }
            if(txtmatkhau.Text == "" || txtmatkhau.Text == "")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                solan++;
                return;
            }

            string tenDN_CSDL = DangNhapBUS.KiemTraTaiKhoan(txttendangnhap.Text);
            if(txttendangnhap.Text != tenDN_CSDL)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                solan++;
                return;
            }

            string mkDN_CSDL = DangNhapBUS.KiemTraMatKhau(txttendangnhap.Text);
            if (txtmatkhau.Text != mkDN_CSDL)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                solan++;
                return;
            }

            frmMenu frm = new frmMenu();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            solan = 0;
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
