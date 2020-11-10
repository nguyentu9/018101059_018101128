using _018101059_018101128.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018101059_018101128.DAO
{
    class NhanvienDAO
    {
        public static DataTable Nhanvien()
        {
            string s = "select * From NHANVIEN";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static void ThemNV(NhanvienDTO nv)
        { 
            string s= "INSERT INTO NhanVien([MaNV], [HoTen],[NgaySinh], [GioiTinh], [DiaChi],[SDT]) VALUES('"+nv.manv+"', '"+nv.hoten+"','"+nv.ngaysinh+"','"+nv.gioitinh+"','"+nv.diachi+"','"+nv.sdt+"')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void CapnhatNV(NhanvienDTO nv)
        {
            string sql = "Update NhanVien set HoTen='" + nv.hoten + "', NgaySinh='" + nv.ngaysinh + "',GioiTinh='" + nv.gioitinh + "',DiaChi ='" + nv.diachi + "',SDT='"+nv.sdt+"' where MaNV='" + nv.manv + "'";
            KetnoiCSDL.ExcuteNonQuery(sql);
        }
        public static void XoaNV(NhanvienDTO nv)
        {
            string s = "Delete from NhanVien where MaNV='" + nv.manv + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
