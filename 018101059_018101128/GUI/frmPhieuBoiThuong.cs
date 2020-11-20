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
using _018101059_018101128.DTO;
namespace _018101059_018101128
{
    public partial class frmPhieuBoiThuong : Form
    {
        public frmPhieuBoiThuong()
        {
            InitializeComponent();
        }

        private void frmPhieuBoiThuong_Load(object sender, EventArgs e)
        {
            txtsobt.Enabled = false;
            Load_NhanVien();
            Load_TinhTrang();
            Load_GiaiQuyet();
            Load_ThongTin_BT();
            Load_SinhVien();
        }
        private void Load_ThongTin_BT()
        {
            lvboithuong.Items.Clear();
            DataTable dt = BoiThuongBUS.ThongTin_BT();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvboithuong.Items.Add(dt.Rows[i]["SOBT"].ToString());
                lvboithuong.Items[i].SubItems.Add(dt.Rows[i]["MASV"].ToString());
                lvboithuong.Items[i].SubItems.Add(dt.Rows[i]["TENSV"].ToString());
                lvboithuong.Items[i].SubItems.Add(dt.Rows[i]["TENNV"].ToString());
                lvboithuong.Items[i].SubItems.Add(dt.Rows[i]["TENTT"].ToString());
                lvboithuong.Items[i].SubItems.Add(dt.Rows[i]["TENGQ"].ToString());
            }
        }
        private void Load_SinhVien()
        {
            DataTable dt = new DataTable();
            dt = BoiThuongBUS.Load_SinhVien();
            cbosinhvien.DataSource = dt;
            cbosinhvien.DisplayMember = "HOTEN";
            cbosinhvien.ValueMember = "MASV";
        }
        private void Load_NhanVien()
        {
            DataTable dt = new DataTable();
            dt = BoiThuongBUS.Load_NhanVien();
            cbonhanvien.DataSource = dt;
            cbonhanvien.DisplayMember = "HOTEN";
            cbonhanvien.ValueMember = "MANV";
        }
        private void Load_TinhTrang()
        {
            DataTable dt = new DataTable();
            dt = BoiThuongBUS.Load_TinhTrang();
            cbotinhtrang.DataSource = dt;
            cbotinhtrang.DisplayMember = "TENTT";
            cbotinhtrang.ValueMember = "MATT";
        }
        private void Load_GiaiQuyet()
        {
            DataTable dt = new DataTable();
            dt = BoiThuongBUS.Load_GiaiQuyet();
            cbogiaiquyet.DataSource = dt;
            cbogiaiquyet.DisplayMember = "TENGQ";
            cbogiaiquyet.ValueMember = "MAGQ";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            BoiThuongDTO b = new BoiThuongDTO()
            {

                matt = cbotinhtrang.SelectedValue.ToString() != "" ? cbotinhtrang.SelectedValue.ToString() :
                    cbotinhtrang.ValueMember.ToString(),
                magq = cbogiaiquyet.SelectedValue.ToString() != "" ? cbogiaiquyet.SelectedValue.ToString() :
                    cbogiaiquyet.ValueMember.ToString(),
                manv = cbonhanvien.SelectedValue.ToString() != "" ? cbonhanvien.SelectedValue.ToString() :
                    cbonhanvien.ValueMember.ToString(),
                masv = cbosinhvien.SelectedValue.ToString() != "" ? cbosinhvien.SelectedValue.ToString() :
                    cbosinhvien.ValueMember.ToString(),
            };
            BoiThuongBUS.Them(b);
            Load_ThongTin_BT();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvboithuong.SelectedIndices.Count > 0)
            {
                BoiThuongDTO b = new BoiThuongDTO()
                {
                    sobt = lvboithuong.SelectedItems[0].SubItems[0].Text
                };
                DialogResult thongbao = MessageBox.Show("Bạn có chắc muốn xoá", "Thông báo", MessageBoxButtons.YesNo);
                if( thongbao == DialogResult.Yes)
                    BoiThuongBUS.Xoa(b);
                Load_ThongTin_BT();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sinh viên cần xoá!");
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (lvboithuong.SelectedIndices.Count > 0)
            {
                BoiThuongDTO b = new BoiThuongDTO()
                {
                    sobt = lvboithuong.SelectedItems[0].SubItems[0].Text,
                    matt = cbotinhtrang.SelectedValue.ToString() != "" ? cbotinhtrang.SelectedValue.ToString() :
                        cbotinhtrang.ValueMember.ToString(),
                    magq = cbogiaiquyet.SelectedValue.ToString() != "" ? cbogiaiquyet.SelectedValue.ToString() :
                        cbogiaiquyet.ValueMember.ToString(),
                    manv = cbonhanvien.SelectedValue.ToString() != "" ? cbonhanvien.SelectedValue.ToString() :
                        cbonhanvien.ValueMember.ToString(),
                    masv = cbosinhvien.SelectedValue.ToString() != "" ? cbosinhvien.SelectedValue.ToString() :
                        cbosinhvien.ValueMember.ToString(),
                };
                BoiThuongBUS.Capnhat(b);
                Load_ThongTin_BT();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sinh viên cần cập nhật!");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvboithuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvboithuong.SelectedIndices.Count > 0)
            {
                txtsobt.Text = lvboithuong.SelectedItems[0].SubItems[0].Text;
                cbosinhvien.Text = lvboithuong.SelectedItems[0].SubItems[2].Text;
                cbonhanvien.Text = lvboithuong.SelectedItems[0].SubItems[3].Text;
                cbotinhtrang.Text = lvboithuong.SelectedItems[0].SubItems[4].Text;
                cbogiaiquyet.Text = lvboithuong.SelectedItems[0].SubItems[5].Text;

            }
        }
    }
}
