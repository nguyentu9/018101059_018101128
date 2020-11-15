using _018101059_018101128.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018101059_018101128.DAO
{
    class PhieunhapDAO
    {

        public static DataTable Cbb_Phieunhap()
        {
            string s = "select MAPN from PHIEUNHAP";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }


        public static DataTable CT_Phieunhap(string mapn)
        {
            string s = "Select n.MANV, HOTEN, c.MANCC, TENNCC, NGAYNHAP, MAPN " +
                "From PHIEUNHAP p, NHANVIEN n, NHACC c " +
                "where p.MANV=n.MANV and p.MANCC=c.MANCC and MAPN='"+mapn+"'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable LoadcbbNhanvien()
        {
            string s = "select MANV, HOTEN from NHANVIEN";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable LoadcbbNCC()
        {
            string s = "select MANCC, TENNCC from NHACC";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static void ThemPn(PhieunhapDTO pn)
        {
            string s = "INSERT INTO PHIEUNHAP VALUES ('" + pn.mapn + "','"+pn.ngaynhap+"','"+pn.mancc+"','"+pn.manv+"')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void CapnhatPn(PhieunhapDTO pn)
        {
            string s = "Update PHIEUNHAP set NGAYNHAP='"+pn.ngaynhap+"', MANCC='"+pn.mancc+"', " +
                "MANV='"+pn.manv+"' where MAPN='"+pn.mapn+"'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void XoaPn(PhieunhapDTO pn)
        {
            string s = "Delete From PHIEUNHAP where MAPN='" + pn.mapn + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
