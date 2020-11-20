using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _018101059_018101128.DTO;
namespace _018101059_018101128.DAO
{
    class TinhTrangDAO
    {
        public static DataTable ThongTin_TT()
        {
            string s = "select * from TINHTRANG";
            DataTable dt = new DataTable();
            dt = KetnoiCSDL.ExcuteQuery(s);
            return dt;
        }
        public static void Them(TinhTrangDTO t)
        {
            string s = $"insert into TINHTRANG values(N'{t.ten}')";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Capnhat(TinhTrangDTO t)
        {
            string s = $"Update TINHTRANG set TENTT=N'{t.ten}' where MATT='{t.ma}'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
        public static void Xoa(TinhTrangDTO t)
        {
            string s = $"Delete From TINHTRANG where MATT='{t.ma}'";
            KetnoiCSDL.ExcuteNonQuery(s);
        }
    }
}
