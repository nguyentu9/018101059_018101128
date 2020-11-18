using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _018101059_018101128.DAO;

namespace _018101059_018101128.BUS
{
    class DangNhapBUS
    {
        public static string KiemTraTaiKhoan(string tendangnhap)
        {
            return DangNhapDAO.KiemTraTaiKhoan(tendangnhap);
        }
        public static string KiemTraMatKhau(string tendangnhap)
        {
            return DangNhapDAO.KiemTraMatKhau(tendangnhap);
        }
    }
}
