using _018101059_018101128.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018101059_018101128.DAO
{
    class KhoaDAO
    {
        public static DataTable TT_Khoa()
        {
            string s = "select * from KHOA";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static void Them(KhoaDTO k)
        {
            string s = "insert into KHOA values ('" + k.makhoa + "', '" + k.tenkhoa + "')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Capnhat(KhoaDTO k)
        {
            string s = "Update KHOA set TENKHOA='" + k.tenkhoa + "' where MAKHOA='" + k.makhoa + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Xoa(KhoaDTO k)
        {
            string s = "Delete From KHOA where MAKHOA='" + k.makhoa + "'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }

    }
}
