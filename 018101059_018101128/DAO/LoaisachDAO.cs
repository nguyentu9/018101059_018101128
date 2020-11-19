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
        public static void ThemSach(SachDTO sach) // formSach
        {
            string s = $"insert into SACH values ('{sach.mash}',N'{sach.tensach}'," +
                $"'{sach.maTL}','{sach.maTG}',N'{sach.NXB}',{sach.namSX}, {sach.soluong})";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void XoaSach(SachDTO sach) // formSach
        {
            string s = $"Delete from SACH where MASH='{sach.mash}'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void SuaSach(SachDTO sach) // formSach
        {
            string s = $"Update SACH set TENSACH=N'{sach.tensach}'," +
                $"MATL='{sach.maTL}',MATG='{sach.maTG}',NXB=N'{sach.NXB}',NAMSX={sach.namSX}, SOLUONG={sach.soluong} where MASH='{sach.mash}'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }

        public static DataTable Load_lv() // formSach - Load lên listView Sách
        {
            string s = "SELECT dbo.SACH.MASH, dbo.SACH.TENSACH, dbo.LOAI.TENTHELOAI, dbo.TACGIA.TENTACGIA, dbo.SACH.NXB, dbo.SACH.NAMSX, " +
                "dbo.SACH.SOLUONG FROM dbo.SACH INNER JOIN dbo.LOAI ON dbo.SACH.MATL = dbo.LOAI.MATL INNER JOIN dbo.TACGIA ON dbo.SACH.MATG = dbo.TACGIA.MATG";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static DataTable Load_TTSach() // formSach - Load lên combo Loại sách
        {
            string s = "select * from LOAI";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }


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
