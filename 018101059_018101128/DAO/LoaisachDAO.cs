using _018101059_018101128.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018101059_018101128.DAO
{
    class LoaisachDAO
    {
        public static DataTable Loaisach()
        {
            string s = "select MATL, TENTHELOAI, k.MAKHOA, TENKHOA " +
                "from KHOA k, LOAI l where k.MAKHOA=l.MAKHOA";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable khoa()
        {
            string s = "select distinct MAKHOA, TENKHOA from KHOA";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable TT_CT(string matl)
        {
            string s = "select MATL, TENTHELOAI, k.MAKHOA, TENKHOA " +
                "from KHOA k, LOAI l where k.MAKHOA=l.MAKHOA and MATL='" + matl + "'";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static void ThemLS(LoaisachDTO ls)
        {
            string s = "insert into LOAI values ('"+ls.matl+"', N'"+ls.tentl+"','"+ls.makhoa+"')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void CapnhatLS(LoaisachDTO ls)
        {
            string s = "Update LOAI set TENTHELOAI=N'" + ls.tentl + "',MAKHOA='" + ls.makhoa + "' where MATL='" + ls.matl + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void XoaLS(LoaisachDTO ls)
        {
            string s = "Delete from LOAI where MATL='" + ls.matl + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
