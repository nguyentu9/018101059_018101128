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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        public frmMenu(frmDangNhap frmDangNhap)
        {
            InitializeComponent();
            _frmDangNhap = frmDangNhap;
        }
        frmDangNhap _frmDangNhap;
        public string taikhoan { get; set; }
        
        private void frmMenu_Load(object sender, EventArgs e)
        {
            txttaikhoan.Text = "Xin Chào " + taikhoan;
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmDangNhap.Show();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmDangNhap.Close();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.Show();
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Phiếu mượn chưa hoàn thành xong
        }

        private void phiếuBồiThườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuBoiThuong f = new frmPhieuBoiThuong();
            f.Show();
        }

        private void quảnLýThẻThưViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheThuVien f = new frmTheThuVien();
            f.Show();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach f = new frmSach();
            f.Show();
        }

        private void danhMụcLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoai f = new frmLoai();
            f.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmPhieuNhap f = new frmPhieuNhap();
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacGia f = new frmTacGia();
            f.Show();
        }

        private void tìnhTrạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTinhTrang f = new frmTinhTrang();
            f.Show();
        }

        private void giảiQuyếtSựCốSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaiQuyet f = new frmGiaiQuyet();
            f.Show();
        }
    }
}
