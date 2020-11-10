using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using _018101059_018101128.DAO;
using _018101059_018101128.DTO;
namespace _018101059_018101128.BUS
{
    class NhanvienBUS
    {
        public static DataTable Nhanvien()
        {
            return NhanvienDAO.Nhanvien();
        }
        public static void ThemNV(NhanvienDTO nv)
        {
            try
            {
                NhanvienDAO.ThemNV(nv);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }
        public static void CapnhatNV(NhanvienDTO nv)
        {
            try
            {
                NhanvienDAO.CapnhatNV(nv);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật nhân viên thất bại");
            }
        }
        public static void XoaNV(NhanvienDTO nv)
        {
            try
            {
                NhanvienDAO.XoaNV(nv);
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá nhân viên thất bại");
            }
        }

    }
}
