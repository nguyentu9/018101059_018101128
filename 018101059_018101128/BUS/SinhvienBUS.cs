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
    class SinhvienBUS
    {
        public static DataTable Thongtin_sv1()
        {
            DataTable dt = new DataTable();
            dt = SinhvienDAO.Thongtin_SV();
            return dt;
        }
        public static DataTable Thongtin_Khoa()
        {
            DataTable dt = new DataTable();
            dt = SinhvienDAO.Thongtin_Khoa();
            return dt;
        }
        public static DataTable Thongtin_CT(string masv)
        {
            DataTable dt = new DataTable();
            dt = SinhvienDAO.Thongtin_CT(masv);
            return dt;
        }
        public static void ThemSV(SinhvienDTO sv)
        {
            try
            {
                SinhvienDAO.ThemSV(sv);
            }
            catch (Exception)
            {
                MessageBox.Show("Them sinh vien khong thanh cong");
            }
        }
        public static void CapnhatSV(SinhvienDTO sv)
        {
            try
            {
                SinhvienDAO.CapnhatSV(sv);
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the cap nhat sinh vien");
            }
        }
        public static void XoaSV(SinhvienDTO sv)
        {
            if ((MessageBox.Show("Ban co muon xoa sinh vien nay?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                try
                {
                    SinhvienDAO.XoaSV(sv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Khong the xoa sinh vien nay");
                }
        }
    }
}
