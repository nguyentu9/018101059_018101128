using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _018101059_018101128.DAO
{
    class DangNhapDAO
    {
        public static string KiemTraTaiKhoan(string tendangnhap)
        {
            string s = $"select TENTAIKHOAN from TAIKHOAN where TENTAIKHOAN='{tendangnhap}'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt.Rows[0]["TENTAIKHOAN"].ToString();
        }
        public static string KiemTraMatKhau(string tendangnhap)
        {
            string s = $"select MATKHAU from TAIKHOAN where TENTAIKHOAN='{tendangnhap}'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt.Rows[0]["MATKHAU"].ToString();
        }

    }
}
