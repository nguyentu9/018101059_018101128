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
      
        public static void ThemSV(SinhvienDTO sv)
        {
            try
            {
                SinhvienDAO.ThemSV(sv);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm sinh viên không thành công");
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
                MessageBox.Show("Không thể cập nhật sinh viên");
            }
        }
        public static void XoaSV(SinhvienDTO sv)
        {
            if ((MessageBox.Show("Bạn có muốn xóa sinh viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                try
                {
                    SinhvienDAO.XoaSV(sv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa sinh viên");
                }
        }
    }
}
