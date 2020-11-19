using _018101059_018101128.DAO;
using _018101059_018101128.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018101059_018101128.BUS
{
    class LoaisachBUS
    {
        public static void ThemSach(SachDTO sach)
        {
            try
            {
                LoaisachDAO.ThemSach(sach);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thêm sách");
            }
        }
        public static void SuaSach(SachDTO sach)
        {
            try
            {
                LoaisachDAO.SuaSach(sach);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
        public static void XoaSach(SachDTO sach)
        {
            if ((MessageBox.Show("Bạn có muốn xóa sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                try
                {
                    LoaisachDAO.XoaSach(sach);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá thất bại");
                }
        }
        public static DataTable Load_lv() // formSach
        {
            return LoaisachDAO.Load_lv();
        }
        public static DataTable Load_TTSach() // formSach
        {
            return LoaisachDAO.Load_TTSach();
        }
        public static DataTable Loaisach()
        {
            DataTable dt = new DataTable();
            dt = LoaisachDAO.Loaisach();
            return dt;
        }
        public static DataTable khoa()
        {
            DataTable dt = new DataTable();
            dt = LoaisachDAO.khoa();
            return dt;
        }
        public static DataTable TT_CT(string matl)
        {
            DataTable dt = new DataTable();
            dt = LoaisachDAO.TT_CT(matl);
            return dt;
        }
        public static void ThemLS(LoaisachDTO ls)
        {
            try
            {
                LoaisachDAO.ThemLS(ls);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thêm thể loại sách");
            }
        }
        public static void CapnhatLS(LoaisachDTO ls)
        {
            try
            {
                LoaisachDAO.CapnhatLS(ls);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
        public static void XoaLS(LoaisachDTO ls)
        {
            if ((MessageBox.Show("Bạn có muốn xóa thể loại này??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                try
                {
                    LoaisachDAO.XoaLS(ls);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa");
                }
        }
    }
}
